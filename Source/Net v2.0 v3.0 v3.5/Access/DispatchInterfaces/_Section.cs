//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface _Section SupportByLibrary Access, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Access", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Section : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Section(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Section(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Section(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Section()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.AccessApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.Properties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				NetOffice.AccessApi.Properties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.Properties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.Children Controls
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Controls", paramsArray);
				NetOffice.AccessApi.Children newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.Children;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string EventProcPrefix
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EventProcPrefix", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EventProcPrefix", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string _Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "_Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public byte ForceNewPage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForceNewPage", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ForceNewPage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public byte NewRowOrCol
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NewRowOrCol", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NewRowOrCol", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool KeepTogether
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "KeepTogether", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "KeepTogether", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public byte DisplayWhen
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayWhen", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayWhen", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool CanGrow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CanGrow", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CanGrow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool CanShrink
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CanShrink", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CanShrink", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool RepeatSection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RepeatSection", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RepeatSection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int16 Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int32 BackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackColor", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public byte SpecialEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SpecialEffect", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SpecialEffect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string Tag
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tag", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Tag", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string OnFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnFormat", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string OnPrint
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnPrint", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnPrint", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string OnRetreat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnRetreat", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnRetreat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string OnClick
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnClick", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnClick", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string OnDblClick
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnDblClick", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnDblClick", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string OnMouseDown
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnMouseDown", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnMouseDown", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string OnMouseMove
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnMouseMove", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnMouseMove", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string OnMouseUp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnMouseUp", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnMouseUp", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool HasContinued
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasContinued", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasContinued", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool WillContinue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WillContinue", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WillContinue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool InSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InSelection", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InSelection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public bool AutoHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoHeight", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoHeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string OnFormatMacro
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnFormatMacro", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnFormatMacro", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string OnPrintMacro
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnPrintMacro", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnPrintMacro", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string OnRetreatMacro
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnRetreatMacro", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnRetreatMacro", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string OnClickMacro
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnClickMacro", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnClickMacro", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string OnDblClickMacro
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnDblClickMacro", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnDblClickMacro", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string OnMouseDownMacro
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnMouseDownMacro", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnMouseDownMacro", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string OnMouseMoveMacro
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnMouseMoveMacro", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnMouseMoveMacro", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string OnMouseUpMacro
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnMouseUpMacro", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnMouseUpMacro", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public Int32 AlternateBackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlternateBackColor", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlternateBackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string OnPaint
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnPaint", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnPaint", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string OnPaintMacro
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnPaintMacro", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnPaintMacro", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public Int32 BackThemeColorIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackThemeColorIndex", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackThemeColorIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public Single BackTint
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackTint", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackTint", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public Single BackShade
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackShade", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackShade", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public Int32 AlternateBackThemeColorIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlternateBackThemeColorIndex", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlternateBackThemeColorIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public Single AlternateBackTint
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlternateBackTint", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlternateBackTint", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public Single AlternateBackShade
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlternateBackShade", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlternateBackShade", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Access 11, 12, 14
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[SupportByLibrary("Access", 11,12,14)]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public void SetTabOrder()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetTabOrder", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}