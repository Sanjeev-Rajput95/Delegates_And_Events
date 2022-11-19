using System;

namespace Delegates_And_Evants
{
    public delegate void DelEventHandler();
    public class Program
    {
        public static event DelEventHandler add;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Events\n");

            add += new DelEventHandler(India);
            add += new DelEventHandler(Japan);
            add += new DelEventHandler(England);

            add.Invoke();

            Console.WriteLine("\nEvent Handling: ");
            EventHandling.ImplementEvent();
        }
        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void Japan()
        {
            Console.WriteLine("Japan");
        }
        public static void England()
        {
            Console.WriteLine("England");
        }
    }
}