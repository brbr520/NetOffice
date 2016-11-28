﻿using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195751.aspx </remarks>
	[SupportByVersionAttribute("Word", 14,15,16)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlErrorBarType
	{
		 /// <summary>
		 /// SupportByVersion Word 14, 15, 16
		 /// </summary>
		 /// <remarks>-4114</remarks>
		 [SupportByVersionAttribute("Word", 14,15,16)]
		 xlErrorBarTypeCustom = -4114,

		 /// <summary>
		 /// SupportByVersion Word 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Word", 14,15,16)]
		 xlErrorBarTypeFixedValue = 1,

		 /// <summary>
		 /// SupportByVersion Word 14, 15, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Word", 14,15,16)]
		 xlErrorBarTypePercent = 2,

		 /// <summary>
		 /// SupportByVersion Word 14, 15, 16
		 /// </summary>
		 /// <remarks>-4155</remarks>
		 [SupportByVersionAttribute("Word", 14,15,16)]
		 xlErrorBarTypeStDev = -4155,

		 /// <summary>
		 /// SupportByVersion Word 14, 15, 16
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Word", 14,15,16)]
		 xlErrorBarTypeStError = 4
	}
}