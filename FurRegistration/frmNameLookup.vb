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


Public Class frmNameLookup

    Private Sub btnLookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click
        'grab text from txtLookup & use it to query customer table
        Dim pTable As ITable
        Dim pCursor As ICursor = Nothing
        Dim pRow As IRow = Nothing
        Dim pQueryFilter As New QueryFilter()

        Try


            'GET TABLE
            pTable = Table_GetFromPath(m_FeatureClassPath, "custtrapping")
            If pTable Is Nothing Then Exit Sub

            'QUERY TABLE
            pQueryFilter = New QueryFilter
            'QUERY MAX CUST_id RECORD
            pQueryFilter.WhereClause = """CUSTOMER_I"" = (SELECT MAX(""CUSTOMER_I"") FROM custtrapping)"

            pCursor = pTable.Search(pQueryFilter, True)
            pRow = pCursor.NextRow()

            'GET LARGEST CUST_ID
            Dim pRecord As Integer
            pRecord = pRow.Value(pRow.Fields.FindField("CUSTOMER_I"))
            pRecord += 1
            m_frmFurBearer.cboMNDNRNumber.Text = pRecord

        Catch ex As Exception
            Error_Catch(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

        End Try
        'select matching records from cust table and input into lbxLookup
        'allow user to select record from table and click btnSelect to populate form fields

    End Sub
End Class