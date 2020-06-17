using ArrayHelpersLibrary;
using System;
using System.Text;

namespace ArrayHelpersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 3]
            {
                { 2, 1, 4 },
                { 3, 4, 6 }
            };

            string[,] stringArray = new string[4, 3]
            {
                { "Ion", "George", "Radu" },
                { "Anca", "Maria", "Ioana" },
                { "Ionica", "Ciprian", "Vlad" },
                { "Ion", "Mirela", "George" }
            };

            ArrayHelper<int> helper = new ArrayHelper<int>(array);

            ArrayHelper<string> stringHelper = new ArrayHelper<string>(stringArray);

            //Console.WriteLine($"Element is at index: { helper.IndexOf(4)}");

            //Console.WriteLine($"Element is at index: { stringHelper.IndexOf("Ion")}");

            //Console.WriteLine($"Element at index [1, 2] is: { helper.ElementAt(1, 2).Element }");

            //Console.WriteLine($"Element at index [3, 1] is: { stringHelper.ElementAt(3, 1).Element }");

            string[] newArray = stringHelper.SubArray(0, 11);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < newArray.Length; i++)
            {
                sb.Append($"{ newArray[i] } ");
            }

            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }
    }
}
