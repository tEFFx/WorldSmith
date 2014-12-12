/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.Panels;
using WorldSmith.Dialogs;

namespace WorldSmith.DataClasses
{
	public partial class DotaBaseUnit : BaseScriptType
	{
		[Category("General")]
		[Description("Model.")]
		[DefaultValue("models/error.mdl")]
		public string Model
		{
			get;
			set;
		}

		[Category("General")]
		[Description("Name of sound set.")]
		[DefaultValue("0")]
		public string SoundSet
		{
			get;
			set;
		}

		[Category("General")]
		[Description("Starting level.")]
		[DefaultValue(1)]
		public int Level
		{
			get;
			set;
		}

		[Category("Abilities")]
		[Description("Number of abilities.")]
		[DefaultValue(4)]
		public int AbilityLayout
		{
			get;
			set;
		}

		[Category("Abilities")]
		[Description("Ability 1.")]
		[DefaultValue("")]
		public string Ability1
		{
			get;
			set;
		}

		[Category("Abilities")]
		[Description("Ability 2.")]
		[DefaultValue("")]
		public string Ability2
		{
			get;
			set;
		}

		[Category("Abilities")]
		[Description("Ability 3.")]
		[DefaultValue("")]
		public string Ability3
		{
			get;
			set;
		}

		[Category("Abilities")]
		[Description("Ability 4.")]
		[DefaultValue("")]
		public string Ability4
		{
			get;
			set;
		}

		[Category("Abilities")]
		[Description("Ability 5 - Bonuses.")]
		[DefaultValue("")]
		public string Ability5
		{
			get;
			set;
		}

		[Category("Abilities")]
		[Description("Ability 6 - Extra.")]
		[DefaultValue("")]
		public string Ability6
		{
			get;
			set;
		}

		[Category("Abilities")]
		[Description("Ability 7 - Extra.")]
		[DefaultValue("")]
		public string Ability7
		{
			get;
			set;
		}

		[Category("Abilities")]
		[Description("Ability 8 - Extra.")]
		[DefaultValue("")]
		public string Ability8
		{
			get;
			set;
		}

		[Category("Armor")]
		[Description("Physical protection.")]
		[DefaultValue(-1)]
		public int ArmorPhysical
		{
			get;
			set;
		}

		[Category("Armor")]
		[Description("Magical protection (percentage).")]
		[DefaultValue(25)]
		public int MagicalResistance
		{
			get;
			set;
		}

		public enum AttackCapabilitiesEnum
		{
			DOTA_UNIT_CAP_NO_ATTACK,
			DOTA_UNIT_CAP_RANGED_ATTACK,
			DOTA_UNIT_CAP_MELEE_ATTACK,
		}

		[Category("Attack")]
		[Description("Gives the unit melee of ranged attack capability.")]
		[DefaultValue(AttackCapabilitiesEnum.DOTA_UNIT_CAP_RANGED_ATTACK)]
		public AttackCapabilitiesEnum AttackCapabilities
		{
			get;
			set;
		}

		[Category("Attack")]
		[Description("Damage range min.")]
		[DefaultValue(1)]
		public int AttackDamageMin
		{
			get;
			set;
		}

		[Category("Attack")]
		[Description("Damage range max.")]
		[DefaultValue(1)]
		public int AttackDamageMax
		{
			get;
			set;
		}

		public enum AttackDamageTypeEnum
		{
			DAMAGE_TYPE_ArmorPhysical,
		}

		[Category("Attack")]
		[Description("Type of damage dealt.")]
		[DefaultValue(AttackDamageTypeEnum.DAMAGE_TYPE_ArmorPhysical)]
		public AttackDamageTypeEnum AttackDamageType
		{
			get;
			set;
		}

		[Category("Attack")]
		[Description("Speed of attack.")]
		[DefaultValue(1.7f)]
		public float AttackRate
		{
			get;
			set;
		}

		[Category("Attack")]
		[Description("Normalized time in animation cycle to attack.")]
		[DefaultValue(0.75f)]
		public float AttackAnimationPoint
		{
			get;
			set;
		}

		[Category("Attack")]
		[Description("Range within a target can be acquired.")]
		[DefaultValue(true)]
		public bool AttackAcquisitionRange
		{
			get;
			set;
		}

		[Category("Attack")]
		[Description("Range within a target can be attacked.")]
		[DefaultValue(600)]
		public int AttackRange
		{
			get;
			set;
		}

