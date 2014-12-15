Imports ESRI.ArcGIS.Geodatabase

Public Class clsCombobox
    Inherits System.Windows.Forms.ComboBox

    Private m_FieldName As String = ""
    Private m_DefaultValue As Object = Nothing
    Private m_CodedValueDomain As ICodedValueDomain = Nothing
    Private m_IsNullable As Boolean = True
    Private m_AllCodedDomains As New ArrayList()
    Private m_Modified As Boolean = False
    Private m_Query As String = ""

    Public Sub New()

    End Sub

 
    Public Sub LoadFromField(ByVal pField As IField)
        Dim pDomain As IDomain

        Try
            m_IsNullable = pField.IsNullable
            m_FieldName = pField.Name

            'Set Default Value
            m_DefaultValue = pField.DefaultValue

            'Get Domain Table and Load it into the m_AllCodedDomains list
            pDomain = pField.Domain

            If Not pDomain Is Nothing Then
                LoadDomain(pDomain)
            End If

        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Sub
    Private Sub LoadDomain(ByVal pDomain As IDomain)
        Try
            If pDomain.Type <> esriDomainType.esriDTCodedValue Then Exit Sub
            m_CodedValueDomain = pDomain


            Dim col As New Windows.Forms.AutoCompleteStringCollection

            'Load Domain into combobox
            m_AllCodedDomains.Clear()
            If m_IsNullable Then m_AllCodedDomains.Add(New ValueDescriptionPair("", ""))
            For c = 0 To m_CodedValueDomain.CodeCount - 1
                m_AllCodedDomains.Add(New ValueDescriptionPair(m_CodedValueDomain.Value(c), m_CodedValueDomain.Name(c)))
                col.Add(m_CodedValueDomain.Name(c))
            Next
AfterLoop:
            m_AllCodedDomains.Sort()

            'Set List for Combobox
            Me.DisplayMember = "Description"
            Me.ValueMember = "Value"
            Me.DataSource = m_AllCodedDomains

            'call default
            Default_Set()

            'Set Auto Complete Stuff
            Me.AutoCompleteSource = Windows.Forms.AutoCompleteSource.CustomSource
            Me.AutoCompleteCustomSource = col
            Me.AutoCompleteMode = Windows.Forms.AutoCompleteMode.Suggest


        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Sub

    Sub LoadLookupTable()
        Dim pTable As ITable
        Dim pCursor As ICursor = Nothing
        Dim pRow As IRow = Nothing
        Dim pQueryFilter As New QueryFilter()
        Dim valFieldArray() As String = {"lastname", "firstname", "address", "city", "state", "zip"} 'values needed for text boxes in customer info part of form
        Dim valueArray As ArrayList
        Dim descField As String = "CUST_ID" 'what shows in drop-down - combo of fields
        Dim aDesc As String = ""
        Dim col As New Windows.Forms.AutoCompleteStringCollection

        Try
            'Get the Table
            pTable = Table_GetFromPath(m_FeatureClassPath, "custtrapping")
            If pTable Is Nothing Then Exit Sub

            'Query the Table (Returns all records unless you specify a WhereClause)
            pCursor = pTable.Search(pQueryFilter, True)
            pRow = pCursor.NextRow()
            'if pRow = Nothing 
            'then pRow = pTable.InsertFeature/NewFeature
            'code to populate pRow (from form Submit - drop down selections)
            'pRow.Store
            m_AllCodedDomains.Clear()

            'For each Row in the lookup table
            While Not pRow Is Nothing
                aDesc = pRow.Value(pRow.Fields.FindField(descField)).ToString
                If aDesc = "0" Or aDesc = "" Then
                    GoTo endofwhile
                End If
                'Loop through the fields to be included in the valueArray
                valueArray = New ArrayList()
                For Each f In valFieldArray
                    If pRow.Fields.FindField(f) <> -1 Then
                        valueArray.Add(pRow.Value(pRow.Fields.FindField(f)))
                    End If
                Next


                'Add the description/value to the list of domains that will be assigned to the combobox
                m_AllCodedDomains.Add(New ValueDescriptionPair(valueArray, aDesc))
                col.Add(aDesc)
