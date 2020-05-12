Public Class frmStart
    Public Shared Player_Info
    Private Sub btnStartExit_Click(sender As Object, e As EventArgs) Handles btnStartExit.Click
        End
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmFight.Show()
        Me.Hide()

    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class