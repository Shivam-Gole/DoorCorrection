using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoorEvent
{
    public class Program
    {
        static void Main()
        {
            SimpleDoor simpleDoor = new SimpleDoor();

            // Create instances of classes implementing IAlert, INotify, and IAutoClose
            IAlert alert = new Alert();
            INotify notify = new Notify();
            IAutoClose autoClose = new AutoClose();

            // Create SmartDoor with dependencies injected
            SmartDoor smartDoor = new SmartDoor(true, true, true, alert, notify, autoClose);

            Operator doorOperator = new Operator();

            doorOperator.OperateDoor(simpleDoor);
            Console.WriteLine();

            doorOperator.OperateDoor(smartDoor);
        }
    }
}

