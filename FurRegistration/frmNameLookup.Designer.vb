<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNameLookup
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
        Me.lbxLookup = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtLookup = New System.Windows.Forms.TextBox()
        Me.btnLookup = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbxLookup
        '
        Me.lbxLookup.FormattingEnabled = True
        Me.lbxLookup.Location = New System.Drawing.Point(3, 3)
        Me.lbxLookup.Name = "lbxLookup"
        Me.lbxLookup.Size = New System.Drawing.Size(133, 56)
        Me.lbxLookup.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbxLookup, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLookup, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLookup, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSelect, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(279, 219)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'txtLookup
        '
        Me.txtLookup.Location = New System.Drawing.Point(3, 74)
        Me.txtLookup.Name = "txtLookup"
        Me.txtLookup.Size = New System.Drawing.Size(100, 20)
        Me.txtLookup.TabIndex = 1
        '
        'btnLookup
        '
        Me.btnLookup.Location = New System.Drawing.Point(142, 145)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(75, 23)
        Me.btnLookup.TabIndex = 2
        Me.btnLookup.Text = "Search"
        Me.btnLookup.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(142, 74)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(3, 145)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 45)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select Record"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'frmNameLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmNameLookup"
        Me.Text = "frmNameLookup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbxLookup As System.Windows.Forms.ListBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtLookup As System.Windows.Forms.TextBox
    Friend WithEvents btnLookup As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
End Class