		[Category("Attack")]
		[Description("Particle system model for projectile.")]
		[DefaultValue("ranged_hero")]
		public string ProjectileModel
		{
			get;
			set;
		}

		[Category("Attack")]
		[Description("Speed of projectile.")]
		[DefaultValue(900)]
		public int ProjectileSpeed
		{
			get;
			set;
		}

		public enum AttributePrimaryEnum
		{
			DOTA_ATTRIBUTE_STRENGTH,
			DOTA_ATTRIBUTE_AGILITY,
			DOTA_ATTRIBUTE_INTELLECT,
		}

		[Category("Attributes")]
		[Description("Sets the primary attribute of the unit.")]
		[DefaultValue(AttributePrimaryEnum.DOTA_ATTRIBUTE_STRENGTH)]
		public AttributePrimaryEnum AttributePrimary
		{
			get;
			set;
		}

		[Category("Attributes")]
		[Description("Base strength")]
		[DefaultValue(0)]
		public int AttributeBaseStrength
		{
			get;
			set;
		}

		[Category("Attributes")]
		[Description("Strength bonus per level.")]
		[DefaultValue(0)]
		public int AttributeStrengthGain
		{
			get;
			set;
		}

		[Category("Attributes")]
		[Description("Base intelligence")]
		[DefaultValue(0)]
		public int AttributeBaseIntelligence
		{
			get;
			set;
		}

		[Category("Attributes")]
		[Description("Intelligence bonus per level.")]
		[DefaultValue(0)]
		public int AttributeIntelligenceGain
		{
			get;
			set;
		}

		[Category("Attributes")]
		[Description("Base agility")]
		[DefaultValue(0)]
		public int AttributeBaseAgility
		{
			get;
			set;
		}

		[Category("Attributes")]
		[Description("Agility bonus per level.")]
		[DefaultValue(0)]
		public int AttributeAgilityGain
		{
			get;
			set;
		}

		[Category("Bounty")]
		[Description("Experience earned when killing this unit")]
		[DefaultValue(62)]
		public int BountyXP
		{
			get;
			set;
		}

		[Category("Bounty")]
		[Description("Minimum gold earned when killing this unit.")]
		[DefaultValue(0)]
		public int BountyGoldMin
		{
			get;
			set;
		}

		[Category("Bounty")]
		[Description("Maximum gold earned when killing this unit.")]
		[DefaultValue(0)]
		public int BountyGoldMax
		{
			get;
			set;
		}

		public enum BoundsHullNameEnum
		{
			DOTA_HULL_SIZE_HERO,
			DOTA_HULL_SIZE_SMALL,
			DOTA_HULL_SIZE_REGULAR,
			DOTA_HULL_SIZE_TOWER,
			DOTA_HULL_SIZE_FILLER,
			DOTA_HULL_SIZE_BARRACKS,
			DOTA_HULL_SIZE_BUILDING,
			DOTA_HULL_SIZE_SIEGE,
			DOTA_HULL_SIZE_HUGE,
		}

		[Category("Bounds")]
		[Description("Type of bounds hull.(?)")]
		[DefaultValue(BoundsHullNameEnum.DOTA_HULL_SIZE_HERO)]
		public BoundsHullNameEnum BoundsHullName
		{
			get;
			set;
		}

		[Category("Bounds")]
		[Description("Radius of ring when selecting unit(?)")]
		[DefaultValue(70)]
		public int RingRadius
		{
			get;
			set;
		}

		public enum MovementCapabilitiesEnum
		{
			DOTA_UNIT_CAP_MOVE_NONE,
			DOTA_UNIT_CAP_MOVE_GROUND,
			DOTA_UNIT_CAP_MOVE_FLY,
		}

		[Category("Movement")]
		[Description("Type of movement capabilities for this unit.")]
		[DefaultValue(MovementCapabilitiesEnum.DOTA_UNIT_CAP_MOVE_GROUND)]
		public MovementCapabilitiesEnum MovementCapabilities
		{
			get;
			set;
		}

		[Category("Movement")]
		[Description("Speed")]
		[DefaultValue(300)]
		public int MovementSpeed
		{
			get;
			set;
		}

		[Category("Movement")]
		[Description("Turn rate.")]
		[DefaultValue(0.5f)]
		public float MovementTurnRate
		{
			get;
			set;
		}

