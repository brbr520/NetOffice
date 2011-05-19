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
	/// DispatchInterface _CurrentProject SupportByLibrary Access, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Access", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _CurrentProject : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentProject(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentProject(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentProject(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentProject()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.AllForms AllForms
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllForms", paramsArray);
				NetOffice.AccessApi.AllForms newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.AllForms;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.AllReports AllReports
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllReports", paramsArray);
				NetOffice.AccessApi.AllReports newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.AllReports;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.AllMacros AllMacros
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllMacros", paramsArray);
				NetOffice.AccessApi.AllMacros newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.AllMacros;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.AllModules AllModules
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllModules", paramsArray);
				NetOffice.AccessApi.AllModules newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.AllModules;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.AllDataAccessPages AllDataAccessPages
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllDataAccessPages", paramsArray);
				NetOffice.AccessApi.AllDataAccessPages newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.AllDataAccessPages;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.Enums.AcProjectType ProjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ProjectType", paramsArray);
				return (NetOffice.AccessApi.Enums.AcProjectType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string BaseConnectionString
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaseConnectionString", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool IsConnected
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsConnected", paramsArray);
				return (bool)returnItem;
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
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string Path
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Path", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string FullName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FullName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.ADODBApi.Connection Connection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Connection", paramsArray);
				NetOffice.ADODBApi.Connection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi.Connection;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.AccessObjectProperties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				NetOffice.AccessApi.AccessObjectProperties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.AccessObjectProperties;
				return newObject;
			}
		}

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
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public bool RemovePersonalInformation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RemovePersonalInformation", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RemovePersonalInformation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public NetOffice.AccessApi.Enums.AcFileFormat FileFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FileFormat", paramsArray);
				return (NetOffice.AccessApi.Enums.AcFileFormat)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public NetOffice.ADODBApi.Connection AccessConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AccessConnection", paramsArray);
				NetOffice.ADODBApi.Connection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi.Connection;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public NetOffice.AccessApi.ImportExportSpecifications ImportExportSpecifications
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ImportExportSpecifications", paramsArray);
				NetOffice.AccessApi.ImportExportSpecifications newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.ImportExportSpecifications;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public bool IsTrusted
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsTrusted", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public string WebSite
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WebSite", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public bool IsWeb
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsWeb", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public NetOffice.AccessApi.SharedResources Resources
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Resources", paramsArray);
				NetOffice.AccessApi.SharedResources newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.SharedResources;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="BaseConnectionString">optional object BaseConnectionString</param>
		/// <param name="UserID">optional object UserID</param>
		/// <param name="Password">optional object Password</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public void OpenConnection(object baseConnectionString, object userID, object password)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(baseConnectionString, userID, password);
			Invoker.Method(this, "OpenConnection", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public void OpenConnection()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "OpenConnection", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public void CloseConnection()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CloseConnection", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 11,12,14)]
		public void UpdateDependencyInfo()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpdateDependencyInfo", paramsArray);
		}

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
		/// SupportByLibrary Access 14
		/// </summary>
		/// <param name="SharedImageName">string SharedImageName</param>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("Access", 14)]
		public void AddSharedImage(string sharedImageName, string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sharedImageName, fileName);
			Invoker.Method(this, "AddSharedImage", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}