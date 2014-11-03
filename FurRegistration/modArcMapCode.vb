Imports System.Windows.Forms
Imports System.IO

Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Carto
Imports ESRI.ArcGIS.Geodatabase
'Imports ESRI.ArcGIS.GeoDatabaseDistributed
Imports ESRI.ArcGIS.esriSystem
'Imports ESRI.ArcGIS.Display
Imports ESRI.ArcGIS.Editor
Imports ESRI.ArcGIS.DataSourcesGDB
Imports ESRI.ArcGIS.Geometry
Imports ESRI.ArcGIS.Framework
'Imports ESRI.ArcGIS.EditorExt
'Imports ESRI.ArcGIS.SystemUI

Module modArcMapCode
    Public m_frmFurBearer As frmMain = Nothing
    Public m_Editor As IEditor = Nothing
    Public m_TempPath As String = "c:\temp"  'location of log file
    Public m_FieldValueArray As ArrayList

    'The name of the feature class you're looking for
    Public m_FeatureClassName As String = "Fur_Reg"
    Public m_FeatureClassPath As String = "I:\MRG\MIS\gis\Fur_Registration_Database\Fur_Registration.gdb"
    'The name of the various PLS layers
    Public m_PLSPath = "V:\gdrs\data\pub\us_mn_state_dnr\plan_mndnr_public_land_survey\fgdb\plan_mndnr_public_land_survey.gdb"
    Public m_PLSName = "pls_twpspy3"
    Public m_CountyPath = "V:\gdrs\data\pub\us_mn_state_dnr\bdry_counties_in_minnesota\fgdb\bdry_counties_in_minnesota.gdb"
    Public m_CountyName = "mn_county_boundaries"
    Public m_xCoord As Double = 0
    Public m_yCoord As Double = 0


#Region "TABLE FUNCTIONS"
    Public Function Table_GetFromPath(ByVal aPath As String, ByVal aName As String) As ITable
        'pass path including gdb name and name of table and function passes table object
        MessageBox.Show(aPath & "," & aName)
        Dim factoryType As Type = Type.GetTypeFromProgID("esriDataSourcesGDB.FileGDBWorkspaceFactory")

        Dim wf As IWorkspaceFactory
        Dim featureWorkspace As IFeatureWorkspace
        Try
            wf = CType(Activator.CreateInstance(factoryType), IWorkspaceFactory)
            featureWorkspace = TryCast(wf.OpenFromFile(aPath, 0), IFeatureWorkspace)
            Return featureWorkspace.OpenTable(aName)
        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        Finally
            factoryType = Nothing
            wf = Nothing
            featureWorkspace = Nothing
        End Try
    End Function
    Public Function Table_FindRow(ByVal pTable As ITable, ByVal aQueryString As String) As IRow
        'defining the table_findrow methods for use in next process
        Dim pQueryfilter As IQueryFilter
        Dim pCursor As ICursor
        Dim pRow As IRow
        Try
            pQueryfilter = New QueryFilter
            pQueryfilter.WhereClause = aQueryString
            pCursor = pTable.Search(pQueryfilter, True)
            pRow = pCursor.NextRow
            Return pRow
        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Finally
            pQueryfilter = Nothing
            pCursor = Nothing
            pRow = Nothing
        End Try
        Return Nothing
    End Function
    Public Function Table_GetLookup(ByVal aPath As String, ByVal aTable As String, ByVal aQuery As String, ByVal outField As String) As Object
        'Queries a table and returns one value from the out field that satisfy the query
        Dim val As Object = ""
        Dim pTable As ITable
        Dim pRow As IRow

        Try
            pTable = Table_GetFromPath(aPath, aTable)
            If pTable Is Nothing Then Return val
            pRow = Table_FindRow(pTable, aQuery)
            If pRow Is Nothing Then Return val
            If (pRow.Fields.FindField(outField) = -1) Then Throw New Exception("Field (" & outField & ") not found in query table")
            val = pRow.Value(pRow.Fields.FindField(outField))
        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Finally
            pTable = Nothing
            pRow = Nothing
        End Try
        Return val
    End Function
    Public Function Table_GetLookups(ByVal aPath As String, ByVal aTable As String, ByVal aQuery As String, ByVal outFieldValue As String) As ArrayList
        'Queries a table and returns one value from the out field that satisfy the query
        Dim val As Object = ""
        Dim pTable As ITable
        Dim pRow As IRow
        Dim pQueryfilter As IQueryFilter
        Dim pCursor As ICursor
        Dim arrList As New ArrayList()
        Try
            pTable = Table_GetFromPath(aPath, aTable)
            If pTable Is Nothing Then Return arrList
            pQueryfilter = New QueryFilter
            pQueryfilter.WhereClause = aQuery
            pCursor = pTable.Search(pQueryfilter, True)
            pRow = pCursor.NextRow

            If (pRow.Fields.FindField(outFieldValue) = -1) Then Throw New Exception("Field (" & outFieldValue & ") not found in query table")
            While Not pRow Is Nothing
                arrList.Add(pRow.Value(pRow.Fields.FindField(outFieldValue)))
                pRow = pCursor.NextRow
            End While
        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Finally
            pTable = Nothing
            pRow = Nothing
            pQueryfilter = Nothing
            pCursor = Nothing
        End Try
        Return arrList
    End Function
