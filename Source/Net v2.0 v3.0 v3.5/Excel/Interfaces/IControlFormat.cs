//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IControlFormat SupportByLibrary Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IControlFormat : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IControlFormat(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IControlFormat(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IControlFormat(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IControlFormat()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
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
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 DropDownLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DropDownLines", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DropDownLines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool Enabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enabled", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Enabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 LargeChange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LargeChange", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LargeChange", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public string LinkedCell
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LinkedCell", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LinkedCell", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 ListCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListCount", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ListCount", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public string ListFillRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListFillRange", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ListFillRange", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 ListIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListIndex", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ListIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool LockedText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockedText", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockedText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 Max
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Max", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Max", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 Min
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Min", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Min", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 MultiSelect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MultiSelect", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MultiSelect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool PrintObject
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrintObject", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PrintObject", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 SmallChange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmallChange", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SmallChange", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 _Default
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "_Default", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Value", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Text">string Text</param>
		/// <param name="Index">optional object Index</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 AddItem(string text, object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, index);
			object returnItem = Invoker.MethodReturn(this, "AddItem", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Text">string Text</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 AddItem(string text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text);
			object returnItem = Invoker.MethodReturn(this, "AddItem", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 RemoveAllItems()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "RemoveAllItems", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		/// <param name="Count">optional object Count</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 RemoveItem(Int32 index, object count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, count);
			object returnItem = Invoker.MethodReturn(this, "RemoveItem", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 RemoveItem(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "RemoveItem", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public object List(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "List", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public object List()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "List", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		#endregion
		#pragma warning restore
	}
}