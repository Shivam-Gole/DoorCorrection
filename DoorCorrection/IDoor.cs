using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent
{
    public delegate void DoorEventHandler(object sender, EventArgs e);
    public interface IDoor
    {
        event DoorEventHandler DoorOpened;
        event DoorEventHandler DoorClosed;

        bool IsOpen { get; }

        void Open();
        void Close();
    }
}