#End Region

#Region "LAYER/FEATURE CLASS CODE"
    Public Function FeatureClass_Find(ByVal aName As String) As IFeatureClass
        Dim retLayer As ILayer = Nothing
        Dim pMap As IMap = My.ArcMap.Document.FocusMap
        Dim pEnumLayer As IEnumLayer
        Dim pDataLayer As IDataLayer2
        Dim pDatasetName As IDatasetName2
        Dim pEnumDataSetNames As IEnumDatasetName
        Dim pDSName As IDatasetName2
        Dim dsName As String

        Try
            If (pMap.LayerCount = 0) Then Return Nothing

            pEnumLayer = CType(pMap.Layers(Nothing, True), IEnumLayer)
            pEnumLayer.Reset()

            retLayer = pEnumLayer.Next()
            While (Not retLayer Is Nothing)
                Try
                    If (TypeOf retLayer Is IFeatureLayer) Then
                        pDataLayer = CType(retLayer, IDataLayer2)
                        pDatasetName = CType(pDataLayer.DataSourceName, IDatasetName2)
                        If (Not pDatasetName Is Nothing) Then
                            dsName = pDatasetName.Name

                            If (dsName.Contains(".")) Then dsName = dsName.Substring(dsName.LastIndexOf(".") + 1)
                            If (dsName.ToUpper() = aName.ToUpper()) Then
                                'Found the layer so exit out of loop
                                MessageBox.Show(dsName)
                                Dim pFeatureLayer As IFeatureLayer = retLayer

                                Return pFeatureLayer.FeatureClass
                            End If
                        End If
                    End If
                Catch
                End Try

                retLayer = pEnumLayer.Next()
            End While

        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Finally
            pMap = Nothing
            pEnumLayer = Nothing
            pDataLayer = Nothing
            pDatasetName = Nothing
            retLayer = Nothing
            pEnumDataSetNames = Nothing
            pDSName = Nothing
        End Try
        Return Nothing
    End Function
    Public Function FeatureClass_GetFromPath(ByVal aPath As String, ByVal aName As String) As IFeatureClass
        Dim factoryType As Type = Type.GetTypeFromProgID("esriDataSourcesGDB.FileGDBWorkspaceFactory")
        'find input feature class for PLS query
        Dim wf As IWorkspaceFactory
        Dim featureWorkspace As IFeatureWorkspace
        Try
            wf = CType(Activator.CreateInstance(factoryType), IWorkspaceFactory)
            featureWorkspace = TryCast(wf.OpenFromFile(aPath, 0), IFeatureWorkspace)
            Return featureWorkspace.OpenFeatureClass(aName)
        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        Finally
            factoryType = Nothing
            wf = Nothing
            featureWorkspace = Nothing
        End Try
    End Function

    Public Function Directory_Copy(SourcePath As String, DestinationPath As String) As Boolean
        'source path = main gdb
        'dest path = gdb + date timestamp h/m/s

        Try
            If (SourcePath.ToLower() = DestinationPath.ToLower()) Then Return True

            'Delete directory if it already exists
            If (Directory.Exists(DestinationPath)) Then Directory.Delete(DestinationPath, True)

            Dim destPath As String
            'Now Create all of the directories
            'Start with outer most
            Directory.CreateDirectory(DestinationPath)
            'Then add inners.
            For Each dirPath In Directory.GetDirectories(SourcePath, "*", SearchOption.AllDirectories)
                destPath = dirPath.Replace(SourcePath, DestinationPath)
                Directory.CreateDirectory(destPath)
            Next

            'Copy all the files
            For Each newPath In Directory.GetFiles(SourcePath, "*.*", SearchOption.AllDirectories)
                If newPath.EndsWith(".lock") Then Continue For
                File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), True)
                'if (isCancel)  return false
            Next

        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return False
        End Try
        Return True
    End Function


    Public Function FeatureClass_SpatialQueryCount(ByVal aPath As String, ByVal aName As String, ByVal aShape As IGeometry, ByVal SPrEL As esriSpatialRelEnum) As Integer
        Dim c As Integer = 0
        Dim pSpatialFilter As ISpatialFilter
        Dim pFeatureClass As IFeatureClass
        Dim pCursor As ICursor
        'Dim workspaceFactory As IWorkspaceFactory
        Dim pWorkspace As IFeatureWorkspace
        Dim pRow As IRow
        Try
            pFeatureClass = FeatureClass_GetFromPath(aPath, aName)
            If pFeatureClass Is Nothing Then Return Nothing

            pSpatialFilter = New SpatialFilter()

            pSpatialFilter.Geometry = aShape
            pSpatialFilter.GeometryField = "Shape"
            'pSpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects
            pSpatialFilter.SpatialRel = SPrEL
            pCursor = pFeatureClass.Search(pSpatialFilter, True)
            pRow = pCursor.NextRow
            While Not pRow Is Nothing
                c += 1
                pRow = pCursor.NextRow
            End While

        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Finally
            pSpatialFilter = Nothing
            pFeatureClass = Nothing
            pCursor = Nothing
            pRow = Nothing
            pWorkspace = Nothing
        End Try
        Return c
    End Function
    Public Function FeatureClass_SpatialQuery(ByVal aPath As String, ByVal aName As String, ByVal aShape As ESRI.ArcGIS.Geometry.IGeometry) As IFeature
        Dim pSpatialFilter As ISpatialFilter
        Dim pFeatureClass As IFeatureClass
        Dim pFeatureCursor As IFeatureCursor

        Try
            pFeatureClass = featureclass_getFromPath(aPath, aName)
            If pFeatureClass Is Nothing Then Return Nothing

            pSpatialFilter = New SpatialFilter()
            pSpatialFilter.Geometry = aShape
            pSpatialFilter.GeometryField = "Shape"
            pSpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects

            pFeatureCursor = pFeatureClass.Search(pSpatialFilter, False)
            Return (pFeatureCursor.NextFeature())

        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Finally
            pSpatialFilter = Nothing
            pFeatureClass = Nothing
            pFeatureCursor = Nothing
        End Try
        Return Nothing
    End Function
