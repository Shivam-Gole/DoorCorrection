﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent
{
    public interface IAutoClose
    {
        void SetTimer(int seconds, Action onTimerElapsed);
    }
}
