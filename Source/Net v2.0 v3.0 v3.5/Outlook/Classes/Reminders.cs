//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Reminders_BeforeReminderShowEventHandler(ref bool Cancel);
	public delegate void Reminders_ReminderAddEventHandler(NetOffice.OutlookApi._Reminder ReminderObject);
	public delegate void Reminders_ReminderChangeEventHandler(NetOffice.OutlookApi._Reminder ReminderObject);
	public delegate void Reminders_ReminderFireEventHandler(NetOffice.OutlookApi._Reminder ReminderObject);
	public delegate void Reminders_ReminderRemoveEventHandler();
	public delegate void Reminders_SnoozeEventHandler(NetOffice.OutlookApi._Reminder ReminderObject);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Reminders SupportByLibrary Outlook, 10,11,12,14
	///</summary>
	[SupportByLibrary("Outlook", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Reminders : _Reminders, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ReminderCollectionEvents_SinkHelper _reminderCollectionEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Reminders(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Reminders(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Reminders(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public Reminders()
		{
			CreateFromProgId("Outlook.Reminders");
		}
		
		/// <param name="progId">progId</param>
		public Reminders(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ReminderCollectionEvents_SinkHelper.Id);


			if(ReminderCollectionEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_reminderCollectionEvents_SinkHelper = new ReminderCollectionEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_BeforeReminderShowEventHandler _BeforeReminderShowEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Reminders_BeforeReminderShowEventHandler BeforeReminderShowEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeReminderShowEvent += value;
			}
			remove
			{
				_BeforeReminderShowEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_ReminderAddEventHandler _ReminderAddEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Reminders_ReminderAddEventHandler ReminderAddEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderAddEvent += value;
			}
			remove
			{
				_ReminderAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_ReminderChangeEventHandler _ReminderChangeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Reminders_ReminderChangeEventHandler ReminderChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderChangeEvent += value;
			}
			remove
			{
				_ReminderChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_ReminderFireEventHandler _ReminderFireEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Reminders_ReminderFireEventHandler ReminderFireEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderFireEvent += value;
			}
			remove
			{
				_ReminderFireEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_ReminderRemoveEventHandler _ReminderRemoveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Reminders_ReminderRemoveEventHandler ReminderRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderRemoveEvent += value;
			}
			remove
			{
				_ReminderRemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_SnoozeEventHandler _SnoozeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Reminders_SnoozeEventHandler SnoozeEvent
		{
			add
			{
				CreateEventBridge();
				_SnoozeEvent += value;
			}
			remove
			{
				_SnoozeEvent -= value;
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
			if( null != _reminderCollectionEvents_SinkHelper)
			{
				_reminderCollectionEvents_SinkHelper.Dispose();
				_reminderCollectionEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}