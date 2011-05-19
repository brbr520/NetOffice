//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void OlkLabel_ClickEventHandler();
	public delegate void OlkLabel_DoubleClickEventHandler();
	public delegate void OlkLabel_MouseDownEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkLabel_MouseMoveEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkLabel_MouseUpEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass OlkLabel SupportByLibrary Outlook, 12,14
	///</summary>
	[SupportByLibrary("Outlook", 12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class OlkLabel : _OlkLabel, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		OlkLabelEvents_SinkHelper _olkLabelEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkLabel(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkLabel(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkLabel(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public OlkLabel()
		{
			CreateFromProgId("Outlook.OlkLabel");
		}
		
		/// <param name="progId">progId</param>
		public OlkLabel(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, OlkLabelEvents_SinkHelper.Id);


			if(OlkLabelEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_olkLabelEvents_SinkHelper = new OlkLabelEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event OlkLabel_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkLabel_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event OlkLabel_DoubleClickEventHandler _DoubleClickEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkLabel_DoubleClickEventHandler DoubleClickEvent
		{
			add
			{
				CreateEventBridge();
				_DoubleClickEvent += value;
			}
			remove
			{
				_DoubleClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event OlkLabel_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkLabel_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event OlkLabel_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkLabel_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event OlkLabel_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkLabel_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _olkLabelEvents_SinkHelper)
			{
				_olkLabelEvents_SinkHelper.Dispose();
				_olkLabelEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}