#End Region

#Region "FORM CODE"
    Public Sub Form_EditAttributes()
        Dim appCursor As IMouseCursor = New MouseCursorClass

        Try
            appCursor.SetCursor(2)

            'Load the Form
            Form_Load()

            If m_frmFurBearer.ShowDialog() = Windows.Forms.DialogResult.OK Then
                appCursor.SetCursor(2)
                Form_Submit()
            End If
        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Finally
            appCursor = Nothing
        End Try
    End Sub
    Public Sub Form_Load()
        Dim pFeatureClass As IFeatureClass
        'Dim pID As New UID

        Try
            pFeatureClass = featureclass_Find(m_FeatureClassName)

            If pFeatureClass Is Nothing Then
                MessageBox.Show("Could not find " & m_FeatureClassName)
                Exit Sub
            End If

            If m_frmFurBearer Is Nothing Then
                m_frmFurBearer = New frmMain()

                'pID.Value = "esriEditor.Editor"
                'm_Editor = TryCast(My.ArcMap.Application.FindExtensionByCLSID(pID), IEditor)
            Else
                Exit Sub
            End If

            For Each ctl As Control In m_frmFurBearer.Controls
                Form_LoadControl(ctl, pFeatureClass)
            Next

        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Finally

        End Try
    End Sub

    Public Sub Form_LoadControl(ByRef ctl As Control, ByVal pTable As ITable)
        'Load items into the Comboboxes/listboxes and define min/max values for textboxes
        'Set Enabled/Disabled based on user's permissions
        Dim fieldName As String
        Dim fieldIndex As Integer
        Dim pField As IField
        Try
            'If it is a container then load controls within
            If ctl.HasChildren Then
                For Each ct In ctl.Controls
                    Form_LoadControl(ct, pTable)
                Next
                Exit Sub
            End If

            If TypeOf ctl Is clsCombobox Then
                'Get the Field 
                fieldName = CType(ctl, clsCombobox).npc_FieldName
                If fieldName = "" Then Exit Sub
                If CType(ctl, clsCombobox).Tag = "custid" Then
                    CType(ctl, clsCombobox).LoadLookupTable()
                Else

                    fieldIndex = pTable.FindField(fieldName)
                    If fieldIndex = -1 Then Exit Sub
                    pField = pTable.Fields.Field(fieldIndex)
                    CType(ctl, clsCombobox).LoadFromField(pField)

                End If

            ElseIf TypeOf ctl Is clsTextbox Then
                'Set the Field Type
                'Get the Field 
                fieldName = CType(ctl, clsTextbox).npc_FieldName
                If fieldName = "" Then Exit Sub
                fieldIndex = pTable.FindField(fieldName)
                If fieldIndex = -1 Then Exit Sub
                pField = pTable.Fields.Field(fieldIndex)
                CType(ctl, clsTextbox).npc_FieldType = pField.Type
                CType(ctl, clsTextbox).MaxLength = pField.Length
            ElseIf TypeOf ctl Is clsDateTimePicker Then

            End If
        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Finally
            pField = Nothing
        End Try
    End Sub

    Public Sub Form_Submit()

        Dim pFeature As IFeature = Nothing
        Dim workspaceEdit As IWorkspaceEdit2 = Nothing
        Dim pFeatureClass As IFeatureClass
        Dim pGeometry As IGeometry5 = Nothing
        Dim aPath As String = ""
        Dim aName As String = ""
        Dim aStatus As String = ""

        Try
            '**************  CREATE SHAPE.  If it is invalid then error to user!!! ****************
            Dim pPoint As IPoint
            pPoint = New Point()
            pPoint.X = m_xCoord
            pPoint.Y = m_yCoord

            pGeometry = pPoint

            If pGeometry Is Nothing Then
                MessageBox.Show("Error creating Shape")
                Exit Sub
            End If
            pFeatureClass = FeatureClass_Find(m_FeatureClassName)
            If pFeatureClass Is Nothing Then
                MessageBox.Show("Feature class is nothing")
            End If

            m_FieldValueArray = New ArrayList()
            For Each ctl In m_frmFurBearer.Controls
                Form_SetFieldValueArray(ctl, pFeatureClass)
            Next
            'Check to see if you are in an operation.
            Dim pDataset As IDataset = pFeatureClass
            'm_Editor.EditWorkspace = pDataset.Workspace
            'm_Editor.Workspace = pDataset.Workspace
            'workspaceEdit = CType(m_Editor.EditWorkspace, IWorkspaceEdit2)
            '?????? 
            workspaceEdit = pDataset.Workspace
            If workspaceEdit Is Nothing Then
                MessageBox.Show("workspace edit is nothing")
            End If
            If workspaceEdit.IsBeingEdited = False Then
                workspaceEdit.StartEditing(False)
            End If

            'If (Not workspaceEdit.IsInEditOperation) Then
            '    ' Close the first operation.
            '    m_Editor.StopOperation("edit")
            'End If
            'm_Editor.StartOperation()


            pFeature = pFeatureClass.CreateFeature()
            pFeature.Shape = pGeometry
            'MessageBox.Show("6")

            For Each va In m_FieldValueArray
                If va(1) Is Nothing Then Continue For
                Try
                    pFeature.Value(va(0)) = va(1)
                    'MessageBox.Show("Field Index: " & va(0) & ", Value: " & va(1))
                Catch ex As Exception
                    MessageBox.Show("field name: " & pFeature.Fields.Field(va(0)).Name & ", Value: " & va(1))
                End Try
              
            Next
            'MessageBox.Show("made it through populating feature")

            pFeature.Store()
            workspaceEdit.StopEditing(True)
            My.ArcMap.Document.ActiveView.Refresh()
            'm_Editor.StopOperation("Submitted Edits to Features in " & pFeatureClass.AliasName)
            'MessageBox.Show("7")
        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
            If Not workspaceEdit Is Nothing Then
                If workspaceEdit.IsInEditOperation Then My.ArcMap.Document.OperationStack.Undo() '  m_Editor.UndoOperation()
            End If
            'MessageBox.Show("8")
        Finally
            pFeature = Nothing
            workspaceEdit = Nothing
            pFeatureClass = Nothing
        End Try
        'MessageBox.Show("9")
    End Sub
    Public Sub Form_SetFieldValueArray(ByVal ctl As Control, ByVal pFeatureClass As IFeatureClass)
        'Pulls all the values out of controls and associates them with the proper field index from the feature class.
        'Returns a list of fieldIndex/Value pairs.
        Dim fIDX As Integer
        Try
            If ctl Is Nothing Then Exit Sub
            If ctl.HasChildren Then
                For Each ct In ctl.Controls
                    Form_SetFieldValueArray(ct, pFeatureClass)
                Next
                Exit Sub
            End If

            'If Not ctl.Enabled Then Exit Sub

            If TypeOf ctl Is clsTextbox Then
                fIDX = pFeatureClass.Fields.FindField(CType(ctl, clsTextbox).npc_FieldName)
                If fIDX = -1 Then Exit Sub
                'If pFeatureClass.Fields.Field(fIDX).Type = esriFieldType.esriFieldTypeString Then
                m_FieldValueArray.Add(New Object() {fIDX, CType(ctl, clsTextbox).Get_Value()})
                'Else
                '    Dim obj
                '    obj = CType(ctl, clsTextbox).Get_Value()
                '    obj = CType(obj, Long)
                '    m_FieldValueArray.Add(New Object() {fIDX, obj})
                'End If

            ElseIf TypeOf ctl Is clsDateTimePicker Then
                fIDX = pFeatureClass.Fields.FindField(CType(ctl, clsDateTimePicker).FieldName)
                If fIDX = -1 Then Exit Sub
                m_FieldValueArray.Add(New Object() {fIDX, CType(ctl, clsDateTimePicker).Get_Value()})
            ElseIf TypeOf ctl Is clsCombobox Then
                fIDX = pFeatureClass.Fields.FindField(CType(ctl, clsCombobox).npc_FieldName)
                If fIDX = -1 Then Exit Sub
                'check to see if the field name = customer ID then
                If (CType(ctl, clsCombobox).npc_FieldName = "CUSTOMER_I") Then
                    m_FieldValueArray.Add(New Object() {fIDX, CType(ctl.Text, Long)})
                Else
                    'm_FieldValueArray.Add(New Object() {fIDX, CType(ctl, clsCombobox).Get_Value()})
                    m_FieldValueArray.Add(New Object() {fIDX, CType(ctl, clsCombobox).Get_ValueAsString()})
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ctl.Name)
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Finally

        End Try
    End Sub
