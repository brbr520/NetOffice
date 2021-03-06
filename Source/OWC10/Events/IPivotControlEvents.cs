﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;
using NetOffice.Attributes;

namespace NetOffice.OWC10Api.EventContracts
{
    /// <summary>
    /// IPivotControlEvents
    /// </summary>
    [SupportByVersion("OWC10", 1)]
    [InternalEntity(InternalEntityKind.ComEventInterface)]
    [ComImport, Guid("F5B39A87-1480-11D3-8549-00C04FAC67D7"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface IPivotControlEvents
	{
        /// <summary>
        /// SelectionChange
        /// </summary>
		[SupportByVersion("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6003)]
		void SelectionChange();

        /// <summary>
        /// ViewChange
        /// </summary>
        /// <param name="reason"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("reason", SinkArgumentType.Enum, typeof(OWC10Api.Enums.PivotViewReasonEnum))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6004)]
		void ViewChange([In] object reason);

        /// <summary>
        /// DataChange
        /// </summary>
        /// <param name="reason"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("reason", SinkArgumentType.Enum, typeof(OWC10Api.Enums.PivotViewReasonEnum))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6007)]
		void DataChange([In] object reason);

        /// <summary>
        /// PivotTableChange
        /// </summary>
        /// <param name="reason"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("reason", SinkArgumentType.Enum, typeof(OWC10Api.Enums.PivotViewReasonEnum))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6021)]
		void PivotTableChange([In] object reason);

        /// <summary>
        /// BeforeQuery
        /// </summary>
		[SupportByVersion("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6043)]
		void BeforeQuery();

        /// <summary>
        /// Query
        /// </summary>
		[SupportByVersion("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6044)]
		void Query();

        /// <summary>
        /// OnConnect
        /// </summary>
		[SupportByVersion("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6029)]
		void OnConnect();

        /// <summary>
        /// OnDisconnect
        /// </summary>
		[SupportByVersion("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6030)]
		void OnDisconnect();

        /// <summary>
        /// MouseDown
        /// </summary>
        /// <param name="button"></param>
        /// <param name="shift"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("button", SinkArgumentType.Int32)]
        [SinkArgument("shift", SinkArgumentType.Int32)]
        [SinkArgument("x", SinkArgumentType.Int32)]
        [SinkArgument("y", SinkArgumentType.Int32)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6034)]
		void MouseDown([In] object button, [In] object shift, [In] object x, [In] object y);

        /// <summary>
        /// MouseMove
        /// </summary>
        /// <param name="button"></param>
        /// <param name="shift"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("button", SinkArgumentType.Int32)]
        [SinkArgument("shift", SinkArgumentType.Int32)]
        [SinkArgument("x", SinkArgumentType.Int32)]
        [SinkArgument("y", SinkArgumentType.Int32)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6032)]
		void MouseMove([In] object button, [In] object shift, [In] object x, [In] object y);

        /// <summary>
        /// MouseUp
        /// </summary>
        /// <param name="button"></param>
        /// <param name="shift"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("button", SinkArgumentType.Int32)]
        [SinkArgument("shift", SinkArgumentType.Int32)]
        [SinkArgument("x", SinkArgumentType.Int32)]
        [SinkArgument("y", SinkArgumentType.Int32)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6033)]
		void MouseUp([In] object button, [In] object shift, [In] object x, [In] object y);

        /// <summary>
        /// MouseWheel
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("page", SinkArgumentType.Bool)]
        [SinkArgument("count", SinkArgumentType.Int32)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6035)]
		void MouseWheel([In] object page, [In] object count);

        /// <summary>
        /// Click
        /// </summary>
		[SupportByVersion("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6005)]
		void Click();

        /// <summary>
        /// DblClick
        /// </summary>
		[SupportByVersion("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6006)]
		void DblClick();

        /// <summary>
        /// CommandEnabled
        /// </summary>
        /// <param name="command"></param>
        /// <param name="enabled"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("enabled", typeof(OWC10Api.ByRef))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1000)]
		void CommandEnabled([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object enabled);

        /// <summary>
        /// CommandChecked
        /// </summary>
        /// <param name="command"></param>
        /// <param name="_checked"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("_checked", typeof(OWC10Api.ByRef))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1001)]
		void CommandChecked([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object _checked);

        /// <summary>
        /// CommandTipText
        /// </summary>
        /// <param name="command"></param>
        /// <param name="caption"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("caption", typeof(OWC10Api.ByRef))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1002)]
		void CommandTipText([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object caption);

        /// <summary>
        /// CommandBeforeExecute
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancel"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("cancel", typeof(OWC10Api.ByRef))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1003)]
		void CommandBeforeExecute([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

        /// <summary>
        /// CommandExecute
        /// </summary>
        /// <param name="command"></param>
        /// <param name="succeeded"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("succeeded", typeof(OWC10Api.ByRef))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1004)]
		void CommandExecute([In] object command, [In] object succeeded);

        /// <summary>
        /// KeyDown
        /// </summary>
        /// <param name="keyCode"></param>
        /// <param name="shift"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("keyCode", SinkArgumentType.Int32)]
        [SinkArgument("shift", SinkArgumentType.Int32)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1009)]
		void KeyDown([In] object keyCode, [In] object shift);

        /// <summary>
        /// KeyUp
        /// </summary>
        /// <param name="keyCode"></param>
        /// <param name="shift"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("keyCode", SinkArgumentType.Int32)]
        [SinkArgument("shift", SinkArgumentType.Int32)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1008)]
		void KeyUp([In] object keyCode, [In] object shift);

        /// <summary>
        /// KeyPress
        /// </summary>
        /// <param name="keyAscii"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("keyAscii", SinkArgumentType.Int32)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1010)]
		void KeyPress([In] object keyAscii);

        /// <summary>
        /// BeforeKeyDown
        /// </summary>
        /// <param name="keyCode"></param>
        /// <param name="shift"></param>
        /// <param name="cancel"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("keyCode", SinkArgumentType.Int32)]
        [SinkArgument("shift", SinkArgumentType.Int32)]
        [SinkArgument("cancel", typeof(OWC10Api.ByRef))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1006)]
		void BeforeKeyDown([In] object keyCode, [In] object shift, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

        /// <summary>
        /// BeforeKeyUp
        /// </summary>
        /// <param name="keyCode"></param>
        /// <param name="shift"></param>
        /// <param name="cancel"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("keyCode", SinkArgumentType.Int32)]
        [SinkArgument("shift", SinkArgumentType.Int32)]
        [SinkArgument("cancel", typeof(OWC10Api.ByRef))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1005)]
		void BeforeKeyUp([In] object keyCode, [In] object shift, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

        /// <summary>
        /// BeforeKeyPress
        /// </summary>
        /// <param name="keyAscii"></param>
        /// <param name="cancel"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("keyAscii", SinkArgumentType.Int32)]
        [SinkArgument("cancel", typeof(OWC10Api.ByRef))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1007)]
		void BeforeKeyPress([In] object keyAscii, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

        /// <summary>
        /// BeforeContextMenu
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="menu"></param>
        /// <param name="cancel"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("x", SinkArgumentType.Int32)]
        [SinkArgument("y", SinkArgumentType.Int32)]
        [SinkArgument("menu", typeof(OWC10Api.ByRef))]
        [SinkArgument("cancel", typeof(OWC10Api.ByRef))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1011)]
		void BeforeContextMenu([In] object x, [In] object y, [In, MarshalAs(UnmanagedType.IDispatch)] object menu, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

        /// <summary>
        /// StartEdit
        /// </summary>
        /// <param name="selection"></param>
        /// <param name="activeObject"></param>
        /// <param name="initialValue"></param>
        /// <param name="arrowMode"></param>
        /// <param name="caretPosition"></param>
        /// <param name="cancel"></param>
        /// <param name="errorDescription"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("selection", SinkArgumentType.UnknownProxy)]
        [SinkArgument("activeObject", SinkArgumentType.UnknownProxy)]
        [SinkArgument("initialValue", typeof(OWC10Api.ByRef))]
        [SinkArgument("arrowMode", typeof(OWC10Api.ByRef))]
        [SinkArgument("caretPosition", typeof(OWC10Api.ByRef))]
        [SinkArgument("cancel", typeof(OWC10Api.ByRef))]
        [SinkArgument("errorDescription", typeof(OWC10Api.ByRef))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6045)]
		void StartEdit([In, MarshalAs(UnmanagedType.IDispatch)] object selection, [In, MarshalAs(UnmanagedType.IDispatch)] object activeObject, [In, MarshalAs(UnmanagedType.IDispatch)] object initialValue, [In, MarshalAs(UnmanagedType.IDispatch)] object arrowMode, [In, MarshalAs(UnmanagedType.IDispatch)] object caretPosition, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel, [In, MarshalAs(UnmanagedType.IDispatch)] object errorDescription);

        /// <summary>
        /// EndEdit
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="finalValue"></param>
        /// <param name="cancel"></param>
        /// <param name="errorDescription"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("accept", SinkArgumentType.Bool)]
        [SinkArgument("finalValue", typeof(OWC10Api.ByRef))]
        [SinkArgument("cancel", typeof(OWC10Api.ByRef))]
        [SinkArgument("errorDescription", typeof(OWC10Api.ByRef))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6046)]
		void EndEdit([In] object accept, [In, MarshalAs(UnmanagedType.IDispatch)] object finalValue, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel, [In, MarshalAs(UnmanagedType.IDispatch)] object errorDescription);

        /// <summary>
        /// BeforeScreenTip
        /// </summary>
        /// <param name="screenTipText"></param>
        /// <param name="sourceObject"></param>
		[SupportByVersion("OWC10", 1)]
        [SinkArgument("screenTipText", typeof(OWC10Api.ByRef))]
        [SinkArgument("sourceObject", SinkArgumentType.UnknownProxy)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6049)]
		void BeforeScreenTip([In, MarshalAs(UnmanagedType.IDispatch)] object screenTipText, [In, MarshalAs(UnmanagedType.IDispatch)] object sourceObject);
	}
}
