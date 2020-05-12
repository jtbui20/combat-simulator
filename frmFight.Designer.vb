<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFight
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
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.prbPlayer1 = New System.Windows.Forms.ProgressBar()
        Me.prbPlayer2 = New System.Windows.Forms.ProgressBar()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblPlayer1HP = New System.Windows.Forms.Label()
        Me.lblPlayer2HP = New System.Windows.Forms.Label()
        Me.btnControls = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picPlayer1Passive = New System.Windows.Forms.PictureBox()
        Me.picPlayer1Active1 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1Active2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1Ult = New System.Windows.Forms.PictureBox()
        Me.picPlayer2Passive = New System.Windows.Forms.PictureBox()
        Me.picPlayer2Active1 = New System.Windows.Forms.PictureBox()
        Me.picPlayer2Active2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer2Ult = New System.Windows.Forms.PictureBox()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.btnFightExit = New System.Windows.Forms.Button()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.lblTurnNumber = New System.Windows.Forms.Label()
        Me.lblHeading1 = New System.Windows.Forms.Label()
        Me.lblPlayer1Role = New System.Windows.Forms.Label()
        Me.lblPlayer2Role = New System.Windows.Forms.Label()
        Me.totPlayer1Passive = New System.Windows.Forms.ToolTip(Me.components)
        Me.totPlayer1Active1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.totPlayer1Active2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.totPlayer1Ult = New System.Windows.Forms.ToolTip(Me.components)
        Me.totPlayer2Passive = New System.Windows.Forms.ToolTip(Me.components)
        Me.totPlayer2Active1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.totPlayer2Active2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.totPlayer2Ult = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblPlayerTurn = New System.Windows.Forms.Label()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1Passive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1Active1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1Active2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1Ult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2Passive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2Active1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2Active2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2Ult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer1
        '
        Me.picPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer1.Image = Global.Combat_Simulator.My.Resources.Resources.spr_Knight1
        Me.picPlayer1.Location = New System.Drawing.Point(75, 85)
        Me.picPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(145, 145)
        Me.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer1.TabIndex = 0
        Me.picPlayer1.TabStop = False
        '
        'prbPlayer1
        '
        Me.prbPlayer1.Location = New System.Drawing.Point(75, 260)
        Me.prbPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.prbPlayer1.Maximum = 1000
        Me.prbPlayer1.Name = "prbPlayer1"
        Me.prbPlayer1.Size = New System.Drawing.Size(145, 23)
        Me.prbPlayer1.TabIndex = 2
        '
        'prbPlayer2
        '
        Me.prbPlayer2.Location = New System.Drawing.Point(391, 260)
        Me.prbPlayer2.Margin = New System.Windows.Forms.Padding(2)
        Me.prbPlayer2.Maximum = 1000
        Me.prbPlayer2.Name = "prbPlayer2"
        Me.prbPlayer2.Size = New System.Drawing.Size(145, 23)
        Me.prbPlayer2.TabIndex = 3
        '
        'lblPlayer1
        '
        Me.lblPlayer1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.Location = New System.Drawing.Point(75, 57)
        Me.lblPlayer1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(145, 26)
        Me.lblPlayer1.TabIndex = 4
        Me.lblPlayer1.Text = "Player 1"
        Me.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer2
        '
        Me.lblPlayer2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.Location = New System.Drawing.Point(391, 57)
        Me.lblPlayer2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(145, 26)
        Me.lblPlayer2.TabIndex = 5
        Me.lblPlayer2.Text = "Player 2"
        Me.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer1HP
        '
        Me.lblPlayer1HP.BackColor = System.Drawing.Color.LightGray
        Me.lblPlayer1HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayer1HP.Location = New System.Drawing.Point(75, 232)
        Me.lblPlayer1HP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer1HP.Name = "lblPlayer1HP"
        Me.lblPlayer1HP.Size = New System.Drawing.Size(145, 23)
        Me.lblPlayer1HP.TabIndex = 6
        Me.lblPlayer1HP.Text = "1400"
        Me.lblPlayer1HP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer2HP
        '
        Me.lblPlayer2HP.BackColor = System.Drawing.Color.LightGray
        Me.lblPlayer2HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayer2HP.Location = New System.Drawing.Point(391, 232)
        Me.lblPlayer2HP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer2HP.Name = "lblPlayer2HP"
        Me.lblPlayer2HP.Size = New System.Drawing.Size(145, 23)
        Me.lblPlayer2HP.TabIndex = 7
        Me.lblPlayer2HP.Text = "1400"
        Me.lblPlayer2HP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnControls
        '
        Me.btnControls.Location = New System.Drawing.Point(268, 85)
        Me.btnControls.Margin = New System.Windows.Forms.Padding(2)
        Me.btnControls.Name = "btnControls"
        Me.btnControls.Size = New System.Drawing.Size(67, 40)
        Me.btnControls.TabIndex = 8
        Me.btnControls.Text = "Menu"
        Me.btnControls.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(158, 15)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(293, 42)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Combat Simulator"
        '
        'picPlayer1Passive
        '
        Me.picPlayer1Passive.BackColor = System.Drawing.Color.Red
        Me.picPlayer1Passive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer1Passive.Location = New System.Drawing.Point(75, 330)
        Me.picPlayer1Passive.Margin = New System.Windows.Forms.Padding(2)
        Me.picPlayer1Passive.Name = "picPlayer1Passive"
        Me.picPlayer1Passive.Size = New System.Drawing.Size(34, 33)
        Me.picPlayer1Passive.TabIndex = 10
        Me.picPlayer1Passive.TabStop = False
        '
        'picPlayer1Active1
        '
        Me.picPlayer1Active1.BackColor = System.Drawing.Color.DarkGray
        Me.picPlayer1Active1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer1Active1.Location = New System.Drawing.Point(112, 330)
        Me.picPlayer1Active1.Margin = New System.Windows.Forms.Padding(2)
        Me.picPlayer1Active1.Name = "picPlayer1Active1"
        Me.picPlayer1Active1.Size = New System.Drawing.Size(34, 33)
        Me.picPlayer1Active1.TabIndex = 11
        Me.picPlayer1Active1.TabStop = False
        '
        'picPlayer1Active2
        '
        Me.picPlayer1Active2.BackColor = System.Drawing.Color.DarkGray
        Me.picPlayer1Active2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer1Active2.Location = New System.Drawing.Point(150, 330)
        Me.picPlayer1Active2.Margin = New System.Windows.Forms.Padding(2)
        Me.picPlayer1Active2.Name = "picPlayer1Active2"
        Me.picPlayer1Active2.Size = New System.Drawing.Size(34, 33)
        Me.picPlayer1Active2.TabIndex = 12
        Me.picPlayer1Active2.TabStop = False
        '
        'picPlayer1Ult
        '
        Me.picPlayer1Ult.BackColor = System.Drawing.Color.DarkGray
        Me.picPlayer1Ult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer1Ult.Location = New System.Drawing.Point(187, 330)
        Me.picPlayer1Ult.Margin = New System.Windows.Forms.Padding(2)
        Me.picPlayer1Ult.Name = "picPlayer1Ult"
        Me.picPlayer1Ult.Size = New System.Drawing.Size(34, 33)
        Me.picPlayer1Ult.TabIndex = 13
        Me.picPlayer1Ult.TabStop = False
        '
        'picPlayer2Passive
        '
        Me.picPlayer2Passive.BackColor = System.Drawing.Color.Red
        Me.picPlayer2Passive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer2Passive.Location = New System.Drawing.Point(391, 330)
        Me.picPlayer2Passive.Margin = New System.Windows.Forms.Padding(2)
        Me.picPlayer2Passive.Name = "picPlayer2Passive"
        Me.picPlayer2Passive.Size = New System.Drawing.Size(34, 33)
        Me.picPlayer2Passive.TabIndex = 14
        Me.picPlayer2Passive.TabStop = False
        '
        'picPlayer2Active1
        '
        Me.picPlayer2Active1.BackColor = System.Drawing.Color.DarkGray
        Me.picPlayer2Active1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer2Active1.Location = New System.Drawing.Point(428, 330)
        Me.picPlayer2Active1.Margin = New System.Windows.Forms.Padding(2)
        Me.picPlayer2Active1.Name = "picPlayer2Active1"
        Me.picPlayer2Active1.Size = New System.Drawing.Size(34, 33)
        Me.picPlayer2Active1.TabIndex = 15
        Me.picPlayer2Active1.TabStop = False
        '
        'picPlayer2Active2
        '
        Me.picPlayer2Active2.BackColor = System.Drawing.Color.DarkGray
        Me.picPlayer2Active2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer2Active2.Location = New System.Drawing.Point(465, 330)
        Me.picPlayer2Active2.Margin = New System.Windows.Forms.Padding(2)
        Me.picPlayer2Active2.Name = "picPlayer2Active2"
        Me.picPlayer2Active2.Size = New System.Drawing.Size(34, 33)
        Me.picPlayer2Active2.TabIndex = 16
        Me.picPlayer2Active2.TabStop = False
        '
        'picPlayer2Ult
        '
        Me.picPlayer2Ult.BackColor = System.Drawing.Color.DarkGray
        Me.picPlayer2Ult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer2Ult.Location = New System.Drawing.Point(502, 330)
        Me.picPlayer2Ult.Margin = New System.Windows.Forms.Padding(2)
        Me.picPlayer2Ult.Name = "picPlayer2Ult"
        Me.picPlayer2Ult.Size = New System.Drawing.Size(34, 33)
        Me.picPlayer2Ult.TabIndex = 17
        Me.picPlayer2Ult.TabStop = False
        '
        'picPlayer2
        '
        Me.picPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer2.Image = Global.Combat_Simulator.My.Resources.Resources.spr_Knight1
        Me.picPlayer2.Location = New System.Drawing.Point(391, 85)
        Me.picPlayer2.Margin = New System.Windows.Forms.Padding(2)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(145, 145)
        Me.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer2.TabIndex = 18
        Me.picPlayer2.TabStop = False
        '
        'btnFightExit
        '
        Me.btnFightExit.Location = New System.Drawing.Point(268, 354)
        Me.btnFightExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFightExit.Name = "btnFightExit"
        Me.btnFightExit.Size = New System.Drawing.Size(67, 40)
        Me.btnFightExit.TabIndex = 19
        Me.btnFightExit.Text = "Quit Game"
        Me.btnFightExit.UseVisualStyleBackColor = True
        '
        'btnAttack
        '
        Me.btnAttack.Location = New System.Drawing.Point(268, 214)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(67, 40)
        Me.btnAttack.TabIndex = 20
        Me.btnAttack.Text = "Basic Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        '
        'lblTurnNumber
        '
        Me.lblTurnNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurnNumber.Location = New System.Drawing.Point(268, 152)
        Me.lblTurnNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTurnNumber.Name = "lblTurnNumber"
        Me.lblTurnNumber.Size = New System.Drawing.Size(67, 15)
        Me.lblTurnNumber.TabIndex = 21
        Me.lblTurnNumber.Text = "999"
        Me.lblTurnNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeading1
        '
        Me.lblHeading1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading1.Location = New System.Drawing.Point(268, 137)
        Me.lblHeading1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeading1.Name = "lblHeading1"
        Me.lblHeading1.Size = New System.Drawing.Size(67, 15)
        Me.lblHeading1.TabIndex = 22
        Me.lblHeading1.Text = "Turn"
        Me.lblHeading1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer1Role
        '
        Me.lblPlayer1Role.AutoSize = True
        Me.lblPlayer1Role.Location = New System.Drawing.Point(72, 70)
        Me.lblPlayer1Role.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer1Role.Name = "lblPlayer1Role"
        Me.lblPlayer1Role.Size = New System.Drawing.Size(37, 13)
        Me.lblPlayer1Role.TabIndex = 23
        Me.lblPlayer1Role.Text = "Knight"
        '
        'lblPlayer2Role
        '
        Me.lblPlayer2Role.AutoSize = True
        Me.lblPlayer2Role.Location = New System.Drawing.Point(500, 70)
        Me.lblPlayer2Role.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer2Role.Name = "lblPlayer2Role"
        Me.lblPlayer2Role.Size = New System.Drawing.Size(37, 13)
        Me.lblPlayer2Role.TabIndex = 24
        Me.lblPlayer2Role.Text = "Knight"
        '
        'totPlayer1Passive
        '
        Me.totPlayer1Passive.AutoPopDelay = 500
        Me.totPlayer1Passive.InitialDelay = 500
        Me.totPlayer1Passive.ReshowDelay = 100
        '
        'totPlayer1Active1
        '
        Me.totPlayer1Active1.AutoPopDelay = 500
        Me.totPlayer1Active1.InitialDelay = 500
        Me.totPlayer1Active1.ReshowDelay = 100
        '
        'totPlayer1Active2
        '
        Me.totPlayer1Active2.AutoPopDelay = 500
        Me.totPlayer1Active2.InitialDelay = 500
        Me.totPlayer1Active2.ReshowDelay = 100
        '
        'totPlayer1Ult
        '
        Me.totPlayer1Ult.AutoPopDelay = 500
        Me.totPlayer1Ult.InitialDelay = 500
        Me.totPlayer1Ult.ReshowDelay = 100
        '
        'totPlayer2Passive
        '
        Me.totPlayer2Passive.AutoPopDelay = 500
        Me.totPlayer2Passive.InitialDelay = 500
        Me.totPlayer2Passive.ReshowDelay = 100
        '
        'totPlayer2Active1
        '
        Me.totPlayer2Active1.AutoPopDelay = 500
        Me.totPlayer2Active1.InitialDelay = 500
        Me.totPlayer2Active1.ReshowDelay = 100
        '
        'totPlayer2Active2
        '
        Me.totPlayer2Active2.AutoPopDelay = 500
        Me.totPlayer2Active2.InitialDelay = 500
        Me.totPlayer2Active2.ReshowDelay = 100
        '
        'totPlayer2Ult
        '
        Me.totPlayer2Ult.AutoPopDelay = 500
        Me.totPlayer2Ult.InitialDelay = 500
        Me.totPlayer2Ult.ReshowDelay = 100
        '
        'lblPlayerTurn
        '
        Me.lblPlayerTurn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerTurn.Location = New System.Drawing.Point(254, 196)
        Me.lblPlayerTurn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayerTurn.Name = "lblPlayerTurn"
        Me.lblPlayerTurn.Size = New System.Drawing.Size(96, 15)
        Me.lblPlayerTurn.TabIndex = 25
        Me.lblPlayerTurn.Text = "Player 2's Turn"
        Me.lblPlayerTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 419)
        Me.Controls.Add(Me.lblPlayerTurn)
        Me.Controls.Add(Me.lblPlayer2Role)
        Me.Controls.Add(Me.lblPlayer1Role)
        Me.Controls.Add(Me.lblHeading1)
        Me.Controls.Add(Me.lblTurnNumber)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.btnFightExit)
        Me.Controls.Add(Me.picPlayer2)
        Me.Controls.Add(Me.picPlayer2Ult)
        Me.Controls.Add(Me.picPlayer2Active2)
        Me.Controls.Add(Me.picPlayer2Active1)
        Me.Controls.Add(Me.picPlayer2Passive)
        Me.Controls.Add(Me.picPlayer1Ult)
        Me.Controls.Add(Me.picPlayer1Active2)
        Me.Controls.Add(Me.picPlayer1Active1)
        Me.Controls.Add(Me.picPlayer1Passive)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnControls)
        Me.Controls.Add(Me.lblPlayer2HP)
        Me.Controls.Add(Me.lblPlayer1HP)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.prbPlayer2)
        Me.Controls.Add(Me.prbPlayer1)
        Me.Controls.Add(Me.picPlayer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmFight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combat Simulator"
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1Passive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1Active1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1Active2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1Ult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2Passive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2Active1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2Active2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2Ult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer1 As PictureBox
    Friend WithEvents prbPlayer1 As ProgressBar
    Friend WithEvents prbPlayer2 As ProgressBar
    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents lblPlayer2 As Label
    Friend WithEvents lblPlayer1HP As Label
    Friend WithEvents lblPlayer2HP As Label
    Friend WithEvents btnControls As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents picPlayer1Passive As PictureBox
    Friend WithEvents picPlayer1Active1 As PictureBox
    Friend WithEvents picPlayer1Active2 As PictureBox
    Friend WithEvents picPlayer1Ult As PictureBox
    Friend WithEvents picPlayer2Passive As PictureBox
    Friend WithEvents picPlayer2Active1 As PictureBox
    Friend WithEvents picPlayer2Active2 As PictureBox
    Friend WithEvents picPlayer2Ult As PictureBox
    Friend WithEvents picPlayer2 As PictureBox
    Friend WithEvents btnFightExit As Button
    Friend WithEvents btnAttack As Button
    Friend WithEvents lblTurnNumber As Label
    Friend WithEvents lblHeading1 As Label
    Friend WithEvents lblPlayer1Role As Label
    Friend WithEvents lblPlayer2Role As Label
    Friend WithEvents totPlayer1Passive As ToolTip
    Friend WithEvents totPlayer1Active1 As ToolTip
    Friend WithEvents totPlayer1Active2 As ToolTip
    Friend WithEvents totPlayer1Ult As ToolTip
    Friend WithEvents totPlayer2Passive As ToolTip
    Friend WithEvents totPlayer2Active1 As ToolTip
    Friend WithEvents totPlayer2Active2 As ToolTip
    Friend WithEvents totPlayer2Ult As ToolTip
    Friend WithEvents lblPlayerTurn As Label
End Class
