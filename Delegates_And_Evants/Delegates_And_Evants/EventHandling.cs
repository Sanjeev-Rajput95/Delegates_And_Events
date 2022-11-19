using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And_Evants
{
    public delegate void EventHandler(string x);
    public class EventHandling
    {
        public class Operation
        {
            public event EventHandler xyz;

            public void Action(string a)
            {
                if (xyz != null)
                {
                    xyz(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }

        private static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }

        public static void ImplementEvent()
        {
            Operation opera = new Operation();
            opera.Action("Event Calling");

            Console.WriteLine();
            opera.xyz += new EventHandler(CatchEvent);
            opera.Action("Event Called");
        }
    }
}
