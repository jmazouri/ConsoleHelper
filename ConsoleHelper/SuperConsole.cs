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
            object ret = null;

            if (typeof(T) == typeof(Int32))
            {
                int curVal = 0;
                Int32.TryParse(input, out curVal);
                ret = curVal;
            }

            if (typeof(T) == typeof(Double))
            {
                double curVal = 0;
                Double.TryParse(input, out curVal);
                ret = curVal;
            }

            if (typeof(T) == typeof(Single))
            {
                float curVal = 0;
                Single.TryParse(input, out curVal);
                ret = curVal;
            }

            return (T)Convert.ChangeType(ret, typeof(T));
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
