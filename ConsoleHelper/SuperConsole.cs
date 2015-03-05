using System;

namespace ConsoleHelper
{
    public static class SuperConsole
    {
        public static T ReadLine<T>(T defaultResult = default(T))
        {
            string input = Console.ReadLine();

            try
            {
                var parsedValue = Convert.ChangeType(input, typeof(T));
                return Return<T>(parsedValue);
            }
            catch (FormatException)
            {
                return Return<T>(defaultResult);
            }
        }

        private static T Return<T>(object val)
        {
            return (T)val;
        }

        public static T ReadLine<T>(Predicate<T> conditionPredicate, T defaultResult = default(T))
        {
            var res = ReadLine(defaultResult);
            return !conditionPredicate.Invoke(res) ? defaultResult : res;
        }
    }
}
