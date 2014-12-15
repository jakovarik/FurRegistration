Imports ESRI.ArcGIS.Geodatabase
Imports ESRI.ArcGIS.Geometry

Public Class frmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnNewTrapper_Click(sender As Object, e As EventArgs) Handles btnNewTrapper.Click
        'resetting form, clearing saved inputs

        'cboMNDNRNumber.Text = String.Empty 'get the list of MNDNR ID's. Loop through list, get highest value, add 1.

        cboMNDNRNumber.Text = String.Empty
        cboStation.Text = String.Empty
        cboSpecies.Text = String.Empty
        cboSex.Text = String.Empty
        txtTagNumber.Text = ""
        cboTakeMethod.Text = String.Empty
        cboHuntType.Text = String.Empty
        cboTrapType.Text = String.Empty

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""

        txtTownship.Text = ""
        txtRange.Text = ""
        txtRangeDirection.Text = ""
        txtCountyNumber.Text = ""
        txtCountyName.Text = ""

    End Sub

    Private Sub cboMNDNRNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMNDNRNumber.SelectedIndexChanged
        'get the value of the combo box (array of values)
        'populate the other text boxes based on this value
        Dim MyArrayList As ArrayList = CType(cboMNDNRNumber.SelectedItem, ValueDescriptionPair).Value
        txtLastName.Text = MyArrayList(0)
        txtFirstName.Text = MyArrayList(1)
        txtAddress.Text = MyArrayList(2)
        txtCity.Text = MyArrayList(3)
        txtState.Text = MyArrayList(4)
        txtZip.Text = MyArrayList(5)

        txtMNDNRNumber.Text = cboMNDNRNumber.Text

    End Sub

    Private Sub cboMNDNRNumber_Leave(sender As Object, e As EventArgs) Handles cboMNDNRNumber.Leave
        'when we leave cbo, put text that is in cbo into txtMNDNRNumber
        txtMNDNRNumber.Text = cboMNDNRNumber.Text

    End Sub

    Public Sub GenerateTownshipCentroid()
        'x1)	Get Township Feature Class
        'x2)	Perform Attribute Query on Township FC for TWP/RNG/DIR
        'x3)	Get Polygon of Matching Township (does township have county info?  If not you’ll need to query for the county later).
        'x4)	Get Envelope of Polygon
        '5)	While Loop
        'a.	Generate random number between min/max X
        'b.	Generate random number between min/max Y
        'c.	Create point of XYs and perform spatial overlay test on TWP polygon
        'i.	If point is inside polygon then exit While Loop
        '6)	Spatial Query County Layer if necessary
        'a.	Get County Feature Class
        'b.	Perform Spatial Query with X/Y you generated
        'c.	Get County name and place in textbox on your form.
        '7)	Place X/Y coordinates in Textboxes on your form.  When you submit your form you can use the X/Y coordinates to create a shape for your Feature.
        '8)	Zoom the map to the X/Y coordinates?

        'check to make sure that T, S, R textboxes have valid values
        'if any don't, exit out of routine
        'message box or turn text box red

        'Get Township Feature Class
        Dim pFeatureClass As IFeatureClass
        pFeatureClass = FeatureClass_GetFromPath(m_PLSPath, m_PLSName)
        If pFeatureClass Is Nothing Then
            Exit Sub
        End If

        'Perform Attribute Query on Township FC for TWP/RNG/DIR
        Dim pQueryFilter As IQueryFilter
        pQueryFilter = New QueryFilter
        pQueryFilter.WhereClause = "TOWN = " & txtTownship.Text & " AND RANG = " & txtRange.Text & " AND RDIR = " & txtRangeDirection.Text



        'performs search on table using pQueryFilter
        Dim pFeatureCursor As IFeatureCursor
        pFeatureCursor = pFeatureClass.Search(pQueryFilter, True)

        'gets first record that matches the search
        Dim pFeature As IFeature
        pFeature = pFeatureCursor.NextFeature()

        'if pFeature is not valid then exit
        If pFeature Is Nothing Then
            Exit Sub
        End If

        Dim CountyNumber As Short
        'get county number from feature
        CountyNumber = pFeature.Value(pFeature.Fields.FindField("COUN"))

        'query the county feature class

        'get the geometry of the pFeature
        Dim pGeometry As IGeometry
        pGeometry = pFeature.ShapeCopy()

        'get the pFeature envelope (x,y)
        Dim pEnvelope As IEnvelope
        pEnvelope = pGeometry.Envelope()

        'dim x,y variables
        Dim xmin, xmax, ymin, ymax As Double
        xmin = pEnvelope.XMin
        xmax = pEnvelope.XMax
        ymin = pEnvelope.YMin
        ymax = pEnvelope.YMax

        Dim pPoint As IPoint = New Point
        Dim pRelationalOperator2 As IRelationalOperator2
        pRelationalOperator2 = pGeometry
        Dim random As New Random()
        Dim y As Integer
        Dim x As Integer


        While xmin <> 0
            'generate random x
            x = random.Next(CInt(xmin), CInt(xmax)) ' random.Next(min, max) the range is min to max -1
            y = random.Next(CInt(ymin), CInt(ymax))
            pPoint.X = x
            pPoint.Y = y
            If pRelationalOperator2.Contains(pPoint) = True Then
                Exit While
            End If

        End While

        m_xCoord = pPoint.X
        m_yCoord = pPoint.Y

        'attribute query on county layer (see TSR code)
        'Get County Feature Class
        Dim pFeatureClass2 As IFeatureClass
        pFeatureClass2 = FeatureClass_GetFromPath(m_CountyPath, m_CountyName)
        If pFeatureClass2 Is Nothing Then
            Exit Sub
        End If

        'Perform Attribute Query on Township FC for COUNTY NUMBER
        Dim pQueryFilter2 As IQueryFilter2
        pQueryFilter2 = New QueryFilter
        pQueryFilter2.WhereClause = "COUN = " & CountyNumber
        'place county number in textbox on form
        txtCountyNumber.Text = CountyNumber.ToString

        pFeatureCursor = pFeatureClass2.Search(pQueryFilter2, True)

        'gets first record that matches the search
        pFeature = pFeatureCursor.NextFeature()

        'if pFeature is not valid then exit
        If pFeature Is Nothing Then
            Exit Sub
        End If

        Dim CountyName As String
        'get county number from feature
        CountyName = pFeature.Value(pFeature.Fields.FindField("CTY_NAME"))
        txtCountyName.Text = CountyName

        'Place X/Y coordinates in Textboxes on your form.  When you submit your form you can use the X/Y coordinates to create a shape for your Feature.
        txtXCoord.Text = x.ToString
        txtYCoord.Text = y.ToString

        'zoom to the township
        My.ArcMap.Document.ActiveView.Extent = pEnvelope
        My.ArcMap.Document.ActiveView.Refresh()

    End Sub

    Private Sub txtRangeDirection_Leave(sender As Object, e As EventArgs) Handles txtRangeDirection.Leave
        GenerateTownshipCentroid()
    End Sub

   

    Private Sub cbxJuevenile_CheckedChanged(sender As Object, e As EventArgs)
        'put code here to genereate new number with 9999 prefix
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtAddress.Clear()
        txtState.Clear()


    End Sub

    Private Sub btnBackupDatabase_Click(sender As Object, e As EventArgs) Handles btnBackupDatabase.Click
        'put code here to call the Backup Database code
        Database_Backup()

    End Sub



    Private Sub btnJuvenille_Click(sender As Object, e As EventArgs) Handles btnJuvenille.Click
        Generate_Juvenile()

    End Sub


    Private Sub txtMNDNRNumber_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtTagNumber_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        m_frmNameLookup = New frmNameLookup
        If m_frmNameLookup.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'populate form with selected record from frmNameLookup window.

        End If

    End Sub
End Class