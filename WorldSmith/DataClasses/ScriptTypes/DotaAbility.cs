/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.Panels;
using WorldSmith.Dialogs;
using KVLib;

namespace WorldSmith.DataClasses
{
	public partial class DotaAbility : BaseScriptType
	{
		public DotaAbility(KeyValue kv)
			: base(kv)
		{
		}
		public DotaAbility(string className)
			: base(className)
		{
		}
		[Category("Misc")]
		[Description("No Description Set")]
		[ReadOnly(true)]
		[DefaultValue(0)]
		public int ID
		{
			get
			{
				KeyValue kv = GetSubkey("ID");
				return (kv == null ? 0 : kv.GetInt());
			}
			set
			{
				GetSubkey("ID").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string AbilityName
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityName");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				GetSubkey("AbilityName").Set(value.ToString());
			}
		}

		public enum AbilityTypeEnum
		{
			DOTA_ABILITY_TYPE_BASIC,
			DOTA_ABILITY_TYPE_ATTRIBUTES,
			DOTA_ABILITY_TYPE_ULTIMATE,
			DOTA_ABILITY_TYPE_HIDDEN,
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityTypeEnum.DOTA_ABILITY_TYPE_BASIC)]
		public AbilityTypeEnum AbilityType
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityType");
				return (kv == null ? AbilityTypeEnum.DOTA_ABILITY_TYPE_BASIC : kv.GetEnum<AbilityTypeEnum>());
			}
			set
			{
				GetSubkey("AbilityType").Set(value.ToString());
			}
		}

		public enum AbilityUnitDamageTypeEnum
		{
			DAMAGE_TYPE_COMPOSITE,
			DAMAGE_TYPE_HP_REMOVAL,
			DAMAGE_TYPE_MAGICAL,
			DAMAGE_TYPE_PHYSICAL,
			DAMAGE_TYPE_PURE,
			DAMAGE_TYPE_NONE,
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityUnitDamageTypeEnum.DAMAGE_TYPE_MAGICAL)]
		public AbilityUnitDamageTypeEnum AbilityUnitDamageType
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityUnitDamageType");
				return (kv == null ? AbilityUnitDamageTypeEnum.DAMAGE_TYPE_MAGICAL : kv.GetEnum<AbilityUnitDamageTypeEnum>());
			}
			set
			{
				GetSubkey("AbilityUnitDamageType").Set(value.ToString());
			}
		}

		[Flags]
		public enum AbilityBehaviorFlags : long
		{
			DOTA_ABILITY_BEHAVIOR_NONE = 0,
			DOTA_ABILITY_BEHAVIOR_HIDDEN = 1 << 0,
			DOTA_ABILITY_BEHAVIOR_PASSIVE = 1 << 1,
			DOTA_ABILITY_BEHAVIOR_NO_TARGET = 1 << 2,
			DOTA_ABILITY_BEHAVIOR_UNIT_TARGET = 1 << 3,
			DOTA_ABILITY_BEHAVIOR_POINT = 1 << 4,
			DOTA_ABILITY_BEHAVIOR_AOE = 1 << 5,
			DOTA_ABILITY_BEHAVIOR_NOT_LEARNABLE = 1 << 6,
			DOTA_ABILITY_BEHAVIOR_CHANNELLED = 1 << 7,
			DOTA_ABILITY_BEHAVIOR_ITEM = 1 << 8,
			DOTA_ABILITY_BEHAVIOR_TOGGLE = 1 << 9,
			DOTA_ABILITY_BEHAVIOR_DIRECTIONAL = 1 << 10,
			DOTA_ABILITY_BEHAVIOR_IMMEDIATE = 1 << 11,
			DOTA_ABILITY_BEHAVIOR_AUTOCAST = 1 << 12,
			DOTA_ABILITY_BEHAVIOR_NOASSIST = 1 << 13,
			DOTA_ABILITY_BEHAVIOR_AURA = 1 << 14,
			DOTA_ABILITY_BEHAVIOR_ATTACK = 1 << 15,
			DOTA_ABILITY_BEHAVIOR_DONT_RESUME_MOVEMENT = 1 << 16,
			DOTA_ABILITY_BEHAVIOR_ROOT_DISABLES = 1 << 17,
			DOTA_ABILITY_BEHAVIOR_UNRESTRICTED = 1 << 18,
			DOTA_ABILITY_BEHAVIOR_IGNORE_PSEUDO_QUEUE = 1 << 19,
			DOTA_ABILITY_BEHAVIOR_IGNORE_CHANNEL = 1 << 20,
			DOTA_ABILITY_BEHAVIOR_DONT_CANCEL_MOVEMENT = 1 << 21,
			DOTA_ABILITY_BEHAVIOR_DONT_ALERT_TARGET = 1 << 22,
			DOTA_ABILITY_BEHAVIOR_DONT_RESUME_ATTACK = 1 << 23,
			DOTA_ABILITY_BEHAVIOR_NORMAL_WHEN_STOLEN = 1 << 24,
			DOTA_ABILITY_BEHAVIOR_IGNORE_BACKSWING = 1 << 25,
			DOTA_ABILITY_BEHAVIOR_RUNE_TARGET = 1 << 26,
			DOTA_ABILITY_BEHAVIOR_IGNORE_TURN = 1 << 27,
			DOTA_ABILITY_BEHAVIOR_POINT_TARGET = 1 << 28,
			DOTA_ABILITY_BEHAVIOR_DONT_CANCEL_CHANNEL = 1 << 29,
			DOTA_ABILITY_TYPE_ULTIMATE = 1 << 30,
			DOTA_ABILITY_BEHAVIOR_OPTIONAL_UNIT_TARGET = 1 << 31,
			DOTA_ABILITY_IMMEDIATE = 1 << 32,
		}

		[Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityBehaviorFlags.DOTA_ABILITY_BEHAVIOR_NONE)]
		public AbilityBehaviorFlags AbilityBehavior
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityBehavior");
				return (kv == null ? AbilityBehaviorFlags.DOTA_ABILITY_BEHAVIOR_NONE : kv.GetEnum<AbilityBehaviorFlags>());
			}
			set
			{
				GetSubkey("AbilityBehavior").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string AbilityTextureName
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityTextureName");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				GetSubkey("AbilityTextureName").Set(value.ToString());
			}
		}

		[Flags]
		public enum AbilityUnitTargetTeamFlags : long
		{
			DOTA_UNIT_TARGET_TEAM_NONE = 0,
			DOTA_UNIT_TARGET_TEAM_ENEMY = 1 << 1,
			DOTA_UNIT_TARGET_TEAM_FRIENDLY = 1 << 2,
			DOTA_UNIT_TARGET_TEAM_CUSTOM = 1 << 3,
			DOTA_UNIT_TARGET_TEAM_BOTH = 1 << 4,
			DOTA_UNIT_TARGET_ALL = 0xFFFF,
		}

		[Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityUnitTargetTeamFlags.DOTA_UNIT_TARGET_TEAM_NONE)]
		public AbilityUnitTargetTeamFlags AbilityUnitTargetTeam
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityUnitTargetTeam");
				return (kv == null ? AbilityUnitTargetTeamFlags.DOTA_UNIT_TARGET_TEAM_NONE : kv.GetEnum<AbilityUnitTargetTeamFlags>());
			}
			set
			{
				GetSubkey("AbilityUnitTargetTeam").Set(value.ToString());
			}
		}

		[Flags]
		public enum AbilityUnitTargetTypeFlags : long
		{
			DOTA_UNIT_TARGET_NONE = 0,
			DOTA_UNIT_TARGET_HERO = 1 << 1,
			DOTA_UNIT_TARGET_CREEP = 1 << 2,
			DOTA_UNIT_TARGET_BUILDING = 1 << 3,
			DOTA_UNIT_TARGET_MECHANICAL = 1 << 4,
			DOTA_UNIT_TARGET_COURIER = 1 << 5,
			DOTA_UNIT_TARGET_OTHER = 1 << 6,
			DOTA_UNIT_TARGET_TREE = 1 << 7,
			DOTA_UNIT_TARGET_CUSTOM = 1 << 8,
			DOTA_UNIT_TARGET_BASIC = 1 << 9,
			DOTA_UNIT_TARGET_OTHERS = 1 << 10,
			DOTA_UNIT_TARGET_ALL = 0xFFFF,
		}

		[Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityUnitTargetTypeFlags.DOTA_UNIT_TARGET_NONE)]
		public AbilityUnitTargetTypeFlags AbilityUnitTargetType
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityUnitTargetType");
				return (kv == null ? AbilityUnitTargetTypeFlags.DOTA_UNIT_TARGET_NONE : kv.GetEnum<AbilityUnitTargetTypeFlags>());
			}
			set
			{
				GetSubkey("AbilityUnitTargetType").Set(value.ToString());
			}
		}

		[Flags]
		public enum AbilityUnitTargetFlagsFlags : long
		{
			DOTA_UNIT_TARGET_FLAG_NONE = 0,
			DOTA_UNIT_TARGET_FLAG_RANGED_ONLY = 1 << 1,
			DOTA_UNIT_TARGET_FLAG_MELEE_ONLY = 1 << 2,
			DOTA_UNIT_TARGET_FLAG_DEAD = 1 << 3,
			DOTA_UNIT_TARGET_FLAG_MAGIC_IMMUNE_ENEMIES = 1 << 4,
			DOTA_UNIT_TARGET_FLAG_NOT_MAGIC_IMMUNE_ALLIES = 1 << 5,
			DOTA_UNIT_TARGET_FLAG_INVULNERABLE = 1 << 6,
			DOTA_UNIT_TARGET_FLAG_FOW_VISIBLE = 1 << 7,
			DOTA_UNIT_TARGET_FLAG_NO_INVIS = 1 << 8,
			DOTA_UNIT_TARGET_FLAG_NOT_ANCIENTS = 1 << 9,
			DOTA_UNIT_TARGET_FLAG_PLAYER_CONTROLLED = 1 << 10,
			DOTA_UNIT_TARGET_FLAG_NOT_DOMINATED = 1 << 11,
			DOTA_UNIT_TARGET_FLAG_NOT_SUMMONED = 1 << 12,
			DOTA_UNIT_TARGET_FLAG_NOT_ILLUSION = 1 << 13,
			DOTA_UNIT_TARGET_FLAG_NOT_ATTACK_IMMUNE = 1 << 14,
			DOTA_UNIT_TARGET_FLAG_MANA_ONLY = 1 << 15,
			DOTA_UNIT_TARGET_FLAG_CHECK_DISABLE_HELP = 1 << 16,
			DOTA_UNIT_TARGET_FLAG_NOT_CREEP_HERO = 1 << 17,
			DOTA_UNIT_TARGET_FLAG_OUT_OF_WORLD = 1 << 18,
			DOTA_UNIT_TARGET_FLAG_NOT_NIGHTMARED = 1 << 19,
		}

		[Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityUnitTargetFlagsFlags.DOTA_UNIT_TARGET_FLAG_NONE)]
		public AbilityUnitTargetFlagsFlags AbilityUnitTargetFlags
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityUnitTargetFlags");
				return (kv == null ? AbilityUnitTargetFlagsFlags.DOTA_UNIT_TARGET_FLAG_NONE : kv.GetEnum<AbilityUnitTargetFlagsFlags>());
			}
			set
			{
				GetSubkey("AbilityUnitTargetFlags").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool OnCastbar
		{
			get
			{
				KeyValue kv = GetSubkey("OnCastbar");
				return (kv == null ? false : kv.GetBool());
			}
			set
			{
				GetSubkey("OnCastbar").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool OnLearnbar
		{
			get
			{
				KeyValue kv = GetSubkey("OnLearnbar");
				return (kv == null ? false : kv.GetBool());
			}
			set
			{
				GetSubkey("OnLearnbar").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(0)]
		public int AbilityCastRange
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityCastRange");
				return (kv == null ? 0 : kv.GetInt());
			}
			set
			{
				GetSubkey("AbilityCastRange").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(250)]
		public int AbilityCastRangeBuffer
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityCastRangeBuffer");
				return (kv == null ? 250 : kv.GetInt());
			}
			set
			{
				GetSubkey("AbilityCastRangeBuffer").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityCastPoint
		{
			get
			{
				return default(PerLevel);
			}
			set
			{
				GetSubkey("AbilityCastPoint").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityChannelTime
		{
			get
			{
				return default(PerLevel);
			}
			set
			{
				GetSubkey("AbilityChannelTime").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityCooldown
		{
			get
			{
				return default(PerLevel);
			}
			set
			{
				GetSubkey("AbilityCooldown").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityDuration
		{
			get
			{
				return default(PerLevel);
			}
			set
			{
				GetSubkey("AbilityDuration").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string AbilitySharedCooldown
		{
			get
			{
				KeyValue kv = GetSubkey("AbilitySharedCooldown");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				GetSubkey("AbilitySharedCooldown").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0 0 0 0")]
		public PerLevel AbilityDamage
		{
			get
			{
				return default(PerLevel);
			}
			set
			{
				GetSubkey("AbilityDamage").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0 0 0 0")]
		public PerLevel AbilityManaCost
		{
			get
			{
				return default(PerLevel);
			}
			set
			{
				GetSubkey("AbilityManaCost").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(1.0f)]
		public float AbilityModifierSupportValue
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityModifierSupportValue");
				return (kv == null ? 1f : kv.GetFloat());
			}
			set
			{
				GetSubkey("AbilityModifierSupportValue").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(0f)]
		public float AbilityModifierSupportBonus
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityModifierSupportBonus");
				return (kv == null ? 0f : kv.GetFloat());
			}
			set
			{
				GetSubkey("AbilityModifierSupportBonus").Set(value.ToString());
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool AbilityProcsMagicStick
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityProcsMagicStick");
				return (kv == null ? false : kv.GetBool());
			}
			set
			{
				GetSubkey("AbilityProcsMagicStick").Set(value.ToString());
			}
		}

	}
}
