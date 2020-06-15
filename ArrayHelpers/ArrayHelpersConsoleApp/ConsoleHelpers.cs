using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelpersConsoleApp
{
    public static class ConsoleHelpers<T>
    {
        public static void PrintEquatableResult(List<T> input)
        {
            if (input.Count is 0)
            {
                Console.WriteLine("-1");
            }
        }


    }
}
