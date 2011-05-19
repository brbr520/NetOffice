//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// Interface IOleParentUndoUnit SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IOleParentUndoUnit : IOleUndoUnit
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOleParentUndoUnit(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOleParentUndoUnit(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOleParentUndoUnit(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOleParentUndoUnit()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pPUU">NetOffice.OWC10Api.IOleParentUndoUnit pPUU</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Open(NetOffice.OWC10Api.IOleParentUndoUnit pPUU)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pPUU);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pPUU">NetOffice.OWC10Api.IOleParentUndoUnit pPUU</param>
		/// <param name="fCommit">Int32 fCommit</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Close(NetOffice.OWC10Api.IOleParentUndoUnit pPUU, Int32 fCommit)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pPUU, fCommit);
			object returnItem = Invoker.MethodReturn(this, "Close", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pUU">NetOffice.OWC10Api.IOleUndoUnit pUU</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Add(NetOffice.OWC10Api.IOleUndoUnit pUU)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pUU);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pUU">NetOffice.OWC10Api.IOleUndoUnit pUU</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 FindUnit(NetOffice.OWC10Api.IOleUndoUnit pUU)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pUU);
			object returnItem = Invoker.MethodReturn(this, "FindUnit", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pdwState">ref Int32 pdwState</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 GetParentState(ref Int32 pdwState)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(pdwState);
			object returnItem = Invoker.MethodReturn(this, "GetParentState", paramsArray);
			pdwState = (Int32)paramsArray[0];
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}