//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface IListItems SupportByLibrary MSComctlLib, 6
	///</summary>
	[SupportByLibrary("MSComctlLib", 6)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IListItems : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListItems(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListItems(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListItems(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListItems()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Count", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">ref object Index</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IListItem get_ControlDefault(ref object index)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "ControlDefault", paramsArray, modifiers);
			NetOffice.MSComctlLibApi.IListItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IListItem;
			index = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("MSComctlLib", 6)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.MSComctlLibApi.IListItem this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.MSComctlLibApi.IListItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IListItem;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">ref optional object Index</param>
		/// <param name="Key">ref optional object Key</param>
		/// <param name="Text">ref optional object Text</param>
		/// <param name="Icon">ref optional object Icon</param>
		/// <param name="SmallIcon">ref optional object SmallIcon</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IListItem Add(ref object index, ref object key, ref object text, ref object icon, ref object smallIcon)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(index, key, text, icon, smallIcon);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray, modifiers);
			NetOffice.MSComctlLibApi.IListItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IListItem;
			index = (object)paramsArray[0];
			key = (object)paramsArray[1];
			text = (object)paramsArray[2];
			icon = (object)paramsArray[3];
			smallIcon = (object)paramsArray[4];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IListItem Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IListItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IListItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">ref object Index</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public void Remove(ref object index)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray, modifiers);
			index = (object)paramsArray[0];
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("MSComctlLib", 6)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}