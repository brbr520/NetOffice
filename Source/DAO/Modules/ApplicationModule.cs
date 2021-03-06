﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.DAOApi.GlobalHelperModules
{
    /// <summary>
    /// Module GlobalModule
    /// SupportByVersion DAO, 3.6,12.0
    /// </summary>
    /// <remarks>This module supports legacy VB/VBA codebases</remarks>
    [SupportByVersion("DAO", 3.6, 12.0)]
    [EntityType(EntityType.IsModule)]
    public static class ApplciationModule
    {
        #region Fields

        private static ICOMObject _instance;

        #endregion

        #region Internal Properties

        internal static ICOMObject Instance
        {
            get
            {
                return _instance;
            }
            set
            {
                if ((null == value) || (null == _instance))
                    _instance = value;
            }
        }

        internal static Core Factory
        {
            get
            {
                if (null != _instance)
                    return _instance.Factory;
                else
                    return Core.Default;
            }
        }

        internal static Invoker Invoker
        {
            get
            {
                if (null != _instance)
                    return _instance.Invoker;
                else
                    return Invoker.Default;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// Get
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static string Version
        {
            get
            {
                object[] paramsArray = null;
                object returnItem = Invoker.PropertyGet(_instance, "Version", paramsArray);
                return NetRuntimeSystem.Convert.ToString(returnItem);
            }
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// Get/Set
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static string IniPath
        {
            get
            {
                object[] paramsArray = null;
                object returnItem = Invoker.PropertyGet(_instance, "IniPath", paramsArray);
                return NetRuntimeSystem.Convert.ToString(returnItem);
            }
            set
            {
                object[] paramsArray = Invoker.ValidateParamsArray(value);
                Invoker.PropertySet(_instance, "IniPath", paramsArray);
            }
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// Get/Set
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static string DefaultUser
        {
            get
            {
                object[] paramsArray = null;
                object returnItem = Invoker.PropertyGet(_instance, "DefaultUser", paramsArray);
                return NetRuntimeSystem.Convert.ToString(returnItem);
            }
            set
            {
                object[] paramsArray = Invoker.ValidateParamsArray(value);
                Invoker.PropertySet(_instance, "DefaultUser", paramsArray);
            }
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// Get/Set
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static string DefaultPassword
        {
            get
            {
                object[] paramsArray = null;
                object returnItem = Invoker.PropertyGet(_instance, "DefaultPassword", paramsArray);
                return NetRuntimeSystem.Convert.ToString(returnItem);
            }
            set
            {
                object[] paramsArray = Invoker.ValidateParamsArray(value);
                Invoker.PropertySet(_instance, "DefaultPassword", paramsArray);
            }
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// Get/Set
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static Int16 LoginTimeout
        {
            get
            {
                object[] paramsArray = null;
                object returnItem = Invoker.PropertyGet(_instance, "LoginTimeout", paramsArray);
                return NetRuntimeSystem.Convert.ToInt16(returnItem);
            }
            set
            {
                object[] paramsArray = Invoker.ValidateParamsArray(value);
                Invoker.PropertySet(_instance, "LoginTimeout", paramsArray);
            }
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// Get
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Workspaces Workspaces
        {
            get
            {
                object[] paramsArray = null;
                object returnItem = Invoker.PropertyGet(_instance, "Workspaces", paramsArray);
                NetOffice.DAOApi.Workspaces newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Workspaces)) as NetOffice.DAOApi.Workspaces;
                return newObject;
            }
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// Get
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Errors Errors
        {
            get
            {
                object[] paramsArray = null;
                object returnItem = Invoker.PropertyGet(_instance, "Errors", paramsArray);
                NetOffice.DAOApi.Errors newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Errors)) as NetOffice.DAOApi.Errors;
                return newObject;
            }
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// Get/Set
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static string SystemDB
        {
            get
            {
                object[] paramsArray = null;
                object returnItem = Invoker.PropertyGet(_instance, "SystemDB", paramsArray);
                return NetRuntimeSystem.Convert.ToString(returnItem);
            }
            set
            {
                object[] paramsArray = Invoker.ValidateParamsArray(value);
                Invoker.PropertySet(_instance, "SystemDB", paramsArray);
            }
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// Get/Set
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static Int32 DefaultType
        {
            get
            {
                object[] paramsArray = null;
                object returnItem = Invoker.PropertyGet(_instance, "DefaultType", paramsArray);
                return NetRuntimeSystem.Convert.ToInt32(returnItem);
            }
            set
            {
                object[] paramsArray = Invoker.ValidateParamsArray(value);
                Invoker.PropertySet(_instance, "DefaultType", paramsArray);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="action">optional object action</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void Idle(object action)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(action);
            Invoker.Method(_instance, "Idle", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void Idle()
        {
            object[] paramsArray = null;
            Invoker.Method(_instance, "Idle", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="srcName">string srcName</param>
        /// <param name="dstName">string dstName</param>
        /// <param name="dstLocale">optional object dstLocale</param>
        /// <param name="options">optional object options</param>
        /// <param name="srcLocale">optional object srcLocale</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void CompactDatabase(string srcName, string dstName, object dstLocale, object options, object srcLocale)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(srcName, dstName, dstLocale, options, srcLocale);
            Invoker.Method(_instance, "CompactDatabase", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="srcName">string srcName</param>
        /// <param name="dstName">string dstName</param>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void CompactDatabase(string srcName, string dstName)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(srcName, dstName);
            Invoker.Method(_instance, "CompactDatabase", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="srcName">string srcName</param>
        /// <param name="dstName">string dstName</param>
        /// <param name="dstLocale">optional object dstLocale</param>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void CompactDatabase(string srcName, string dstName, object dstLocale)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(srcName, dstName, dstLocale);
            Invoker.Method(_instance, "CompactDatabase", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="srcName">string srcName</param>
        /// <param name="dstName">string dstName</param>
        /// <param name="dstLocale">optional object dstLocale</param>
        /// <param name="options">optional object options</param>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void CompactDatabase(string srcName, string dstName, object dstLocale, object options)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(srcName, dstName, dstLocale, options);
            Invoker.Method(_instance, "CompactDatabase", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void RepairDatabase(string name)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name);
            Invoker.Method(_instance, "RepairDatabase", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="dsn">string dsn</param>
        /// <param name="driver">string driver</param>
        /// <param name="silent">bool silent</param>
        /// <param name="attributes">string attributes</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void RegisterDatabase(string dsn, string driver, bool silent, string attributes)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(dsn, driver, silent, attributes);
            Invoker.Method(_instance, "RegisterDatabase", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="userName">string userName</param>
        /// <param name="password">string password</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Workspace _30_CreateWorkspace(string name, string userName, string password)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, userName, password);
            object returnItem = Invoker.MethodReturn(_instance, "_30_CreateWorkspace", paramsArray);
            NetOffice.DAOApi.Workspace newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Workspace)) as NetOffice.DAOApi.Workspace;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="options">optional object options</param>
        /// <param name="readOnly">optional object readOnly</param>
        /// <param name="connect">optional object connect</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Database OpenDatabase(string name, object options, object readOnly, object connect)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, options, readOnly, connect);
            object returnItem = Invoker.MethodReturn(_instance, "OpenDatabase", paramsArray);
            NetOffice.DAOApi.Database newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Database)) as NetOffice.DAOApi.Database;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Database OpenDatabase(string name)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name);
            object returnItem = Invoker.MethodReturn(_instance, "OpenDatabase", paramsArray);
            NetOffice.DAOApi.Database newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Database)) as NetOffice.DAOApi.Database;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="options">optional object options</param>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Database OpenDatabase(string name, object options)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, options);
            object returnItem = Invoker.MethodReturn(_instance, "OpenDatabase", paramsArray);
            NetOffice.DAOApi.Database newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Database)) as NetOffice.DAOApi.Database;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="options">optional object options</param>
        /// <param name="readOnly">optional object readOnly</param>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Database OpenDatabase(string name, object options, object readOnly)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, options, readOnly);
            object returnItem = Invoker.MethodReturn(_instance, "OpenDatabase", paramsArray);
            NetOffice.DAOApi.Database newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Database)) as NetOffice.DAOApi.Database;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="locale">string locale</param>
        /// <param name="option">optional object option</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Database CreateDatabase(string name, string locale, object option)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, locale, option);
            object returnItem = Invoker.MethodReturn(_instance, "CreateDatabase", paramsArray);
            NetOffice.DAOApi.Database newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Database)) as NetOffice.DAOApi.Database;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="locale">string locale</param>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Database CreateDatabase(string name, string locale)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, locale);
            object returnItem = Invoker.MethodReturn(_instance, "CreateDatabase", paramsArray);
            NetOffice.DAOApi.Database newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Database)) as NetOffice.DAOApi.Database;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void FreeLocks()
        {
            object[] paramsArray = null;
            Invoker.Method(_instance, "FreeLocks", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void BeginTrans()
        {
            object[] paramsArray = null;
            Invoker.Method(_instance, "BeginTrans", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="option">optional Int32 Option = 0</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void CommitTrans(object option)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(option);
            Invoker.Method(_instance, "CommitTrans", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void CommitTrans()
        {
            object[] paramsArray = null;
            Invoker.Method(_instance, "CommitTrans", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void Rollback()
        {
            object[] paramsArray = null;
            Invoker.Method(_instance, "Rollback", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="password">string password</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void SetDefaultWorkspace(string name, string password)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, password);
            Invoker.Method(_instance, "SetDefaultWorkspace", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="option">Int16 option</param>
        /// <param name="value">object value</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void SetDataAccessOption(Int16 option, object value)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(option, value);
            Invoker.Method(_instance, "SetDataAccessOption", paramsArray);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="statNum">Int32 statNum</param>
        /// <param name="reset">optional object reset</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static Int32 ISAMStats(Int32 statNum, object reset)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(statNum, reset);
            object returnItem = Invoker.MethodReturn(_instance, "ISAMStats", paramsArray);
            return NetRuntimeSystem.Convert.ToInt32(returnItem);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="statNum">Int32 statNum</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static Int32 ISAMStats(Int32 statNum)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(statNum);
            object returnItem = Invoker.MethodReturn(_instance, "ISAMStats", paramsArray);
            return NetRuntimeSystem.Convert.ToInt32(returnItem);
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="userName">string userName</param>
        /// <param name="password">string password</param>
        /// <param name="useType">optional object useType</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Workspace CreateWorkspace(string name, string userName, string password, object useType)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, userName, password, useType);
            object returnItem = Invoker.MethodReturn(_instance, "CreateWorkspace", paramsArray);
            NetOffice.DAOApi.Workspace newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Workspace)) as NetOffice.DAOApi.Workspace;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="userName">string userName</param>
        /// <param name="password">string password</param>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Workspace CreateWorkspace(string name, string userName, string password)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, userName, password);
            object returnItem = Invoker.MethodReturn(_instance, "CreateWorkspace", paramsArray);
            NetOffice.DAOApi.Workspace newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Workspace)) as NetOffice.DAOApi.Workspace;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="options">optional object options</param>
        /// <param name="readOnly">optional object readOnly</param>
        /// <param name="connect">optional object connect</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Connection OpenConnection(string name, object options, object readOnly, object connect)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, options, readOnly, connect);
            object returnItem = Invoker.MethodReturn(_instance, "OpenConnection", paramsArray);
            NetOffice.DAOApi.Connection newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Connection)) as NetOffice.DAOApi.Connection;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Connection OpenConnection(string name)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name);
            object returnItem = Invoker.MethodReturn(_instance, "OpenConnection", paramsArray);
            NetOffice.DAOApi.Connection newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Connection)) as NetOffice.DAOApi.Connection;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="options">optional object options</param>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Connection OpenConnection(string name, object options)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, options);
            object returnItem = Invoker.MethodReturn(_instance, "OpenConnection", paramsArray);
            NetOffice.DAOApi.Connection newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Connection)) as NetOffice.DAOApi.Connection;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="options">optional object options</param>
        /// <param name="readOnly">optional object readOnly</param>
        [CustomMethod]
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static NetOffice.DAOApi.Connection OpenConnection(string name, object options, object readOnly)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(name, options, readOnly);
            object returnItem = Invoker.MethodReturn(_instance, "OpenConnection", paramsArray);
            NetOffice.DAOApi.Connection newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem, typeof(NetOffice.DAOApi.Connection)) as NetOffice.DAOApi.Connection;
            return newObject;
        }

        /// <summary>
        /// SupportByVersion DAO 3.6, 12.0
        /// </summary>
        /// <param name="option">Int32 option</param>
        /// <param name="value">object value</param>
        [SupportByVersion("DAO", 3.6, 12.0)]
        public static void SetOption(Int32 option, object value)
        {
            object[] paramsArray = Invoker.ValidateParamsArray(option, value);
            Invoker.Method(_instance, "SetOption", paramsArray);
        }

        #endregion
    }
}
