Public Class FurRegistrationButton
  Inherits ESRI.ArcGIS.Desktop.AddIns.Button

  Public Sub New()

  End Sub

  Protected Overrides Sub OnClick()
    '
    '  TODO: Sample code showing how to access button host
        Form_EditAttributes()

    My.ArcMap.Application.CurrentTool = Nothing
  End Sub

  Protected Overrides Sub OnUpdate()
    Enabled = My.ArcMap.Application IsNot Nothing
  End Sub
End Class
