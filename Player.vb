''' <summary>
''' The player Class. To create a player, put the player number in and the role
''' </summary>
Public Class Player
    'Key information
    Public Skills As Skill()
    Dim SkillLibrary As SkillLibrary = New SkillLibrary()
    Public Role As String

    'Combat based information
    Public HP As Integer = 1400
    Public Damage As Integer = 100
    Public DamageBoost As Integer = 0
    Public Defence As Integer = 0
    Public Dodge As Integer = 0

    'Other buff information
    Public Lifesteal As Boolean = False
    'Turn Based information
    Public isTurn As Boolean = False

    Public Sub New(ByVal PlayerNumber As Integer, ByRef Role As String)
        Me.Role = Role
        'Initializing the player and its objects associated with the player in frmFight
        If PlayerNumber = 1 Then
            frmFight.lblPlayer1HP.Text = HP
            frmFight.prbPlayer1.Maximum = HP
            frmFight.prbPlayer1.Value = HP
            frmFight.lblPlayer1Role.Text = Me.Role
            If Me.Role = "Archer" Then
                Skills = New Skill() {SkillLibrary.Triple_Shot_Passive, SkillLibrary.Quick_Shot_Active, SkillLibrary.Calm_Recovery_Active, SkillLibrary.Stealth_Trap_Ult}
                frmFight.picPlayer1.Image = My.Resources.spr_Archer1
            ElseIf Me.Role = "Knight" Then
                Skills = New Skill() {SkillLibrary.Heavy_Armour_Passive, SkillLibrary.Smite_Active, SkillLibrary.Armour_Up_Active, SkillLibrary.Venegance_Ult}
                frmFight.picPlayer1.Image = My.Resources.spr_Knight1
            ElseIf Me.Role = "Wizard" Then
                Skills = New Skill() {SkillLibrary.Insight_Passive, SkillLibrary.Sealed_Chains_Active, SkillLibrary.Rejuvenate_Active, SkillLibrary.Dark_Aura_Ult}
                frmFight.picPlayer1.Image = My.Resources.spr_Mage1
            ElseIf Me.Role = "Thief" Then
                Skills = New Skill() {SkillLibrary.Swift_Passive, SkillLibrary.Poison_Dagger_Active, SkillLibrary.Greater_Healing_Potion_Active, SkillLibrary.Extreme_Speed_Ult}
                frmFight.picPlayer1.Image = My.Resources.spr_Thief1
            End If
            Console.WriteLine("Player 1 has entered as " + Me.Role)
            frmFight.totPlayer1Passive.SetToolTip(frmFight.picPlayer1Passive, Skills(0).Description)
            frmFight.totPlayer1Active1.SetToolTip(frmFight.picPlayer1Active1, Skills(1).Description)
            frmFight.totPlayer1Active2.SetToolTip(frmFight.picPlayer1Active2, Skills(2).Description)
            frmFight.totPlayer1Ult.SetToolTip(frmFight.picPlayer1Ult, Skills(3).Description)
        ElseIf PlayerNumber = 2 Then
            frmFight.lblPlayer2HP.Text = HP
            frmFight.prbPlayer2.Maximum = HP
            frmFight.prbPlayer2.Value = HP
            frmFight.lblPlayer2Role.Text = Me.Role
            If Me.Role = "Archer" Then
                Skills = New Skill() {SkillLibrary.Triple_Shot_Passive, SkillLibrary.Quick_Shot_Active, SkillLibrary.Calm_Recovery_Active, SkillLibrary.Stealth_Trap_Ult}
                frmFight.picPlayer2.Image = My.Resources.spr_Archer1
            ElseIf Me.Role = "Knight" Then
                Skills = New Skill() {SkillLibrary.Heavy_Armour_Passive, SkillLibrary.Smite_Active, SkillLibrary.Armour_Up_Active, SkillLibrary.Venegance_Ult}
                frmFight.picPlayer2.Image = My.Resources.spr_Knight1
            ElseIf Me.Role = "Wizard" Then
                Skills = New Skill() {SkillLibrary.Insight_Passive, SkillLibrary.Sealed_Chains_Active, SkillLibrary.Rejuvenate_Active, SkillLibrary.Dark_Aura_Ult}
                frmFight.picPlayer2.Image = My.Resources.spr_Mage1
            ElseIf Me.Role = "Thief" Then
                Skills = New Skill() {SkillLibrary.Swift_Passive, SkillLibrary.Poison_Dagger_Active, SkillLibrary.Greater_Healing_Potion_Active, SkillLibrary.Extreme_Speed_Ult}
                frmFight.picPlayer2.Image = My.Resources.spr_Thief1
            End If
            frmFight.totPlayer2Passive.SetToolTip(frmFight.picPlayer2Passive, Skills(0).Description)
            frmFight.totPlayer2Active1.SetToolTip(frmFight.picPlayer2Active1, Skills(1).Description)
            frmFight.totPlayer2Active2.SetToolTip(frmFight.picPlayer2Active2, Skills(2).Description)
            frmFight.totPlayer2Ult.SetToolTip(frmFight.picPlayer2Ult, Skills(3).Description)
            Console.WriteLine("Player 2 has entered as " + Me.Role)
        End If
    End Sub
End Class
