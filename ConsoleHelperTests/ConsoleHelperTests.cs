using System;
using ConsoleHelper;
namespace ConsoleHelperTests
{
    public class ConsoleHelperTests
    {
        public static void Main()
        {
            TestInt();
            TestDouble();
            TestFloat();

            Console.Read();
        }

        static void TestInt()
        {
            Console.WriteLine("Type an Int: ");
            int result = SuperConsole.ReadLine<int>();
            Console.WriteLine("Result: {0}", result);
        }

        static void TestDouble()
        {
            Console.WriteLine("Type a double: ");
            double result = SuperConsole.ReadLine<double>();
            Console.WriteLine("Result: {0}", result);
        }

        static void TestFloat()
        {
            Console.WriteLine("Type a float: ");
            float result = SuperConsole.ReadLine<float>();
            Console.WriteLine("Result: {0}", result);
        }
    }
}
