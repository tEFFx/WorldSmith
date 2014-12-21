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
	public partial class DotaUnit : DotaBaseUnit
	{
		public DotaUnit(KeyValue kv)
			: base(kv)
		{
		}
		public DotaUnit(string className)
			: base(className)
		{
		}
		[Category("General")]
		[Description("If this unit is an ancient unit or not.")]
		[DefaultValue(false)]
		public bool IsAncient
		{
			get
			{
				KeyValue kv = GetSubkey("IsAncient");
				return (kv == null ? false : kv.GetBool());
			}
			set
			{
				GetSubkey("IsAncient").Set(value.ToString());
			}
		}

		[Category("General")]
		[Description("If this unit is neutral or not.")]
		[DefaultValue(false)]
		public bool IsNeutralUnitType
		{
			get
			{
				KeyValue kv = GetSubkey("IsNeutralUnitType");
				return (kv == null ? false : kv.GetBool());
			}
			set
			{
				GetSubkey("IsNeutralUnitType").Set(value.ToString());
			}
		}

		[Category("Selection")]
		[Description("Units with the same selection group will cycle together when tabbing through owned units.")]
		[DefaultValue("")]
		public string SelectionGroup
		{
			get
			{
				KeyValue kv = GetSubkey("SelectionGroup");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				GetSubkey("SelectionGroup").Set(value.ToString());
			}
		}

		[Category("Selection")]
		[Description("Select this unit on spawn.")]
		[DefaultValue(false)]
		public bool SelectOnSpawn
		{
			get
			{
				KeyValue kv = GetSubkey("SelectOnSpawn");
				return (kv == null ? false : kv.GetBool());
			}
			set
			{
				GetSubkey("SelectOnSpawn").Set(value.ToString());
			}
		}

		[Category("General")]
		[Description("Can this unit be dominated and controlled by players?")]
		[DefaultValue(false)]
		public bool CanBeDominated
		{
			get
			{
				KeyValue kv = GetSubkey("CanBeDominated");
				return (kv == null ? false : kv.GetBool());
			}
			set
			{
				GetSubkey("CanBeDominated").Set(value.ToString());
			}
		}

		[Category("Selection")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool IgnoreAddSummonedToSelection
		{
			get
			{
				KeyValue kv = GetSubkey("IgnoreAddSummonedToSelection");
				return (kv == null ? false : kv.GetBool());
			}
			set
			{
				GetSubkey("IgnoreAddSummonedToSelection").Set(value.ToString());
			}
		}

		[Category("Attack")]
		[Description("If this unit should auto-attack by default.")]
		[DefaultValue(true)]
		public bool AutoAttacksByDefault
		{
			get
			{
				KeyValue kv = GetSubkey("AutoAttacksByDefault");
				return (kv == null ? true : kv.GetBool());
			}
			set
			{
				GetSubkey("AutoAttacksByDefault").Set(value.ToString());
			}
		}

		[Category("Attack")]
		[Description("No Description Set")]
		[DefaultValue(250)]
		public int AttackRangeBuffer
		{
			get
			{
				KeyValue kv = GetSubkey("AttackRangeBuffer");
				return (kv == null ? 250 : kv.GetInt());
			}
			set
			{
				GetSubkey("AttackRangeBuffer").Set(value.ToString());
			}
		}

		[Category("Movement")]
		[Description("The distance at which this unit follows another. (?)")]
		[DefaultValue(100)]
		public int FollowRange
		{
			get
			{
				KeyValue kv = GetSubkey("FollowRange");
				return (kv == null ? 100 : kv.GetInt());
			}
			set
			{
				GetSubkey("FollowRange").Set(value.ToString());
			}
		}

		[Category("Attack")]
		[Description("How much bots want to attack them vs other non-hero things")]
		[DefaultValue(1.0f)]
		public float AttackDesire
		{
			get
			{
				KeyValue kv = GetSubkey("AttackDesire");
				return (kv == null ? 1f : kv.GetFloat());
			}
			set
			{
				GetSubkey("AttackDesire").Set(value.ToString());
			}
		}

		[Category("General")]
		[Description("If this unit wakes up neutrals when it gets close.")]
		[DefaultValue(true)]
		public bool WakesNeutrals
		{
			get
			{
				KeyValue kv = GetSubkey("WakesNeutrals");
				return (kv == null ? true : kv.GetBool());
			}
			set
			{
				GetSubkey("WakesNeutrals").Set(value.ToString());
			}
		}

	}
}