endofwhile:
                pRow = pCursor.NextRow()

            End While
            m_AllCodedDomains.Sort()


            'Set List for Combobox
            Me.DisplayMember = "Description"
            Me.ValueMember = "Value"
            Me.DataSource = m_AllCodedDomains

            'call default
            Default_Set()

            'Set Auto Complete Stuff
            Me.AutoCompleteSource = Windows.Forms.AutoCompleteSource.CustomSource
            Me.AutoCompleteCustomSource = col
            Me.AutoCompleteMode = Windows.Forms.AutoCompleteMode.Suggest

        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Finally
            pTable = Nothing
            Object_Release(pCursor)
            Object_Release(pRow)
            pQueryFilter = Nothing
        End Try
    End Sub

    Public Sub Default_Set()
        Try
            If IsDBNull(m_DefaultValue) Then m_DefaultValue = ""
            If Not m_DefaultValue Is Nothing Then
                ValueDescriptionPair_Select(Me, m_DefaultValue)
            End If
        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Sub

#Region "PROPERTIES"
    Public Property DefaultValue() As String
        Get
            Return m_DefaultValue
        End Get
        Set(ByVal value As String)
            m_DefaultValue = value
        End Set
    End Property

    Public Property npc_FieldName() As String
        Get
            Return m_FieldName
        End Get
        Set(ByVal value As String)
            m_FieldName = value
        End Set
    End Property
#End Region

    Public Sub Set_Value(ByVal aVal As Object, Optional IsText As Boolean = False)
        Try
            If IsDBNull(aVal) Then
                Me.SelectedValue = ""
                Exit Sub
            End If

            If IsText Then
                Me.SelectedText = aVal
            Else
                Me.SelectedValue = aVal
            End If

        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & Me.Name)
        End Try
    End Sub
    Public Function Get_Value() As Object

        If Me.SelectedItem Is Nothing Then Return Nothing
        If Me.SelectedValue.ToString() = "" Then Return DBNull.Value
        'JACKIENOTE!! CHECK FIELD NAME.  iF IT IS USER ID THEN RETURN THE SELECTED TEXT (ME.SELECTEDTEXT) INSTEAD
        If m_FieldName.ToLower = "mndnr_number" Then
            Return Me.SelectedText
        Else
            Return Me.SelectedValue
        End If

    End Function
    Public Function Get_ValueAsString() As String
        If Me.SelectedItem Is Nothing Then Return ""

        Return CType(Me.SelectedItem, ValueDescriptionPair).Value.ToString()
    End Function

#Region "COMBOBOX EVENTS"
    Private Sub clsCombobox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If Not Me.DroppedDown Then Me.DroppedDown = True
    End Sub
    Private Sub clsCombobox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'AutoCompleteCombo_KeyUp(Me, e)
    End Sub
    Private Sub clsCombobox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        AutoCompleteCombo_Leave(Me)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        'Me.SelectionLength = 0
    End Sub
    Private Sub clsCombobox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
       
    End Sub
#End Region
#Region "AUTO COMPLETE STUFF"
    Public Sub AutoCompleteCombo_KeyUp(ByVal cbo As clsCombobox, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim sTypedText As String
        Dim iFoundIndex As Integer
        Dim oFoundItem As Object
        Dim sFoundText As String
        Dim sAppendText As String

        'Allow select keys without Autocompleting
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.Back  'System.Windows.Forms.Keys.Delete
                Return
        End Select

        'Get the Typed Text and Find it in the list
        sTypedText = cbo.Text
        iFoundIndex = cbo.FindString(sTypedText)

        'If we found the Typed Text in the list then Autocomplete
        If iFoundIndex >= 0 Then

            'Get the Item from the list (Return Type depends if Datasource was bound 
            ' or List Created)
            oFoundItem = cbo.Items(iFoundIndex)

            'Use the ListControl.GetItemText to resolve the Name in case the Combo 
            ' was Data bound
            sFoundText = cbo.GetItemText(oFoundItem)

            'Append then found text to the typed text to preserve case
            sAppendText = sFoundText.Substring(sTypedText.Length)
            cbo.Text = sTypedText & sAppendText

            'Select the Appended Text
            cbo.SelectionStart = sTypedText.Length
            cbo.SelectionLength = sAppendText.Length

        End If

    End Sub
    Public Sub AutoCompleteCombo_Leave(ByVal cbo As clsCombobox)
        Dim iFoundIndex As Integer
        Try
            iFoundIndex = cbo.FindStringExact(cbo.Text)
            If iFoundIndex = -1 Then
                iFoundIndex = cbo.FindString(cbo.Text)
            End If

            cbo.SelectedIndex = iFoundIndex

            If cbo.Tag = "" Then
                If cbo.Items.Count > 0 And iFoundIndex = -1 Then cbo.SelectedIndex = 0

            Else
            End If

            Me.SelectionLength = 0
        Catch
        End Try
    End Sub
#End Region
End Class
