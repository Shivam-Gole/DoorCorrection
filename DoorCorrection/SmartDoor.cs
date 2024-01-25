using DoorEvent;
using System;
using System.ComponentModel;

namespace DoorEvent
{
    public class SmartDoor : SimpleDoor
    {
        private bool alarmEnabled;
        private bool pagerNotificationEnabled;
        private bool autoCloseEnabled;

        private IAlert alert;
        private INotify notify;
        private IAutoClose autoClose;

        public event DoorEventHandler TimerAlert;

        public SmartDoor(bool alarmEnabled, bool pagerNotificationEnabled, bool autoCloseEnabled,
                         IAlert alert, INotify notify, IAutoClose autoClose)
        {
            this.alarmEnabled = alarmEnabled;
            this.pagerNotificationEnabled = pagerNotificationEnabled;
            this.autoCloseEnabled = autoCloseEnabled;

            this.alert = alert;
            this.notify = notify;
            this.autoClose = autoClose;
        }

        public override void Open()
        {
            base.Open();

            if (autoCloseEnabled)
            {
                autoClose.SetTimer(10, OnAutoCloseElapsed);
            }
        }

        private void OnAutoCloseElapsed()
        {
            Close();
            OnTimerAlert();
        }

        protected void OnTimerAlert()
        {
            TimerAlert?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnDoorOpened()
        {
            base.OnDoorOpened();

            if (alarmEnabled)
            {
                alert.Activate();
            }

            if (pagerNotificationEnabled)
            {
                notify.SendNotification();
            }
        }
    }
}
