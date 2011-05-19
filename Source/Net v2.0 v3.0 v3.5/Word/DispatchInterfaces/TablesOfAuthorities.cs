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
	/// DispatchInterface TablesOfAuthorities SupportByLibrary Word, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class TablesOfAuthorities : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfAuthorities(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfAuthorities(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfAuthorities(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfAuthorities()
		{
		}
		
		#endregion
		
		#region Properties

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
		public NetOffice.WordApi.Enums.WdToaFormat Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				return (NetOffice.WordApi.Enums.WdToaFormat)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Format", paramsArray);
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
		public NetOffice.WordApi.TableOfAuthorities this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.TableOfAuthorities;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Category">ref optional object Category</param>
		/// <param name="Bookmark">ref optional object Bookmark</param>
		/// <param name="Passim">ref optional object Passim</param>
		/// <param name="KeepEntryFormatting">ref optional object KeepEntryFormatting</param>
		/// <param name="Separator">ref optional object Separator</param>
		/// <param name="IncludeSequenceName">ref optional object IncludeSequenceName</param>
		/// <param name="EntrySeparator">ref optional object EntrySeparator</param>
		/// <param name="PageRangeSeparator">ref optional object PageRangeSeparator</param>
		/// <param name="IncludeCategoryHeader">ref optional object IncludeCategoryHeader</param>
		/// <param name="PageNumberSeparator">ref optional object PageNumberSeparator</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range, ref object category, ref object bookmark, ref object passim, ref object keepEntryFormatting, ref object separator, ref object includeSequenceName, ref object entrySeparator, ref object pageRangeSeparator, ref object includeCategoryHeader, ref object pageNumberSeparator)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, category, bookmark, passim, keepEntryFormatting, separator, includeSequenceName, entrySeparator, pageRangeSeparator, includeCategoryHeader, pageNumberSeparator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray, modifiers);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.TableOfAuthorities;
			category = (object)paramsArray[1];
			bookmark = (object)paramsArray[2];
			passim = (object)paramsArray[3];
			keepEntryFormatting = (object)paramsArray[4];
			separator = (object)paramsArray[5];
			includeSequenceName = (object)paramsArray[6];
			entrySeparator = (object)paramsArray[7];
			pageRangeSeparator = (object)paramsArray[8];
			includeCategoryHeader = (object)paramsArray[9];
			pageNumberSeparator = (object)paramsArray[10];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ShortCitation">string ShortCitation</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void NextCitation(string shortCitation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(shortCitation);
			Invoker.Method(this, "NextCitation", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="ShortCitation">string ShortCitation</param>
		/// <param name="LongCitation">ref optional object LongCitation</param>
		/// <param name="LongCitationAutoText">ref optional object LongCitationAutoText</param>
		/// <param name="Category">ref optional object Category</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkCitation(NetOffice.WordApi.Range range, string shortCitation, ref object longCitation, ref object longCitationAutoText, ref object category)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, shortCitation, longCitation, longCitationAutoText, category);
			object returnItem = Invoker.MethodReturn(this, "MarkCitation", paramsArray, modifiers);
			NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Field;
			longCitation = (object)paramsArray[2];
			longCitationAutoText = (object)paramsArray[3];
			category = (object)paramsArray[4];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="ShortCitation">string ShortCitation</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkCitation(NetOffice.WordApi.Range range, string shortCitation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, shortCitation);
			object returnItem = Invoker.MethodReturn(this, "MarkCitation", paramsArray);
			NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ShortCitation">string ShortCitation</param>
		/// <param name="LongCitation">ref optional object LongCitation</param>
		/// <param name="LongCitationAutoText">ref optional object LongCitationAutoText</param>
		/// <param name="Category">ref optional object Category</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void MarkAllCitations(string shortCitation, ref object longCitation, ref object longCitationAutoText, ref object category)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(shortCitation, longCitation, longCitationAutoText, category);
			Invoker.Method(this, "MarkAllCitations", paramsArray, modifiers);
			longCitation = (object)paramsArray[1];
			longCitationAutoText = (object)paramsArray[2];
			category = (object)paramsArray[3];
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ShortCitation">string ShortCitation</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void MarkAllCitations(string shortCitation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(shortCitation);
			Invoker.Method(this, "MarkAllCitations", paramsArray);
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