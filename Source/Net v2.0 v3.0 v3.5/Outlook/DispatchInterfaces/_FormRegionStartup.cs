//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _FormRegionStartup SupportByLibrary Outlook, 12,14
	///</summary>
	[SupportByLibrary("Outlook", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _FormRegionStartup : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _FormRegionStartup(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _FormRegionStartup(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _FormRegionStartup(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _FormRegionStartup()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="FormRegionName">string FormRegionName</param>
		/// <param name="Item">object Item</param>
		/// <param name="LCID">Int32 LCID</param>
		/// <param name="FormRegionMode">NetOffice.OutlookApi.Enums.OlFormRegionMode FormRegionMode</param>
		/// <param name="FormRegionSize">NetOffice.OutlookApi.Enums.OlFormRegionSize FormRegionSize</param>
		[SupportByLibrary("Outlook", 12,14)]
		public object GetFormRegionStorage(string formRegionName, object item, Int32 lCID, NetOffice.OutlookApi.Enums.OlFormRegionMode formRegionMode, NetOffice.OutlookApi.Enums.OlFormRegionSize formRegionSize)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(formRegionName, item, lCID, formRegionMode, formRegionSize);
			object returnItem = Invoker.MethodReturn(this, "GetFormRegionStorage", paramsArray);
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
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="FormRegion">NetOffice.OutlookApi.FormRegion FormRegion</param>
		[SupportByLibrary("Outlook", 12,14)]
		public void BeforeFormRegionShow(NetOffice.OutlookApi.FormRegion formRegion)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(formRegion);
			Invoker.Method(this, "BeforeFormRegionShow", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="FormRegionName">string FormRegionName</param>
		/// <param name="LCID">Int32 LCID</param>
		[SupportByLibrary("Outlook", 12,14)]
		public object GetFormRegionManifest(string formRegionName, Int32 lCID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(formRegionName, lCID);
			object returnItem = Invoker.MethodReturn(this, "GetFormRegionManifest", paramsArray);
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
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="FormRegionName">string FormRegionName</param>
		/// <param name="LCID">Int32 LCID</param>
		/// <param name="Icon">NetOffice.OutlookApi.Enums.OlFormRegionIcon Icon</param>
		[SupportByLibrary("Outlook", 12,14)]
		public object GetFormRegionIcon(string formRegionName, Int32 lCID, NetOffice.OutlookApi.Enums.OlFormRegionIcon icon)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(formRegionName, lCID, icon);
			object returnItem = Invoker.MethodReturn(this, "GetFormRegionIcon", paramsArray);
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