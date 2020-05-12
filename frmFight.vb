Public Class frmFight
    Public firstLoad As Boolean = True
    Public Shared Player1 As Player
    Public Shared Player2 As Player

    Public Shared PicPlayer1Passive_isClicked As Boolean = False
    Public Shared PicPlayer1Active1_isClicked As Boolean = False
    Public Shared PicPlayer1Active2_isClicked As Boolean = False
    Public Shared PicPlayer1Ult_isClicked As Boolean = False

    Public Shared PicPlayer2Passive_isClicked As Boolean = False
    Public Shared PicPlayer2Active1_isClicked As Boolean = False
    Public Shared PicPlayer2Active2_isClicked As Boolean = False
    Public Shared PicPlayer2Ult_isClicked As Boolean = False
    Public Shared noDeath As Boolean = True

    Private Sub frmFight_Load(sender As Object, e As EventArgs) Handles MyBase.Load     'First load stuff, to initialise variables and counter infinite loop exception

        If firstLoad = True Then
            Player1 = New Player(1, "Knight")
            Player2 = New Player(2, "Knight")
            firstLoad = False
            Player1.isTurn = True
            Player2.isTurn = False
        End If
        Player1.Skills(0).use()
        Player2.Skills(0).use()

        lblTurnNumber.Text = 1
        lblPlayerTurn.Text = "Player 1's turn"

        Player1.isTurn = True
        Player2.isTurn = False

        picPlayer2Active1.BackColor = Color.DarkGray
        picPlayer2Active2.BackColor = Color.DarkGray
        picPlayer2Ult.BackColor = Color.DarkGray

        picPlayer1Active1.BackColor = Color.DarkGray
        picPlayer1Active2.BackColor = Color.DarkGray
        picPlayer1Ult.BackColor = Color.DarkGray

    End Sub

    Private Sub frmFight_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub btnControls_Click(sender As Object, e As EventArgs) Handles btnControls.Click
        frmControls.Show()
    End Sub

    Private Sub btnFightExit_Click(sender As Object, e As EventArgs) Handles btnFightExit.Click
        End
    End Sub

    'Stuff
    '
    '
    Private Sub picPlayer1Active1_Click(sender As Object, e As EventArgs) Handles picPlayer1Active1.Click
        If Player1.Skills(1).Enabled = False Then
            If Player1.Skills(1).Enabled = False Then
                If Player1.isTurn = False Then
                    MessageBox.Show("You can not use that skill! It is not your turn!")
                Else
                    MessageBox.Show("You can not use that skill! It has been disabled!")
                End If
            Else
                Player1.Skills(1).Use()
            End If
        Else
            Player1.Skills(1).Use()
        End If
    End Sub

    Private Sub picPlayer1Active2_Click(sender As Object, e As EventArgs) Handles picPlayer1Active2.Click
        If Player1.Skills(2).Enabled = False Then
            If Player1.Skills(2).Enabled = False Then
                If Player1.isTurn = False Then
                    MessageBox.Show("You can not use that skill! It is not your turn!")
                Else
                    MessageBox.Show("You can not use that skill! It has been disabled!")
                End If
            Else
                Player1.Skills(2).Use()
            End If
        Else
            Player1.Skills(2).Use()
        End If
    End Sub

    Private Sub picPlayer1Ult_Click(sender As Object, e As EventArgs) Handles picPlayer1Ult.Click
        If Player1.Skills(3).Enabled = False Then
            If Player1.Skills(3).Enabled = False Then
                If Player1.isTurn = False Then
                    MessageBox.Show("You can not use that skill! It is not your turn!")
                Else
                    MessageBox.Show("You can not use that skill! It has been disabled!")
                End If
            Else
                Player1.Skills(2).Use()
            End If
        Else
            Player1.Skills(3).Use()
        End If

    End Sub

    Private Sub picPlayer2Active1_Click(sender As Object, e As EventArgs) Handles picPlayer2Active1.Click
        If Player2.Skills(1).Enabled = False Then
            If Player2.isTurn = False Then
                MessageBox.Show("You can not use that skill! It is not your turn!")
            Else
                MessageBox.Show("You can not use that skill! It has been disabled!")
            End If
        Else
            If Player2.isTurn = True Then
                    Player2.Skills(1).use()
                End If
            End If
    End Sub

    Private Sub picPlayer2Active2_Click(sender As Object, e As EventArgs) Handles picPlayer2Active2.Click
        If Player2.Skills(2).Enabled = False Then
            If Player1.Skills(1).Name = "Smite" Then
                If Player1.Skills(1).Running = True Then
                    PicPlayer2Active2_isClicked = True
                    Player1.Skills(1).Use()
                Else
                    MessageBox.Show("You can not use that skill! It has been disabled!")
                End If
            ElseIf Player2.isTurn = False Then
                MessageBox.Show("You can not use that skill! It is not your turn!")
            Else
                MessageBox.Show("You can not use that skill! It has been disabled!")
            End If
        Else
            If Player2.isTurn = True Then
                Player2.Skills(2).use()
            End If
        End If
    End Sub

    Private Sub picPlayer2Ult_Click(sender As Object, e As EventArgs) Handles picPlayer2Ult.Click
        If Player2.Skills(3).Enabled = False Then
            If Player1.Skills(1).Name = "Smite" Then
                If Player1.Skills(1).Running = True Then
                    PicPlayer2Ult_isClicked = True
                    Player1.Skills(1).Use()
                Else
                    MessageBox.Show("You can not use that skill! It has been disabled!")
                End If
            ElseIf Player2.isTurn = False Then
                MessageBox.Show("You can not use that skill! It is not your turn!")
            Else
                MessageBox.Show("You can not use that skill! It has been disabled!")
            End If
        Else
            PicPlayer2Ult_isClicked = True
            If Player2.Skills(3).Enabled = True Then
                If Player2.isTurn = True Then
                    Player2.Skills(3).use()
                End If
            End If
        End If
    End Sub
    '********************************
    'Gameplay mechanics begin here
    '********************************
    Private Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click
        If Player1.isTurn = True Then
            If Player1.Skills(0).Name = "Triple Shot" Then
                Player1.Skills(0).use()
            Else
                BasicAttack()
            End If

        ElseIf Player2.isTurn = True Then
            If Player2.Skills(0).Name = "Triple Shot" Then
                Player2.Skills(0).use()
            Else
                BasicAttack()
            End If

        End If
        isDead()
        passTurn()
    End Sub

    Public Sub BasicAttack()
        Try
            If Player1.isTurn = True Then
                If Player2.Skills(0).Name = "Swift" Then
                    Player2.Skills(0).use()
                End If
                If Player2.Dodge = 0 Then
                    Player2.HP -= formulateDamage()
                    lblPlayer2HP.Text = Player2.HP
                    prbPlayer2.Value = Player2.HP

                    If Player1.Lifesteal = True Then
                        Player1.Skills(3).use()
                    End If
                    Console.WriteLine("Player 1 dealt " + formulateDamage().ToString + " to Player 2!")
                    If Player1.Skills(1).Name = "Poison Dagger" Then
                        Player1.Skills(1).use()
                    End If
                Else
                    Console.WriteLine("Player 2 dodged the attack!")
                    For i = 1 To 3
                        Player1.Skills(i).dropDuration(1)
                    Next
                End If
            ElseIf Player2.isTurn = True Then
                If Player1.Skills(0).Name = "Swift" Then
                    Player1.Skills(0).use()
                End If
                If Player1.Dodge = 0 Then
                    Player1.HP -= formulateDamage()
                    lblPlayer1HP.Text = Player1.HP
                    prbPlayer1.Value = Player1.HP

                    If Player2.Lifesteal = True Then
                        Player2.Skills(3).use()
                    End If
                    Console.WriteLine("Player 2 dealt " + formulateDamage().ToString + " to Player 1!")
                    If Player2.Skills(1).Name = "Poison Dagger" Then
                        Player2.Skills(1).use()
                    End If
                Else
                    Console.WriteLine("Player 1 dodged the attack!")
                    For i = 1 To 3
                        Player2.Skills(i).dropDuration(1)
                    Next
                End If
            End If
        Catch ex As ArgumentOutOfRangeException
            If Player1.HP <= 0 Then
                Player1.HP = 0
                prbPlayer1.Value = Player1.HP
                lblPlayer1HP.Text = Player1.HP
                isDead()
            ElseIf Player2.HP <= 0 Then
                Player2.HP = 0
                prbPlayer2.Value = Player2.HP
                lblPlayer2HP.Text = Player2.HP
                isDead()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub isDead()                                                                'Checks if a player is dead
        If noDeath = True Then
            If Player1.HP <= 0 And Player2.HP <= 0 Then
                MessageBox.Show("Unlikely Draw!")
                noDeath = False
                btnAttack.Enabled = False
            ElseIf Player1.HP <= 0 Then
                MessageBox.Show("Player 2 Wins")
                noDeath = False
                btnAttack.Enabled = False
            ElseIf Player2.HP <= 0 Then
                MessageBox.Show("Player 1 Wins")
                noDeath = False
                btnAttack.Enabled = False
            End If

        End If
    End Sub

    Public Sub passTurn()
        If noDeath = True Then
            toggleAbility()
            resetClick()
            If Player1.isTurn = True Then
                Player1.isTurn = False
                Player2.isTurn = True
                lblPlayerTurn.Text = "Player 2's turn"
                For i As Integer = 1 To 3
                    Player1.Skills(i).addCooldown(-1)
                    If Player1.Skills(i).Cooldown = 0 Then
                        Player1.Skills(i).Enabled = True
                    Else
                        Player1.Skills(i).Enabled = False
                    End If
                Next
                'Start of turn effects
                If Player2.Skills(2).Name = "Calm Recovery" Then
                    If Player2.Skills(2).Running = True Then
                        Player2.Skills(2).use()
                    End If
                End If
            ElseIf Player2.isTurn = True Then

                Player1.isTurn = True
                Player2.isTurn = False
                lblPlayerTurn.Text = "Player 1's turn"
                For i As Integer = 1 To 3
                    Player2.Skills(i).addCooldown(-1)
                    If Player2.Skills(i).Cooldown = 0 Then
                        Player2.Skills(i).Enabled = True
                    Else
                        Player2.Skills(i).Enabled = False
                    End If
                Next
                'Start of turn effects
                If Player1.Skills(2).Name = "Calm Recovery" Then
                    If Player1.Skills(2).Running = True Then
                        Player1.Skills(2).use()
                    End If
                End If

            End If
            If Player1.isTurn = True Then
                lblTurnNumber.Text += 1
            End If
        End If
    End Sub

    Public Shared Function formulateDamage() As Integer
        If Player1.isTurn = True Then
            Return ((Player1.Damage + (Player1.Damage * 0.01 * Player1.DamageBoost)) - (Player1.Damage * 0.01 * Player2.Defence))
        ElseIf Player2.isTurn = True Then
            Return ((Player2.Damage + (Player2.Damage * 0.01 * Player2.DamageBoost)) - (Player2.Damage * 0.01 * Player1.Defence))
        Else
            Return (0)
        End If
    End Function

    Private Sub toggleAbility()
        If Player1.isTurn = True Then
            If Player2.Skills(1).Enabled = True Then
                picPlayer2Active1.BackColor = Color.Yellow
            Else
                picPlayer2Active1.BackColor = Color.DarkGray
            End If
            If Player2.Skills(2).Enabled = True Then
                picPlayer2Active2.BackColor = Color.Green
            Else
                picPlayer2Active2.BackColor = Color.DarkGray
            End If
            If Player2.Skills(3).Enabled = True Then
                picPlayer2Ult.BackColor = Color.Blue
            Else
                picPlayer2Ult.BackColor = Color.DarkGray
            End If
            picPlayer1Active1.BackColor = Color.DarkGray
            picPlayer1Active2.BackColor = Color.DarkGray
            picPlayer1Ult.BackColor = Color.DarkGray
        ElseIf Player2.isTurn = True Then
            If Player1.Skills(1).Enabled = True Then
                picPlayer1Active1.BackColor = Color.Yellow
            Else
                picPlayer1Active1.BackColor = Color.DarkGray
            End If
            If Player1.Skills(2).Enabled = True Then
                picPlayer1Active2.BackColor = Color.Green
            Else
                picPlayer1Active2.BackColor = Color.DarkGray
            End If
            If Player1.Skills(3).Enabled = True Then
                picPlayer1Ult.BackColor = Color.Blue
            Else
                picPlayer1Ult.BackColor = Color.DarkGray
            End If
            picPlayer2Active1.BackColor = Color.DarkGray
            picPlayer2Active2.BackColor = Color.DarkGray
            picPlayer2Ult.BackColor = Color.DarkGray
        End If
    End Sub

    Private Sub resetClick()
        PicPlayer1Active1_isClicked = False
        PicPlayer1Active2_isClicked = False
        PicPlayer1Ult_isClicked = False
        PicPlayer2Active1_isClicked = False
        PicPlayer2Active2_isClicked = False
        PicPlayer2Ult_isClicked = False
    End Sub

    Public Async Function findClick() As Task(Of Integer)
        If Player1.isTurn = True Then
            If PicPlayer2Active1_isClicked = True Then
                Return 21
            ElseIf PicPlayer2Active2_isClicked = True Then
                Return 22
            ElseIf PicPlayer2Ult_isClicked = True Then
                Return 23
            End If
        ElseIf Player2.isTurn = True Then
            If PicPlayer1Active1_isClicked = True Then
                Return 11
            ElseIf PicPlayer1Active2_isClicked = True Then
                Return 12
            ElseIf PicPlayer1Ult_isClicked = True Then
                Return 13
            End If
        End If
    End Function
End Class
