<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControls
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblHeading1 = New System.Windows.Forms.Label()
        Me.cmbPlayer1Role = New System.Windows.Forms.ComboBox()
        Me.lblHeading2 = New System.Windows.Forms.Label()
        Me.cmbPlayer2Role = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(202, 387)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblHeading1
        '
        Me.lblHeading1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading1.Location = New System.Drawing.Point(8, 6)
        Me.lblHeading1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeading1.Name = "lblHeading1"
        Me.lblHeading1.Size = New System.Drawing.Size(138, 28)
        Me.lblHeading1.TabIndex = 1
        Me.lblHeading1.Text = "Player Role"
        '
        'cmbPlayer1Role
        '
        Me.cmbPlayer1Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayer1Role.FormattingEnabled = True
        Me.cmbPlayer1Role.Items.AddRange(New Object() {"Knight", "Archer", "Wizard", "Thief"})
        Me.cmbPlayer1Role.Location = New System.Drawing.Point(192, 6)
        Me.cmbPlayer1Role.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbPlayer1Role.Name = "cmbPlayer1Role"
        Me.cmbPlayer1Role.Size = New System.Drawing.Size(82, 21)
        Me.cmbPlayer1Role.TabIndex = 2
        '
        'lblHeading2
        '
        Me.lblHeading2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading2.Location = New System.Drawing.Point(8, 190)
        Me.lblHeading2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeading2.Name = "lblHeading2"
        Me.lblHeading2.Size = New System.Drawing.Size(145, 26)
        Me.lblHeading2.TabIndex = 3
        Me.lblHeading2.Text = "Enemy Role"
        '
        'cmbPlayer2Role
        '
        Me.cmbPlayer2Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayer2Role.FormattingEnabled = True
        Me.cmbPlayer2Role.Items.AddRange(New Object() {"Knight", "Archer", "Wizard", "Thief"})
        Me.cmbPlayer2Role.Location = New System.Drawing.Point(192, 190)
        Me.cmbPlayer2Role.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbPlayer2Role.Name = "cmbPlayer2Role"
        Me.cmbPlayer2Role.Size = New System.Drawing.Size(82, 21)
        Me.cmbPlayer2Role.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(110, 387)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save Settings"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 419)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbPlayer2Role)
        Me.Controls.Add(Me.lblHeading2)
        Me.Controls.Add(Me.cmbPlayer1Role)
        Me.Controls.Add(Me.lblHeading1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmControls"
        Me.Text = "frmControls"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents lblHeading1 As Label
    Friend WithEvents cmbPlayer1Role As ComboBox
    Friend WithEvents lblHeading2 As Label
    Friend WithEvents cmbPlayer2Role As ComboBox
    Friend WithEvents btnSave As Button
End Class
