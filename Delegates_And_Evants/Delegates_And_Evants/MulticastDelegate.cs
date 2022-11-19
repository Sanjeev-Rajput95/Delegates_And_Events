using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And_Evants
{
    public class MulticastDelegates
    {
        delegate void MultiOperation(int x, int y);

        public static void ImplementDelegate()
        {
            Console.WriteLine("\n==========Multicast Delegates==========");
            MultiOperation objMulti = Operation.Add;
            objMulti += Operation.Sub;

            objMulti(10, 5);
            objMulti(15, 20);
        }

        public class Operation
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine($"\nAddition: {a + b}");
            }

            public static void Sub(int a, int b)
            {
                Console.WriteLine($"\nSubtraction: {a - b}");
            }
        }
    }
}
