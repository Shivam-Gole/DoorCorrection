using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoorEvent
{
    public class SimpleDoor : IDoor
    {
        public event DoorEventHandler DoorOpened;
        public event DoorEventHandler DoorClosed;

        private bool isOpen;

        public bool IsOpen
        {
            get { return isOpen; }
            protected set { isOpen = value; }
        }

        public virtual void Open()
        {
            IsOpen = true;
            OnDoorOpened();
        }

        public void Close()
        {
            IsOpen = false;
            OnDoorClosed();
        }

        protected virtual void OnDoorOpened()
        {
            DoorOpened?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnDoorClosed()
        {
            DoorClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
