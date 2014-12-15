Imports System.Windows.Forms
Imports System.IO

Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Carto
Imports ESRI.ArcGIS.Geodatabase
Imports ESRI.ArcGIS.esriSystem
Imports ESRI.ArcGIS.Editor
Imports ESRI.ArcGIS.DataSourcesGDB
Imports ESRI.ArcGIS.Geometry
Imports ESRI.ArcGIS.Framework



Public Class frmNameLookup

    Private Sub btnLookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click
        'grab text from txtLookup & use it to query customer table
        Dim pTable As ITable
        Dim pCursor As ICursor = Nothing
        Dim pRow As IRow = Nothing
        Dim pQueryFilter As New QueryFilter()
        Dim theArray As New ArrayList()

        Try

            'GET TABLE
            pTable = Table_GetFromPath(m_FeatureClassPath, "custtrapping")
            If pTable Is Nothing Then Exit Sub


            'QUERY TABLE
            pQueryFilter = New QueryFilter
            'QUERY CUST_id RECORD based on user input text
            Dim input As String
            input = CStr(txtLookup.Text.ToUpper)
            Dim query As String
            query = "UPPER(""LASTNAME"") LIKE '%" & input & "%' Or UPPER(""FIRSTNAME"") LIKE '%" & input &
                "%' Or UPPER(""ADDRESS"") LIKE '%" & input & "%' Or UPPER(""CITY"") LIKE '%" & input & "%'"
            Dim queryNumeric As String
            queryNumeric = " Or ""CUSTOMER_I"" =" & input & " Or ""ZIP"" =" & input & ""

            If IsNumeric(input) Then
                query = query & queryNumeric
            
            End If
            

            pQueryFilter.WhereClause = query

            'pcursor = row/cell/value that meets the query statement
            pCursor = pTable.Search(pQueryFilter, True)

            'grabbing the first selected row
            pRow = pCursor.NextRow
            While Not pRow Is Nothing

                'return matches from pcursor variable and display in lbxLookup

                '*********************************************************************
                'allow user to select record from table and click btnSelect to populate form fields
                'create variables for all fields (LNAME, FNAME, etc)
                Dim LName, FName, Address, City, State, Zip
                LName = pRow.Value(pRow.Fields.FindField("LASTNAME"))
                FName = pRow.Value(pRow.Fields.FindField("FIRSTNAME"))
                Address = pRow.Value(pRow.Fields.FindField("ADDRESS"))
                City = pRow.Value(pRow.Fields.FindField("CITY"))
                State = pRow.Value(pRow.Fields.FindField("STATE"))
                Zip = pRow.Value(pRow.Fields.FindField("ZIP"))
                'create description (Desc = LNAME + , +...
                Dim Desc As String
                Desc = LName & " ," & FName & " ," & Address & " ," & City & " ," & State & " ," & Zip
                Dim CustID As String
                CustID = pRow.Value(pRow.Fields.FindField("CUSTOMER_I"))

                'create array where each row contains value desc pair
                theArray.Add(New ValueDescriptionPair(CustID, Desc))
                pRow = pCursor.NextRow

            End While

            theArray.Sort()

            'Set List for listbox
            lbxLookup.DisplayMember = "Description"
            lbxLookup.ValueMember = "Value"
            lbxLookup.DataSource = theArray

        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtLookup.Clear()
        Me.Close()

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        'GRAB SELECTED VALUE
        'm_frmFurBearer.cboMNDNRNumber.Set_Value(lbxLookup.SelectedValue, True)
        ValueDescriptionPair_Select(m_frmFurBearer.cboMNDNRNumber, lbxLookup.SelectedValue.ToString, True)

        '*******************************************************************************************
    End Sub

    Private Sub txtLookup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLookup.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
End Class