Imports Combat_Simulator.frmFight
''' <summary>
''' The skill object. Contains information about the skill. Has a use() to use the skill.
''' For cooldown based effects that target the skill, use addCooldown(value as integer).
''' </summary>
Public Class Skill
    Public Name As String                  'The name of the skill         
    Public RoleType As String                 'The Role which owns the Skill
    Public Passive As Boolean                 'Whether the skill is a passive or active                                           
    Public Description As String           'The description of the skill. This will be shown upon hover of the skill image
    Public Cooldown As Integer             'The cooldown timer on the skill.
    Public Duration As Integer             'The duration of how long the skill goes for
    Dim Random As Random = New Random()
    Public Enabled As Boolean = False
    'Conditional stuff for skills
    Public isTrap As Boolean = False
    Public Running As Boolean = False
    Public isUsed As Boolean = False

    ''' <summary>
    ''' Create a new skill using this function. Add the Name, the RoleType and the skill's description in. Additional information can be added.
    ''' </summary>
    Public Sub New(ByVal Name As String, ByVal RoleType As String, ByVal Description As String, ByVal Passive As Boolean,
                  Optional ByVal Cooldown As Integer = 0, Optional ByVal Duration As Integer = 0
                  )

        Me.Name = Name
        Me.RoleType = RoleType
        Me.Description = Description
        Me.Passive = Passive
        Me.Cooldown = Cooldown
        Me.Duration = Duration

    End Sub

    Public Async Sub Use()
        If Name = "Triple Shot" Then
            If Random.Next(1, 100) <= 15 Then
                If Player1.isTurn = True Then
                    Console.WriteLine("Player 1's Triple Shot has activated!")
                    Player1.DamageBoost = -50
                    frmFight.BasicAttack()
                    frmFight.BasicAttack()
                    frmFight.BasicAttack()
                    Player1.DamageBoost = 0
                ElseIf Player2.isTurn = True Then
                    Console.WriteLine("Player 2's Triple Shot has activated!")
                    Player2.DamageBoost = -50
                    frmFight.BasicAttack()
                    frmFight.BasicAttack()
                    frmFight.BasicAttack()
                    Player2.DamageBoost = 0
                End If
            Else
                If Player1.isTurn = True Then
                    frmFight.BasicAttack()
                ElseIf Player2.isTurn = True Then
                    frmFight.BasicAttack()
                End If

                'Attack 3 times with 50% damage
            End If
        ElseIf Name = "Quick Shot" Then
            If Player1.isTurn = True Then
                Player1.DamageBoost = 100
                frmFight.BasicAttack()
                Player1.DamageBoost = 0
                For i = 1 To 3
                    Player1.Skills(i).addCooldown(-1)
                Next
            ElseIf Player2.isTurn = True Then
                Player2.DamageBoost = 100
                frmFight.BasicAttack()
                Player2.DamageBoost = 0
                For i = 1 To 3
                    Player2.Skills(i).addCooldown(-1)
                Next
            End If
            Cooldown += 4
            isUsed = True
            frmFight.passTurn()
            'Deal 200 damage and increase the cooldowns of all other skills by 1
        ElseIf Name = "Calm Recovery" Then
            If Player1.isTurn = True Then
                If Running = True Then
                    Console.WriteLine("Player 1's Calm Recovery has been activated!")
                    Console.WriteLine("Player 1 gained 100 HP!")
                    Player1.HP += 100
                    frmFight.lblPlayer1HP.Text = Player1.HP
                    frmFight.prbPlayer1.Value = Player1.HP

                    Duration -= 1
                    If Duration = 0 Then
                        Running = False
                    End If
                Else
                    If PicPlayer1Active2_isClicked = True Then
                        Running = True
                        Enabled = False
                        Cooldown = 6
                        Duration = 3
                        frmFight.passTurn()
                    End If
                End If
            ElseIf Player2.isTurn = True Then
                If Running = True Then
                    Console.WriteLine("Player 2's Calm Recovery has been activated!")
                    Console.WriteLine("Player 2 gained 100 HP!")
                    Player2.HP += 100
                    frmFight.lblPlayer2HP.Text = Player2.HP
                    frmFight.prbPlayer2.Value = Player2.HP

                    Duration -= 1
                    If Duration = 0 Then
                        Running = False
                    End If
                Else
                    If PicPlayer2Active2_isClicked = True Then
                        Running = True
                        Enabled = False
                        Cooldown = 6
                        Duration = 3
                        frmFight.passTurn()
                    End If
                End If
            End If
            isUsed = True
            'Every turn recover 100, for 3 turns
        ElseIf Name = "Stealth Trap" Then
            If Player1.isTurn = True Then

            ElseIf Player2.isTurn = True Then

            End If
            'Choose a trap, then put trigger on skill.
            'If activated, deal 400 to the player
        ElseIf Name = "Heavy Armour" Then
            If Player1.Role = "Knight" Then
                Player1.Defence = 15
            End If
            If Player2.Role = "Knight" Then
                Player2.Defence = 15
            End If
            'Damage is reduced by 15%
        ElseIf Name = "Smite" Then
            If Player1.isTurn = True Then

            ElseIf Player2.isTurn = True Then

            End If

                'Deal 100 and choose a skill. That skill is DISABLED for 1 turn
            ElseIf Name = "Armour Up" Then
            If Player1.isTurn = True Then
                If (Player1.HP + 200) > 1400 Then
                    Player1.HP = 1400
                    frmFight.lblPlayer1HP.Text = Player1.HP
                    frmFight.prbPlayer1.Value = Player1.HP
                    Console.WriteLine("Player 1 used Armour Up!")
                    Console.WriteLine("Player 1 has gained 200 HP!")
                Else
                    Player1.HP += 200
                    frmFight.lblPlayer1HP.Text = Player1.HP
                    frmFight.prbPlayer1.Value = Player1.HP
                    Console.WriteLine("Player 1 used Armour Up!")
                    Console.WriteLine("Player 1 has gained 200 HP!")
                End If

            ElseIf Player2.isTurn = True Then
                If (Player2.HP + 200) > 1400 Then
                    Player2.HP = 1400
                    frmFight.lblPlayer2HP.Text = Player2.HP
                    frmFight.prbPlayer2.Value = Player2.HP
                    Console.WriteLine("Player 2 used Armour Up!")
                    Console.WriteLine("Player 2 has gained 200 HP!")
                Else
                    Player2.HP += 200
                    frmFight.lblPlayer2HP.Text = Player2.HP
                    frmFight.prbPlayer2.Value = Player2.HP
                    Console.WriteLine("Player 2 used Armour Up!")
                    Console.WriteLine("Player 2 has gained 200 HP!")
                End If
            End If
            Cooldown += 4
            isUsed = True
            frmFight.passTurn()
            'Add 200 to HP bar
        ElseIf Name = "Venegance" Then
            If Player1.isTurn = True Then
                If Running = True Then
                    Console.WriteLine("Player 1's Venegance has been activated!")
                    Console.WriteLine("Player 1 has gained " + Math.Floor(formulateDamage() * 0.3).ToString() + " HP!")
                    Player1.HP += Math.Floor(formulateDamage() * 0.3)
                    frmFight.lblPlayer1HP.Text = Player1.HP
                    frmFight.prbPlayer1.Value = Player1.HP
                    Duration -= 1
                    If Duration = 0 Then
                        Running = False
                        Player1.Lifesteal = False
                        Player1.DamageBoost -= 100
                    End If
                Else
                    If PicPlayer1Ult_isClicked = True Then
                        Running = True
                        Enabled = False
                        Player1.Lifesteal = True
                        Player1.DamageBoost += 100
                        Cooldown = 6
                        Duration = 3
                        frmFight.passTurn()
                    End If
                End If
            ElseIf Player2.isTurn = True Then
                If Running = True Then
                    Console.WriteLine("Player 2's Venegance has been activated!")
                    Console.WriteLine("Player 2 has gained " + Math.Floor(formulateDamage() * 0.3).ToString() + " HP!")
                    Player2.HP += Math.Floor(formulateDamage() * 0.3)
                    frmFight.lblPlayer2HP.Text = Player2.HP
                    frmFight.prbPlayer2.Value = Player2.HP
                    Duration -= 1
                    If Duration = 0 Then
                        Running = False
                        Player2.Lifesteal = False
                        Player2.DamageBoost -= 100
                    End If
                Else
                    If PicPlayer2Ult_isClicked = True Then
                        Running = True
                        Enabled = False
                        Player2.Lifesteal = True
                        Player2.DamageBoost += 100
                        Cooldown = 6
                        Duration = 3
                        frmFight.passTurn()
                    End If
                End If
            End If
            isUsed = True
            'Apply lifesteal and 100% increased damage to normal attack for 3 turns
        ElseIf Name = "Insight" Then
            If Player1.Role = "Wizard" Then
                Player1.DamageBoost = 15
            End If
            If Player2.Role = "Wizard" Then
                Player2.DamageBoost = 15
            End If
            'Damage dealt is increased by 15%
        ElseIf Name = "Sealed Chains" Then
            If Player1.isTurn = True Then

            ElseIf Player2.isTurn = True Then

            End If
            'Choose a skill. That skill gets cooldowon increased
        ElseIf Name = "Rejuvenate" Then
            If Player1.isTurn = True Then
                If (Player1.HP + (1400 - Player1.HP) * 0.3) >= 1400 Then
                    Player1.HP = 1400
                    frmFight.lblPlayer1HP.Text = Player1.HP
                    frmFight.prbPlayer1.Value = Player1.HP
                    Console.WriteLine("Player 1 used Rejuvenate!!")
                    Console.WriteLine("Player 1 has gained " + (1400 - Player1.HP).ToString + " HP!")
                Else
                    Player1.HP += (1400 - Player1.HP) * 0.3
                    frmFight.lblPlayer1HP.Text = Player1.HP
                    frmFight.prbPlayer1.Value = Player1.HP
                    Console.WriteLine("Player 1 used Rejuvenate!!")
                    Console.WriteLine("Player 1 has gained " + ((1400 - Player1.HP) * 0.3).ToString + " HP!")
                End If
            ElseIf Player2.isTurn = True Then
                If (Player2.HP + (1400 - Player2.HP) * 0.3) >= 1400 Then
                    Player2.HP = 1400
                    frmFight.lblPlayer2HP.Text = Player2.HP
                    frmFight.prbPlayer2.Value = Player2.HP
                    Console.WriteLine("Player 2 used Rejuvenate!!")
                    Console.WriteLine("Player 2 has gained " + (1400 - Player2.HP).ToString + " HP!")
                Else
                    Player2.HP += (1400 - Player2.HP) * 0.3
                    frmFight.lblPlayer2HP.Text = Player2.HP
                    frmFight.prbPlayer2.Value = Player2.HP
                    Console.WriteLine("Player 2 used Rejuvenate!!")
                    Console.WriteLine("Player 2 has gained " + ((1400 - Player2.HP) * 0.3).ToString + " HP!")
                    'Add 30% of missing health to HP
                End If
            End If
            Cooldown += 3
            frmFight.passTurn()
        ElseIf Name = "Dark Aura" Then
            If Player1.isTurn = True Then
                Console.WriteLine("Player 1 used Dark Aura!")
                Player1.DamageBoost += 200
                frmFight.BasicAttack()
                Player1.DamageBoost -= 200
            ElseIf Player2.isTurn = True Then
                Console.WriteLine("Player 2 used Dark Aura!")
                Player2.DamageBoost += 200
                frmFight.BasicAttack()
                Player2.DamageBoost -= 200
            End If
            Cooldown += 6
            isUsed = True
            frmFight.passTurn()
            'Deal 200% damage
        ElseIf Name = "Swift" Then
            If Player1.Skills(0).Name = "Swift" Then
                If Random.Next(1, 100) <= 30 Then
                    Player1.Dodge = 1
                Else
                    Player1.Dodge = 0
                End If
            End If
            If Player2.Skills(0).Name = "Swift" Then
                If Random.Next(1, 100) <= 30 Then
                    Player2.Dodge = 1
                Else
                    Player2.Dodge = 0
                End If
            End If
            '30% chance to dodge attacks
        ElseIf Name = "Poison Dagger" Then
            If Player1.isTurn = True Then
                If Running = True Then
                    Console.WriteLine("Player 1's Poison Dagger has been activated!")
                    Console.WriteLine("Player 1 dealt " + Math.Floor(Player2.HP * 0.05).ToString + " to Player 2!")
                    Player2.HP -= Math.Floor(Player2.HP * 0.05)
                    frmFight.lblPlayer2HP.Text = Player2.HP
                    frmFight.prbPlayer2.Value = Player2.HP

                    Duration -= 1
                    If Duration = 0 Then
                        Running = False
                    End If
                Else
                    If PicPlayer1Active1_isClicked = True Then
                        Running = True
                        Enabled = False
                        Cooldown = 6
                        Duration = 3
                        frmFight.passTurn()
                    End If
                End If
            ElseIf Player2.isTurn = True Then
                If Running = True Then
                    Console.WriteLine("Player 2's Poison Dagger has been activated!")
                    Console.WriteLine("Player 2 dealt " + Math.Floor(Player2.HP * 0.05).ToString + " to Player 1!")
                    Player1.HP -= Math.Floor(Player1.HP * 0.05)
                    frmFight.lblPlayer1HP.Text = Player1.HP
                    frmFight.prbPlayer1.Value = Player1.HP

                    Duration -= 1
                    If Duration = 0 Then
                        Running = False
                    End If
                Else
                    If PicPlayer2Active1_isClicked = True Then
                        Running = True
                        Enabled = False
                        Cooldown = 6
                        Duration = 3
                        frmFight.passTurn()
                    End If
                End If
            End If
            isUsed = True
            'After attack, deal 5% enemy remaining health for 3 turns
        ElseIf Name = "Greater Healing Potion" Then
            If Player1.isTurn = True Then
                If (Player1.HP + 200) > 1400 Then
                    Player1.HP = 1400
                    frmFight.lblPlayer1HP.Text = Player1.HP
                    frmFight.prbPlayer1.Value = Player1.HP
                    Console.WriteLine("Player 1 used Greater Healing Potion!")
                    Console.WriteLine("Player 1 has gained 200 HP!")
                Else
                    Player1.HP += 200
                    frmFight.lblPlayer1HP.Text = Player1.HP
                    frmFight.prbPlayer1.Value = Player1.HP
                    Console.WriteLine("Player 1 used Greater Healing Potion!")
                    Console.WriteLine("Player 1 has gained 200 HP!")
                End If

            ElseIf Player2.isTurn = True Then
                If (Player2.HP + 200) > 1400 Then
                    Player2.HP = 1400
                    frmFight.lblPlayer2.Text = Player2.HP
                    frmFight.prbPlayer2.Value = Player2.HP
                    Console.WriteLine("Player 2 used Greater Healing Potion!")
                    Console.WriteLine("Player 2 has gained 200 HP!")
                Else
                    Player2.HP += 200
                    frmFight.lblPlayer2HP.Text = Player2.HP
                    frmFight.prbPlayer2.Value = Player2.HP
                    Console.WriteLine("Player 2 used Greater Healing Potion!")
                    Console.WriteLine("Player 2 has gained 200 HP!")
                End If
            End If
            Cooldown += 4
            isUsed = True
            frmFight.passTurn()
            'Add 200 to HP
        ElseIf Name = "Extreme Speed" Then
            If Player1.isTurn = True Then

            ElseIf Player2.isTurn = True Then

            End If
            'Attack 3 times per normal attack
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return Name
    End Function

    Public Sub addCooldown(ByVal value As Integer)
        Cooldown += value
        If Cooldown < 0 Then
            Cooldown = 0
        End If
    End Sub

    Public Sub dropDuration(ByVal value As Integer)
        Duration -= value
        If Duration <= 0 Then
            Duration = 0
            Running = False
        End If
    End Sub
End Class
