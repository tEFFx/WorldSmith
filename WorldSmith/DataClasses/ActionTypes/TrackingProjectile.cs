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
	[DotaAction]
	[EditorGrammar("Fire a Tracking projectile at the target that is dodgable %Dodgeable with the effect %EffectName and moves at %MoveSpeed units per second.  It provides vision %ProvidesVision of %VisionRadius units")]
	public partial class TrackingProjectile : BaseAction
	{
		public TrackingProjectile(KeyValue kv)
			: base(kv)
		{
		}
		public TrackingProjectile(string className)
			: base(className)
		{
		}
		[Category("Misc")]
		[Description("bool")]
		[DefaultValue(false)]
		public bool Dodgeable
		{
			get
			{
				KeyValue kv = GetSubkey("Dodgeable");
				return (kv == null ? false : kv.GetBool());
			}
			set
			{
				KeyValue kv = GetSubkey("Dodgeable");
				if(kv == null)
				{
					kv = new KeyValue("Dodgeable");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Misc")]
		[Description("bool")]
		[DefaultValue(false)]
		public bool ProvidesVision
		{
			get
			{
				KeyValue kv = GetSubkey("ProvidesVision");
				return (kv == null ? false : kv.GetBool());
			}
			set
			{
				KeyValue kv = GetSubkey("ProvidesVision");
				if(kv == null)
				{
					kv = new KeyValue("ProvidesVision");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Misc")]
		[Description("int")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue VisionRadius
		{
			get
			{
				KeyValue kv = GetSubkey("VisionRadius");
				return (kv == null ? new NumberValue("") : kv.GetNumberValue());
			}
			set
			{
				KeyValue kv = GetSubkey("VisionRadius");
				if(kv == null)
				{
					kv = new KeyValue("VisionRadius");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Misc")]
		[Description("Effect Name")]
		[DefaultValue("")]
		public string EffectName
		{
			get
			{
				KeyValue kv = GetSubkey("EffectName");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("EffectName");
				if(kv == null)
				{
					kv = new KeyValue("EffectName");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Misc")]
		[Description("int")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue MoveSpeed
		{
			get
			{
				KeyValue kv = GetSubkey("MoveSpeed");
				return (kv == null ? new NumberValue("") : kv.GetNumberValue());
			}
			set
			{
				KeyValue kv = GetSubkey("MoveSpeed");
				if(kv == null)
				{
					kv = new KeyValue("MoveSpeed");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Misc")]
		[Description("?")]
		[DefaultValue("")]
		public string SourceAttachment
		{
			get
			{
				KeyValue kv = GetSubkey("SourceAttachment");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("SourceAttachment");
				if(kv == null)
				{
					kv = new KeyValue("SourceAttachment");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

	}
}
