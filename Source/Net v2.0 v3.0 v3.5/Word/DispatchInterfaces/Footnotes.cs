//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Footnotes SupportByLibrary Word, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Footnotes : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Footnotes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Footnotes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Footnotes(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Footnotes()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdFootnoteLocation Location
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Location", paramsArray);
				return (NetOffice.WordApi.Enums.WdFootnoteLocation)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Location", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdNoteNumberStyle NumberStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberStyle", paramsArray);
				return (NetOffice.WordApi.Enums.WdNoteNumberStyle)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumberStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 StartingNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StartingNumber", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StartingNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdNumberingRule NumberingRule
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberingRule", paramsArray);
				return (NetOffice.WordApi.Enums.WdNumberingRule)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumberingRule", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Range Separator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Separator", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Range ContinuationSeparator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ContinuationSeparator", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Range ContinuationNotice
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ContinuationNotice", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.Footnote this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.Footnote newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Footnote;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Reference">ref optional object Reference</param>
		/// <param name="Text">ref optional object Text</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Footnote Add(NetOffice.WordApi.Range range, ref object reference, ref object text)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, reference, text);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray, modifiers);
			NetOffice.WordApi.Footnote newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Footnote;
			reference = (object)paramsArray[1];
			text = (object)paramsArray[2];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Footnote Add(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Footnote newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Footnote;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void Convert()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Convert", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void SwapWithEndnotes()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SwapWithEndnotes", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void ResetSeparator()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ResetSeparator", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void ResetContinuationSeparator()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ResetContinuationSeparator", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void ResetContinuationNotice()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ResetContinuationNotice", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("Word", 9,10,11,12,14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
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