		[Category("Movement")]
		[Description("Plays alternate idle/run animation when near enemies")]
		[DefaultValue(false)]
		public bool HasAggressiveStance
		{
			get;
			set;
		}

		[Category("Status")]
		[Description("Base Health")]
		[DefaultValue(150)]
		public int StatusHealth
		{
			get;
			set;
		}

		[Category("Status")]
		[Description("Health regeneration rate.")]
		[DefaultValue(0.25f)]
		public float StatusHealthRegen
		{
			get;
			set;
		}

		[Category("Status")]
		[Description("Base mana.")]
		[DefaultValue(0)]
		public int StatusMana
		{
			get;
			set;
		}

		[Category("Status")]
		[Description("Mana regeneration rate.")]
		[DefaultValue(0.01f)]
		public float StatusManaRegen
		{
			get;
			set;
		}

		[Category("Status")]
		[Description("Mana regeneration rate.")]
		[DefaultValue(-1)]
		public int StatusStartingMana
		{
			get;
			set;
		}

		public enum TeamNameEnum
		{
			DOTA_TEAM_NEUTRALS,
			DOTA_TEAM_BADGUYS,
			DOTA_TEAM_GOODGUYS,
			DOTA_TEAM_NOTEAM,
		}

		[Category("Team")]
		[Description("Decides what team the unit belongs to.")]
		[DefaultValue(TeamNameEnum.DOTA_TEAM_GOODGUYS)]
		public TeamNameEnum TeamName
		{
			get;
			set;
		}

		public enum CombatClassAttackEnum
		{
			DOTA_COMBAT_CLASS_ATTACK_HERO,
			DOTA_COMBAT_CLASS_ATTACK_PIERCE,
			DOTA_COMBAT_CLASS_ATTACK_BASIC,
			DOTA_COMBAT_CLASS_ATTACK_SIEGE,
			DOTA_COMBAT_CLASS_ATTACK_LIGHT,
		}

		[Category("Team")]
		[Description("Damage type")]
		[DefaultValue(CombatClassAttackEnum.DOTA_COMBAT_CLASS_ATTACK_HERO)]
		public CombatClassAttackEnum CombatClassAttack
		{
			get;
			set;
		}

		public enum CombatClassDefendEnum
		{
			DOTA_COMBAT_CLASS_DEFEND_HERO,
			DOTA_COMBAT_CLASS_DEFEND_SOFT,
			DOTA_COMBAT_CLASS_DEFEND_STRUCTURE,
			DOTA_COMBAT_CLASS_DEFEND_STRONG,
			DOTA_COMBAT_CLASS_DEFEND_BASIC,
			DOTA_COMBAT_CLASS_DEFEND_WEAK,
		}

		[Category("Team")]
		[Description("Armor type.")]
		[DefaultValue(CombatClassDefendEnum.DOTA_COMBAT_CLASS_DEFEND_HERO)]
		public CombatClassDefendEnum CombatClassDefend
		{
			get;
			set;
		}

		public enum UnitRelationshipClassEnum
		{
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_DEFAULT,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_BUILDING,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_BARRACKS,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_SIEGE,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_WARD,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_COURIER,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_HERO,
		}

		[Category("Team")]
		[Description("Unit type")]
		[DefaultValue(UnitRelationshipClassEnum.DOTA_NPC_UNIT_RELATIONSHIP_TYPE_HERO)]
		public UnitRelationshipClassEnum UnitRelationshipClass
		{
			get;
			set;
		}

		[Category("Vision")]
		[Description("Range of vision during the day.")]
		[DefaultValue(1800)]
		public int VisionDaytimeRange
		{
			get;
			set;
		}

		[Category("Vision")]
		[Description("Range of vision at night time.")]
		[DefaultValue(800)]
		public int VisionNighttimeRange
		{
			get;
			set;
		}

		[Category("Inventory")]
		[Description("Enables inventory.")]
		[DefaultValue(true)]
		public bool HasInventory
		{
			get;
			set;
		}

		[Category("Bounds")]
		[Description("No Description Set")]
		[DefaultValue(-1)]
		public int HealthBarOffset
		{
			get;
			set;
		}

		[Category("Idle")]
		[Description("Sound played when the unit is idle.")]
		[DefaultValue("")]
		public string IdleSoundLoop
		{
			get;
			set;
		}

	}
}
