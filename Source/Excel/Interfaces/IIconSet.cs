﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.ExcelApi
{
    /// <summary>
    /// Interface IIconSet 
    /// SupportByVersion Excel, 12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property, "Excel", 12, 14, 15, 16), HasIndexProperty(IndexInvoke.Property, "_Default")]
	[TypeId("0002449B-0001-0000-C000-000000000046")]
    public interface IIconSet : ICOMObject, IEnumerableProvider<NetOffice.ExcelApi.Icon>
    {
        #region Properties

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        NetOffice.ExcelApi.Application Application { get; }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        NetOffice.ExcelApi.Enums.XlCreator Creator { get; }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16), ProxyResult]
        object Parent { get; }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        NetOffice.ExcelApi.Enums.XlIconSet ID { get; }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        Int32 Count { get; }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        [NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
        NetOffice.ExcelApi.Icon this[object index] { get; }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.Icon>

        /// <summary>
        /// SupportByVersion Excel, 12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        new IEnumerator<NetOffice.ExcelApi.Icon> GetEnumerator();

        #endregion
    }
}
