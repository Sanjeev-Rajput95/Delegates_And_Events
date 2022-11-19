using System;

namespace Delegates_And_Evants
{
    public delegate int Operation(int x, int y);
    public class Program
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Delegates\n");
            Operation obj1 = new Operation(Addition);
            Operation obj2 = new Operation(Subtraction);

            Console.WriteLine($"\nAddition of two numbers is: {obj1(20, 30)}");
            Console.WriteLine($"\nSubtraction of two numbers is: {obj2(20, 30)}");

            MulticastDelegates.ImplementDelegate();

            Console.ReadLine();
        }
    }
}