Imports Combat_Simulator.frmFight

Public Class frmControls
    Dim isSaved As Boolean = False
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If isSaved = False Then
            If MessageBox.Show("Settings will not be saved. Are you sure you want to close this menu?", "Save settings?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Me.Hide()
            End If
        ElseIf isSaved = True Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim save1 As Player = New Player(1, cmbPlayer1Role.SelectedItem)
        Dim save2 As Player = New Player(2, cmbPlayer2Role.SelectedItem)

        save1.HP = 1400
        save2.HP = 1400
        save1.isTurn = True
        save2.isTurn = False

        Player1 = save1
        Player2 = save2

        noDeath = True

        If Player1.Skills(0).Name IsNot "Triple Shot" And Player1.Skills(0).Name IsNot "Swift" Then
            Player1.Skills(0).use()
        End If
        If Player2.Skills(0).Name IsNot "Triple Shot" And Player2.Skills(0).Name IsNot "Swift" Then
            Player2.Skills(0).use()
        End If



        frmFight.lblTurnNumber.Text = 1
        Console.WriteLine(Player1.isTurn)
        Console.WriteLine(Player2.isTurn)

        MessageBox.Show("Your settings have been saved.")

        frmFight.btnAttack.Enabled = True

        Player1.isTurn = True
        Player2.isTurn = False
        frmFight.picPlayer2Active1.BackColor = Color.DarkGray
        frmFight.picPlayer2Active2.BackColor = Color.DarkGray
        frmFight.picPlayer2Ult.BackColor = Color.DarkGray

        frmFight.picPlayer1Active1.BackColor = Color.DarkGray
        frmFight.picPlayer1Active2.BackColor = Color.DarkGray
        frmFight.picPlayer1Ult.BackColor = Color.DarkGray

        isSaved = True
    End Sub

    Private Sub frmControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPlayer1Role.Text = "Knight"
        cmbPlayer2Role.Text = "Knight"
    End Sub
End Class