using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent
{
    public class Notify : INotify
    {
        public void SendNotification()
        {
            Console.WriteLine("Pager notification sent!");
        }
    }
}
