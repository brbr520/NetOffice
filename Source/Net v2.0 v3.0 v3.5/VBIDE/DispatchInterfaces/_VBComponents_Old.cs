//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.VBIDEApi
{
	///<summary>
	/// DispatchInterface _VBComponents_Old SupportByLibrary VBIDE, 5.3,12
	///</summary>
	[SupportByLibrary("VBIDE", 5.3,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _VBComponents_Old : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _VBComponents_Old(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _VBComponents_Old(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _VBComponents_Old(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _VBComponents_Old()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.VBProject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.VBIDEApi.VBProject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VBIDEApi.VBProject;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.VBE VBE
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VBE", paramsArray);
				NetOffice.VBIDEApi.VBE newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VBIDEApi.VBE;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.VBIDEApi.VBComponent this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.VBIDEApi.VBComponent newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.VBIDEApi.VBComponent;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="VBComponent">NetOffice.VBIDEApi.VBComponent VBComponent</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public void Remove(NetOffice.VBIDEApi.VBComponent vBComponent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(vBComponent);
			Invoker.Method(this, "Remove", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="ComponentType">NetOffice.VBIDEApi.Enums.vbext_ComponentType ComponentType</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.VBComponent Add(NetOffice.VBIDEApi.Enums.vbext_ComponentType componentType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(componentType);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.VBIDEApi.VBComponent newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.VBIDEApi.VBComponent;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.VBComponent Import(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "Import", paramsArray);
			NetOffice.VBIDEApi.VBComponent newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.VBIDEApi.VBComponent;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("VBIDE", 5.3,12)]
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