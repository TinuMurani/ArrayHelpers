using ArrayHelpersLibrary;
using System;

namespace ArrayHelpersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 3]
            {
                { 2, 1, 4 },
                { 3, 5, 6 }
            };

            ArrayHelper<int> helper = new ArrayHelper<int>(array);

            Console.WriteLine(helper.IndexOf(4)); 

            Console.ReadLine();
        }
    }
}
