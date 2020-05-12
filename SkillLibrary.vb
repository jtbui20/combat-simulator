'*********************************
'To make a new skill:
'new Skill(name, roletype, description, damage, passive, cooldown, duration)
'*********************************
''' <summary>
''' The library where all the skills are stored, ready for use. To use this object, just create a new SkillLibrary().
''' </summary>
Public Class SkillLibrary
    'Archer Skills
    'Passive: triple shot 15% chance activate, 45% DMG
    'Active 1: deal 200 And increased all other cool downs by 1
    'Active 2: regenerate 400 In 4 turns
    'Ultimate: Set hidden trap On 1 skill, If skill activated Then deal 400
    Public Triple_Shot_Passive As Skill = New Skill(
        "Triple Shot",
        "Ranger",
        "Passive Skill - Triple Shot" & Environment.NewLine & "Has a 15% chance for the basic attack to deal three shots, each of 50% of the basic attack",
        True,
)
    Public Quick_Shot_Active As Skill = New Skill(
        "Quick Shot",
        "Ranger",
        "Active Skill 1 - Quick Shot " & Environment.NewLine & "Deal 200 and increased all cool downs of your skills by 1 turn, excluding this skill.",
        False,
        4
        )
    Public Calm_Recovery_Active As Skill = New Skill(
        "Calm Recovery",
        "Ranger",
        "Active Skill 2 - Calm Recovery" & Environment.NewLine & "Regenerate 300 In 3 turns",
        False,
        6,
        4
        )
    Public Stealth_Trap_Ult As Skill = New Skill(
        "Stealth Trap",
        "Ranger",
        "Ultimate Skill - Stealth Trap" & Environment.NewLine & " The next time a skill is activated, deal 400 damage to that player.",
        False,
        6,
        4
        )

    'Knight Skills
    'Passive: 15% DMG reduction
    'Active 1: deal 400 And opponent can Not chosen skill On Next turn
    'Active 2: gain 100 armour which reduces DMG by 50%
    'Ultimate: Life steal And increased DMG
    Public Heavy_Armour_Passive As Skill = New Skill(
        "Heavy Armour",
        "Knight",
        "Passive Skill - Heavy Armour" & Environment.NewLine & "Gain 15% damage reduction to all attacks and skills",
        True
)
    Public Smite_Active As Skill = New Skill(
        "Smite",
        "Knight",
        "Active Skill 1 - Smite" & Environment.NewLine & "Deal 100 and the enemy can not attack next turn. ",
        False,
        4
        )
    Public Armour_Up_Active As Skill = New Skill(
        "Armour Up",
        "Knight",
        "Active Skill 2 - Armour Up" & Environment.NewLine & "Gain 200 Health",
        False,
        4
        )
    Public Venegance_Ult As Skill = New Skill(
        "Venegance",
        "Knight",
        "Ultimate Skill - Venegance" & Environment.NewLine & "Gain lifesteal and 50% increased damage for 3 turns.",
        False,
        6,
        3
        )

    'Wizard Skills
    'Passive: 15%DMG increase
    'Active 1: increase cool down On 1 enemy
    'Active 2: heal 30% of missing health
    'Ultimate: Deal 200% Damage
    Public Insight_Passive As Skill = New Skill(
       "Insight",
       "Wizard",
       "Passive - Insight" & Environment.NewLine & "Gain 15% damage dealt to enemies.",
       True,
)
    Public Sealed_Chains_Active As Skill = New Skill(
       "Sealed Chains",
       "Wizard",
       "Active Skill 1 - Sealed Chains" & Environment.NewLine & "The enemy can not use skills next turn.",
       False,
       4
       )
    Public Rejuvenate_Active As Skill = New Skill(
        "Rejuvenate",
        "Wizard",
        "Active Skill 2 - Rejuvenate" & Environment.NewLine & "Recover 30% of missing health.",
       False,
       3
       )
    Public Dark_Aura_Ult As Skill = New Skill(
        "Dark Aura",
        "Wizard",
        "Ultimate Skill - Dark Aura" & Environment.NewLine & "Gain 200% damage on normal attacks for 1 turn.",
        False,
        6
        )

    'Thief Skills
    'Passive: 30%evade
    'Active 1: poison DMG For 3 turn
    'Active 2: restore X HP
    'Ultimate: triple attack For 3 turns
    Public Swift_Passive As Skill = New Skill(
        "Swift",
        "Thief",
        "Passive Skill - Swift" & Environment.NewLine & "Gain 30% change to evade damage.",
        True,
)
    Public Poison_Dagger_Active As Skill = New Skill(
        "Poison Dagger",
        "Thief",
        "Active Skill 1 - Poison Dagger" & Environment.NewLine & "Deal 5% of enemy's remaining HP after attack for 3 turns.",
        False,
        6,
        3
        )
    Public Greater_Healing_Potion_Active As Skill = New Skill(
        "Greater Healing Potion",
        "Thief",
        "Active Skill 2 - Greater Healing Potion" & Environment.NewLine & "Heal for 200",
        False,
        4
        )
    Public Extreme_Speed_Ult As Skill = New Skill(
        "Extreme Speed",
        "Thief",
        "Ultimate Skill - Extreme Speed" & Environment.NewLine & "Gain triple attack for 3 turns",
        False,
        8,
        3
        )
End Class
