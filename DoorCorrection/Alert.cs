using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoorEvent
{
    public class Alert : IAlert
    {
        public void Activate()
        {
            Console.WriteLine("Alarm activated!");
        }
    }
}