#End Region
#Region "ERROR HANDLING"
    Public Sub Error_Catch(ByVal ex As Exception, ByVal mName As String, Optional ByVal isQuiet As Boolean = False)
        Try
            If Not isQuiet Then MessageBox.Show(ex.Source + " - " + ex.Message, mName)

            File_WriteToLog(mName & ":  " & ex.Source + " - " + ex.Message)
        Catch e As Exception

        End Try
    End Sub
#End Region
#Region "FILE CODE"
    Public Function Directory_Create(ByVal path As String) As Boolean
        'Check to make sure the user path exists.  If not, create it.
        Try
            If Not Directory.Exists(path) Then
                Directory.CreateDirectory(path)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Error creating folder in ApplicationData folder: " + path + Environment.NewLine + ex.Message)
            Return False
        End Try
    End Function
    Public Sub File_WriteToLog(ByVal stringEntry As String, Optional ByVal timeStamp As Boolean = True, Optional ByVal precedingNewLine As Boolean = False)
        Try
            Dim aPath As String = m_TempPath  '.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\MNDNR\DNRNPC"
            If Not Directory.Exists(aPath) Then Directory_Create(aPath)
            aPath = aPath & "\NPC_POLYGONS_LOG.TXT"

            Dim SW As StreamWriter

            If (Not File.Exists(aPath)) Then
                SW = File.CreateText(aPath)
                If precedingNewLine Then SW.WriteLine("")
                SW.WriteLine("NPC_POLYGONS LogFile Starting: " & DateTime.Now & Environment.NewLine)
            Else
                SW = File.AppendText(aPath)
                If precedingNewLine Then SW.WriteLine("")
                If (timeStamp) Then
                    SW.WriteLine(DateTime.Now & "." & DateTime.Now.Millisecond & " - " & stringEntry)
                Else
                    SW.WriteLine(stringEntry)
                End If
            End If
            SW.Close()
        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Sub
    Public Sub File_CleanLog(Optional ByVal RetainDays As Long = 7)  ', Optional ByVal aPath As String = "")
        Dim TR As TextReader = Nothing
        Dim TW As TextWriter = Nothing
        Try
            Dim aPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\MNDNR\DNRNPC"
            aPath = aPath & "\NPC_POLYGONS_LOG.TXT"

            If (Not File.Exists(aPath)) Then Exit Sub
            TR = New StreamReader(aPath)
            TW = New StreamWriter(aPath & ".temp")

            TW.WriteLine("NPC_POLYGONS LogFile Starting: " & DateTime.Now & Environment.NewLine)
            Dim line As String = TR.ReadLine()
            Dim dtString As String = ""
            Dim dt As DateTime = DateTime.Now.Subtract(TimeSpan.FromDays(RetainDays))

            Dim logDate As DateTime
            While (Not line Is Nothing)
                'Get date at beginning of line
                Try

                    If (line.Contains("-")) Then
                        dtString = line.Split("-")(0)
                        If dtString.Contains(".") Then dtString = dtString.Split(".")(0)
                        logDate = Convert.ToDateTime(dtString)
                        If (logDate.CompareTo(dt) >= 0) Then
                            TW.WriteLine(line)
                        End If
                    End If
                Catch
                End Try
                line = TR.ReadLine()
            End While
            TR.Close()
            TW.Close()
            Dim fi As FileInfo = New FileInfo(aPath + ".temp")
            fi.Replace(aPath, Nothing)
            fi.Delete()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "MISC CODE"
    Public Sub Object_Release(ByVal obj As Object)
        Dim refsLeft As Integer = 0
        Try
            Do
                refsLeft = System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            Loop While (refsLeft > 0)
        Catch
        End Try
    End Sub
    Public Sub ValueDescriptionPair_Select(ByVal aControl As System.Object, ByVal aValue As [String], Optional ByVal byDescription As [Boolean] = False)
        'Selects an item in a listbox or combobox.
        Dim lbx As ListBox
        Dim cbx As ComboBox
        Dim dgvcbc As DataGridViewComboBoxCell

        Try
            If TypeOf aControl Is ListBox Then
                lbx = DirectCast(aControl, ListBox)
                For Each vdp As ValueDescriptionPair In lbx.Items
                    If byDescription Then
                        If vdp.Description.ToString() = aValue Then
                            lbx.SelectedItem = vdp
                            Return
                        End If
                    ElseIf vdp.Value.ToString() = aValue Then
                        lbx.SelectedItem = vdp
                        Return
                    End If
                Next
            ElseIf TypeOf aControl Is ComboBox Then
                cbx = DirectCast(aControl, ComboBox)
                For Each vdp As ValueDescriptionPair In cbx.Items
                    If byDescription Then
                        If vdp.Description.ToString() = aValue Then
                            cbx.SelectedItem = vdp
                            Return
                        End If
                    ElseIf vdp.Value.ToString() = aValue Then
                        cbx.SelectedItem = vdp
                        Return
                    End If
                Next
            ElseIf TypeOf aControl Is DataGridViewComboBoxCell Then
                dgvcbc = DirectCast(aControl, DataGridViewComboBoxCell)
                For Each vdp As ValueDescriptionPair In dgvcbc.Items
                    If byDescription Then
                        If vdp.Description.ToString() = aValue Then
                            dgvcbc.Value = vdp
                            Return
                        End If
                    ElseIf vdp.Value.ToString() = aValue Then
                        dgvcbc.Value = vdp.Value
                        Return
                    End If
                Next
            End If
        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Sub
    Public Class ValueDescriptionPair
        Implements IComparable

        Private m_Value
        Private m_Description As String
        Private m_SortOrder As String
        Private m_ToolTip As String

        Public Sub New()

        End Sub
        Public Sub New(ByVal NewValue As Object, ByVal NewDescription As String, Optional ByVal sortOrder As String = "", Optional ByVal toolTip As String = "")
            m_Value = NewValue
            m_Description = NewDescription
            m_SortOrder = sortOrder
            m_ToolTip = toolTip
        End Sub
        ' Compare to another CustomerInfo for sorting.
        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            If TypeOf obj Is ValueDescriptionPair Then
                Dim vdp As ValueDescriptionPair = DirectCast(obj, ValueDescriptionPair)
                Return Me.m_Description.CompareTo(vdp.Description)
            End If
            Return 0
        End Function

        Public Overrides Function ToString() As [String]
            Return m_Description
        End Function
        Public ReadOnly Property Description() As String
            Get
                Return m_Description
            End Get
        End Property
        Public ReadOnly Property Value() As Object
            Get
                Return m_Value
            End Get
        End Property
        Public ReadOnly Property Value2() As Object
            Get
                Return m_Value
            End Get
        End Property
        Public ReadOnly Property Tooltip() As String
            Get
                Return m_ToolTip
            End Get
        End Property
    End Class
#End Region
End Module
