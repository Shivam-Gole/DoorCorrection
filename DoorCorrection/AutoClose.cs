using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DoorEvent
{
    public class AutoClose : IAutoClose
    {
        public Timer autoCloseTimer;

        public void SetTimer(int seconds, Action onTimerElapsed)
        {
            autoCloseTimer = new Timer(_ => onTimerElapsed(), null, seconds * 1000, Timeout.Infinite);
        }
    }
}

