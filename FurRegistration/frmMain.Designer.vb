<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnBackupDatabase = New System.Windows.Forms.Button()
        Me.lblTotalRecords = New System.Windows.Forms.Label()
        Me.txtXCoord = New System.Windows.Forms.TextBox()
        Me.txtYCoord = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboMNDNRNumber = New FurRegistration.clsCombobox()
        Me.btnNewTrapper = New System.Windows.Forms.Button()
        Me.btnJuvenille = New System.Windows.Forms.Button()
        Me.clsDateTimeRegistered = New FurRegistration.clsDateTimePicker(Me.components)
        Me.txtTagNumber = New FurRegistration.clsTextbox(Me.components)
        Me.clsCurrentDateTime = New FurRegistration.clsDateTimePicker(Me.components)
        Me.cboTrapType = New FurRegistration.clsCombobox()
        Me.cboHuntType = New FurRegistration.clsCombobox()
        Me.cboStation = New FurRegistration.clsCombobox()
        Me.cboTakeMethod = New FurRegistration.clsCombobox()
        Me.cboSpecies = New FurRegistration.clsCombobox()
        Me.cboSex = New FurRegistration.clsCombobox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtZip = New FurRegistration.clsTextbox(Me.components)
        Me.txtState = New FurRegistration.clsTextbox(Me.components)
        Me.txtCity = New FurRegistration.clsTextbox(Me.components)
        Me.txtAddress = New FurRegistration.clsTextbox(Me.components)
        Me.txtLastName = New FurRegistration.clsTextbox(Me.components)
        Me.txtFirstName = New FurRegistration.clsTextbox(Me.components)
        Me.txtMNDNRNumber = New FurRegistration.clsTextbox(Me.components)
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCountyName = New FurRegistration.clsTextbox(Me.components)
        Me.txtCountyNumber = New FurRegistration.clsTextbox(Me.components)
        Me.txtRange = New FurRegistration.clsTextbox(Me.components)
        Me.txtTownship = New FurRegistration.clsTextbox(Me.components)
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Station:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Species:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sex:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tag Number:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "MNDNR #:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Take Method:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Hunt Type:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(73, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Trap Type:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Date Taken (mmdd):"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Date Registered (mmdd):"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(11, 136)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 13)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Zip Code:"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(29, 110)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 13)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "State:"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(70, 162)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(125, 28)
        Me.btnSearch.TabIndex = 31
        Me.btnSearch.Text = "Search by Name"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Last Name:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Address:"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(37, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "City:"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "First Name:"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 196)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 13)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "County Name:"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 138)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 13)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "County Number:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Range:"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(30, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Township:"
        '
        'btnEnter
        '
        Me.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnter.Location = New System.Drawing.Point(28, 13)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(170, 56)
        Me.btnEnter.TabIndex = 16
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(28, 97)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(170, 54)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnBackupDatabase
        '
        Me.btnBackupDatabase.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBackupDatabase.ForeColor = System.Drawing.Color.Black
        Me.btnBackupDatabase.Location = New System.Drawing.Point(28, 176)
        Me.btnBackupDatabase.Name = "btnBackupDatabase"
        Me.btnBackupDatabase.Size = New System.Drawing.Size(170, 52)
        Me.btnBackupDatabase.TabIndex = 18
        Me.btnBackupDatabase.Text = "Backup Database"
        Me.btnBackupDatabase.UseVisualStyleBackColor = True
        '
        'lblTotalRecords
        '
        Me.lblTotalRecords.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalRecords.AutoSize = True
        Me.lblTotalRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRecords.ForeColor = System.Drawing.Color.Black
        Me.lblTotalRecords.Location = New System.Drawing.Point(53, 245)
        Me.lblTotalRecords.Name = "lblTotalRecords"
        Me.lblTotalRecords.Size = New System.Drawing.Size(120, 18)
        Me.lblTotalRecords.TabIndex = 23
        Me.lblTotalRecords.Text = "Total Records:"
        Me.lblTotalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtXCoord
        '
        Me.txtXCoord.Location = New System.Drawing.Point(92, 235)
        Me.txtXCoord.Name = "txtXCoord"
        Me.txtXCoord.ReadOnly = True
        Me.txtXCoord.Size = New System.Drawing.Size(100, 20)
        Me.txtXCoord.TabIndex = 31
        Me.txtXCoord.Visible = False
        '
        'txtYCoord
        '
        Me.txtYCoord.Location = New System.Drawing.Point(92, 255)
        Me.txtYCoord.Name = "txtYCoord"
        Me.txtYCoord.ReadOnly = True
        Me.txtYCoord.Size = New System.Drawing.Size(100, 20)
        Me.txtYCoord.TabIndex = 32
        Me.txtYCoord.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 232)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "X Coord:"
        Me.Label16.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 252)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 13)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "Y Coord:"
        Me.Label24.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.cboMNDNRNumber, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnNewTrapper, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.btnJuvenille, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.clsDateTimeRegistered, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTagNumber, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.clsCurrentDateTime, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboTrapType, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cboHuntType, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cboStation, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboTakeMethod, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cboSpecies, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cboSex, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(346, 311)
        Me.TableLayoutPanel1.TabIndex = 34
        '
        'cboMNDNRNumber
        '
        Me.cboMNDNRNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboMNDNRNumber.DefaultValue = Nothing
        Me.cboMNDNRNumber.FormattingEnabled = True
        Me.cboMNDNRNumber.Location = New System.Drawing.Point(138, 8)
        Me.cboMNDNRNumber.Name = "cboMNDNRNumber"
        Me.cboMNDNRNumber.npc_FieldName = "CUSTOMER_I"
        Me.cboMNDNRNumber.Size = New System.Drawing.Size(189, 21)
        Me.cboMNDNRNumber.TabIndex = 1
        Me.cboMNDNRNumber.Tag = "custid"
        '
        'btnNewTrapper
        '
        Me.btnNewTrapper.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNewTrapper.ForeColor = System.Drawing.Color.Black
        Me.btnNewTrapper.Location = New System.Drawing.Point(32, 275)
        Me.btnNewTrapper.Name = "btnNewTrapper"
        Me.btnNewTrapper.Size = New System.Drawing.Size(75, 36)
        Me.btnNewTrapper.TabIndex = 19
        Me.btnNewTrapper.Text = "New Trapper"
        Me.btnNewTrapper.UseVisualStyleBackColor = True
        '
        'btnJuvenille
        '
        Me.btnJuvenille.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnJuvenille.ForeColor = System.Drawing.Color.Black
        Me.btnJuvenille.Location = New System.Drawing.Point(200, 275)
        Me.btnJuvenille.Name = "btnJuvenille"
        Me.btnJuvenille.Size = New System.Drawing.Size(75, 36)
        Me.btnJuvenille.TabIndex = 20
        Me.btnJuvenille.Text = "Juvenille Trapper"
        Me.btnJuvenille.UseVisualStyleBackColor = True
        '
        'clsDateTimeRegistered
        '
        Me.clsDateTimeRegistered.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.clsDateTimeRegistered.DefaultValue = Nothing
        Me.clsDateTimeRegistered.FieldName = "Date_Registered"
        Me.clsDateTimeRegistered.Location = New System.Drawing.Point(138, 249)
        Me.clsDateTimeRegistered.Name = "clsDateTimeRegistered"
        Me.clsDateTimeRegistered.Size = New System.Drawing.Size(200, 20)
        Me.clsDateTimeRegistered.TabIndex = 10
        '
        'txtTagNumber
        '
        Me.txtTagNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTagNumber.Location = New System.Drawing.Point(138, 116)
        Me.txtTagNumber.MaxLength = 10
        Me.txtTagNumber.Name = "txtTagNumber"
        Me.txtTagNumber.npc_DefaultValue = Nothing
        Me.txtTagNumber.npc_FieldName = "Tag_Number"
        Me.txtTagNumber.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeInteger
        Me.txtTagNumber.Size = New System.Drawing.Size(189, 20)
        Me.txtTagNumber.TabIndex = 5
        '
        'clsCurrentDateTime
        '
        Me.clsCurrentDateTime.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.clsCurrentDateTime.DefaultValue = Nothing
        Me.clsCurrentDateTime.FieldName = "Date_Taken"
        Me.clsCurrentDateTime.Location = New System.Drawing.Point(138, 223)
        Me.clsCurrentDateTime.Name = "clsCurrentDateTime"
        Me.clsCurrentDateTime.Size = New System.Drawing.Size(200, 20)
        Me.clsCurrentDateTime.TabIndex = 9
        '
        'cboTrapType
        '
        Me.cboTrapType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboTrapType.DefaultValue = Nothing
        Me.cboTrapType.FormattingEnabled = True
        Me.cboTrapType.Location = New System.Drawing.Point(138, 196)
        Me.cboTrapType.Name = "cboTrapType"
        Me.cboTrapType.npc_FieldName = "Trap_Type"
        Me.cboTrapType.Size = New System.Drawing.Size(189, 21)
        Me.cboTrapType.TabIndex = 8
        '
        'cboHuntType
        '
        Me.cboHuntType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboHuntType.DefaultValue = Nothing
        Me.cboHuntType.FormattingEnabled = True
        Me.cboHuntType.Location = New System.Drawing.Point(138, 169)
        Me.cboHuntType.Name = "cboHuntType"
        Me.cboHuntType.npc_FieldName = "Hunt_Type"
        Me.cboHuntType.Size = New System.Drawing.Size(189, 21)
        Me.cboHuntType.TabIndex = 7
        '
        'cboStation
        '
        Me.cboStation.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboStation.DefaultValue = Nothing
        Me.cboStation.FormattingEnabled = True
        Me.cboStation.Location = New System.Drawing.Point(138, 35)
        Me.cboStation.Name = "cboStation"
        Me.cboStation.npc_FieldName = "Station"
        Me.cboStation.Size = New System.Drawing.Size(189, 21)
        Me.cboStation.TabIndex = 2
        '
        'cboTakeMethod
        '
        Me.cboTakeMethod.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboTakeMethod.DefaultValue = Nothing
        Me.cboTakeMethod.FormattingEnabled = True
        Me.cboTakeMethod.Location = New System.Drawing.Point(138, 142)
        Me.cboTakeMethod.Name = "cboTakeMethod"
        Me.cboTakeMethod.npc_FieldName = "Take_Method"
        Me.cboTakeMethod.Size = New System.Drawing.Size(189, 21)
        Me.cboTakeMethod.TabIndex = 6
        '
        'cboSpecies
        '
        Me.cboSpecies.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboSpecies.DefaultValue = Nothing
        Me.cboSpecies.FormattingEnabled = True
        Me.cboSpecies.Location = New System.Drawing.Point(138, 62)
        Me.cboSpecies.Name = "cboSpecies"
        Me.cboSpecies.npc_FieldName = "Species"
        Me.cboSpecies.Size = New System.Drawing.Size(189, 21)
        Me.cboSpecies.TabIndex = 3
        '
        'cboSex
        '
        Me.cboSex.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboSex.DefaultValue = Nothing
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Location = New System.Drawing.Point(138, 89)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.npc_FieldName = "Sex"
        Me.cboSex.Size = New System.Drawing.Size(189, 21)
        Me.cboSex.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.txtZip, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label23, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtState, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCity, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label22, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAddress, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtLastName, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFirstName, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMNDNRNumber, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSearch, 1, 6)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 363)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(346, 226)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'txtZip
        '
        Me.txtZip.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtZip.Location = New System.Drawing.Point(70, 133)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.npc_DefaultValue = Nothing
        Me.txtZip.npc_FieldName = "Zip"
        Me.txtZip.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger
        Me.txtZip.Size = New System.Drawing.Size(268, 20)
        Me.txtZip.TabIndex = 27
        '
        'txtState
        '
        Me.txtState.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtState.Location = New System.Drawing.Point(70, 107)
        Me.txtState.Name = "txtState"
        Me.txtState.npc_DefaultValue = Nothing
        Me.txtState.npc_FieldName = "State"
        Me.txtState.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger
        Me.txtState.Size = New System.Drawing.Size(268, 20)
        Me.txtState.TabIndex = 26
        '
        'txtCity
        '
        Me.txtCity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCity.Location = New System.Drawing.Point(70, 81)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.npc_DefaultValue = Nothing
        Me.txtCity.npc_FieldName = "City"
        Me.txtCity.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger
        Me.txtCity.Size = New System.Drawing.Size(268, 20)
        Me.txtCity.TabIndex = 25
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAddress.Location = New System.Drawing.Point(70, 55)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.npc_DefaultValue = Nothing
        Me.txtAddress.npc_FieldName = "Address"
        Me.txtAddress.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger
        Me.txtAddress.Size = New System.Drawing.Size(268, 20)
        Me.txtAddress.TabIndex = 24
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtLastName.Location = New System.Drawing.Point(70, 29)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.npc_DefaultValue = Nothing
        Me.txtLastName.npc_FieldName = "LASTNAME"
        Me.txtLastName.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger
        Me.txtLastName.Size = New System.Drawing.Size(268, 20)
        Me.txtLastName.TabIndex = 23
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtFirstName.Location = New System.Drawing.Point(70, 3)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.npc_DefaultValue = Nothing
        Me.txtFirstName.npc_FieldName = "FIRSTNAME"
        Me.txtFirstName.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger
        Me.txtFirstName.Size = New System.Drawing.Size(268, 20)
        Me.txtFirstName.TabIndex = 22
        '
        'txtMNDNRNumber
        '
        Me.txtMNDNRNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMNDNRNumber.Enabled = False
        Me.txtMNDNRNumber.Location = New System.Drawing.Point(70, 201)
        Me.txtMNDNRNumber.Name = "txtMNDNRNumber"
        Me.txtMNDNRNumber.npc_DefaultValue = Nothing
        Me.txtMNDNRNumber.npc_FieldName = "MNDNR_Number"
        Me.txtMNDNRNumber.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger
        Me.txtMNDNRNumber.Size = New System.Drawing.Size(268, 20)
        Me.txtMNDNRNumber.TabIndex = 30
        Me.txtMNDNRNumber.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.txtCountyName, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.txtCountyNumber, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtYCoord, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtXCoord, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txtRange, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtTownship, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label20, 0, 3)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(366, 22)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(323, 272)
        Me.TableLayoutPanel3.TabIndex = 35
        '
        'txtCountyName
        '
        Me.txtCountyName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCountyName.Location = New System.Drawing.Point(92, 193)
        Me.txtCountyName.Name = "txtCountyName"
        Me.txtCountyName.npc_DefaultValue = Nothing
        Me.txtCountyName.npc_FieldName = "County_Name"
        Me.txtCountyName.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger
        Me.txtCountyName.Size = New System.Drawing.Size(231, 20)
        Me.txtCountyName.TabIndex = 15
        '
        'txtCountyNumber
        '
        Me.txtCountyNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCountyNumber.Location = New System.Drawing.Point(92, 135)
        Me.txtCountyNumber.Name = "txtCountyNumber"
        Me.txtCountyNumber.npc_DefaultValue = Nothing
        Me.txtCountyNumber.npc_FieldName = "County_Number"
        Me.txtCountyNumber.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger
        Me.txtCountyNumber.Size = New System.Drawing.Size(268, 20)
        Me.txtCountyNumber.TabIndex = 14
        '
        'txtRange
        '
        Me.txtRange.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRange.Location = New System.Drawing.Point(92, 77)
        Me.txtRange.MaxLength = 2
        Me.txtRange.Name = "txtRange"
        Me.txtRange.npc_DefaultValue = Nothing
        Me.txtRange.npc_FieldName = "Range"
        Me.txtRange.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger
        Me.txtRange.Size = New System.Drawing.Size(231, 20)
        Me.txtRange.TabIndex = 12
        '
        'txtTownship
        '
        Me.txtTownship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTownship.Location = New System.Drawing.Point(92, 19)
        Me.txtTownship.MaxLength = 3
        Me.txtTownship.Name = "txtTownship"
        Me.txtTownship.npc_DefaultValue = Nothing
        Me.txtTownship.npc_FieldName = "Township"
        Me.txtTownship.npc_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger
        Me.txtTownship.Size = New System.Drawing.Size(228, 20)
        Me.txtTownship.TabIndex = 11
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnEnter, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnClose, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.btnBackupDatabase, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.lblTotalRecords, 0, 3)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(415, 341)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(226, 270)
        Me.TableLayoutPanel4.TabIndex = 36
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(704, 635)
        Me.TableLayoutPanel5.TabIndex = 39
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 635)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.MaximumSize = New System.Drawing.Size(720, 673)
        Me.Name = "frmMain"
        Me.Text = "Furbearer Registration Form"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnBackupDatabase As System.Windows.Forms.Button
    Friend WithEvents lblTotalRecords As System.Windows.Forms.Label
    Friend WithEvents txtTagNumber As clsTextbox
    Friend WithEvents clsDateTimeRegistered As clsDateTimePicker
    Friend WithEvents clsCurrentDateTime As clsDateTimePicker
    Friend WithEvents cboTrapType As clsCombobox
    Friend WithEvents cboHuntType As clsCombobox
    Friend WithEvents cboTakeMethod As clsCombobox
    Friend WithEvents cboSex As clsCombobox
    Friend WithEvents cboSpecies As clsCombobox
    Friend WithEvents cboStation As clsCombobox
    Friend WithEvents txtCity As clsTextbox
    Friend WithEvents txtAddress As clsTextbox
    Friend WithEvents txtLastName As clsTextbox
    Friend WithEvents txtFirstName As clsTextbox
    Friend WithEvents txtCountyName As clsTextbox
    Friend WithEvents txtCountyNumber As clsTextbox
    Friend WithEvents txtRange As clsTextbox
    Friend WithEvents txtTownship As clsTextbox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtZip As clsTextbox
    Friend WithEvents txtState As clsTextbox
    Friend WithEvents txtMNDNRNumber As FurRegistration.clsTextbox
    Friend WithEvents txtXCoord As System.Windows.Forms.TextBox
    Friend WithEvents txtYCoord As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnNewTrapper As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnJuvenille As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents cboMNDNRNumber As FurRegistration.clsCombobox
End Class
