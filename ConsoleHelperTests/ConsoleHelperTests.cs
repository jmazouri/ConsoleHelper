using System;
using ConsoleHelper;

namespace ConsoleHelperTests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class ConsoleHelperTests
    {
        public static void Main()
        {
            
            TestInt();
            TestDouble();
            TestFloat();
            

            TestIntDefault();
            TestConditionalFloat();
            TestConditionalDoubleDefault();

            Console.ReadLine();
        }

        static void TestInt()
        {
            Console.WriteLine("Type an Int: ");
            int result = SuperConsole.ReadLine<int>();
            Console.WriteLine("Result: {0}", result);
        }

        static void TestIntDefault()
        {
            Console.WriteLine("Type an Int (default 100): ");
            int result = SuperConsole.ReadLine(100);
            Console.WriteLine("Result: {0}", result);
        }

        static void TestConditionalFloat()
        {
            Console.WriteLine("Type a float between 5 and 20: ");
            float result = SuperConsole.ReadLine<float>(d=>d >= 5 && d <= 20);
            Console.WriteLine("Result: {0}", result);
        }

        static void TestConditionalDoubleDefault()
        {
            Console.WriteLine("Type a double between 1 and 99 (default: 50): ");
            double result = SuperConsole.ReadLine<double>(d => d >= 1 && d <= 99, 50);
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
