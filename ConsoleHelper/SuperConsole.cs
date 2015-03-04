using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelper
{
    public static class SuperConsole
    {
        public static T ReadLine<T>()
        {
            string input = Console.ReadLine();

            if (typeof(T) == typeof(Int32))
            {
                int curVal = 0;
                Int32.TryParse(input, out curVal);
                return Return<T>(curVal);
            }

            if (typeof(T) == typeof(Double))
            {
                double curVal = 0;
                Double.TryParse(input, out curVal);
                return Return<T>(curVal);
            }

            if (typeof(T) == typeof(Single))
            {
                float curVal = 0;
                Single.TryParse(input, out curVal);
                return Return<T>(curVal);
            }

            return Return<T>(input);
        }

        private static T Return<T>(object val)
        {
            return (T)Convert.ChangeType(val, typeof(T));
        }

        public static T ReadLine<T>(Predicate<T> conditionPredicate)
        {
            T res = ReadLine<T>();

            if (!conditionPredicate.Invoke(res))
            {
                return default(T);
            }

            return res;
        }
    }
}
