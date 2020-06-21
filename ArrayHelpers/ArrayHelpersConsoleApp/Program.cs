using ArrayHelpersLibrary;
using System;
using System.Runtime.ExceptionServices;
using System.Text;

namespace ArrayHelpersConsoleApp
{
    class Program
    {
        public delegate int[] AddArrays(int[] firstArray, int[] secondArray);

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

            #region Generics Assignment
            //Console.WriteLine($"Element is at index: { helper.IndexOf(4)}");

            //Console.WriteLine($"Element is at index: { stringHelper.IndexOf("Ion")}");

            //Console.WriteLine($"Element at index [1, 2] is: { helper.ElementAt(1, 2).Element }");

            //Console.WriteLine($"Element at index [3, 1] is: { stringHelper.ElementAt(3, 1).Element }");

            //string[] newStringArray = stringHelper.SubArray(5, 11, ArraySort.Ascending);
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < newStringArray.Length; i++)
            //{
            //    sb.Append($"{ newStringArray[i] } ");
            //}

            //Console.WriteLine(sb.ToString());


            //int[] newIntArray = helper.SubArray(0, 6, ArraySort.Descending);
            //StringBuilder sb1 = new StringBuilder();

            //for (int i = 0; i < newIntArray.Length; i++)
            //{
            //    sb1.Append($"{ newIntArray[i] } ");
            //}

            //Console.WriteLine(sb1.ToString());



            //int[] secondIntArray = helper.SubArray(0, 6, ArraySort.Ascending);
            //StringBuilder sb2 = new StringBuilder();

            //for (int i = 0; i < secondIntArray.Length; i++)
            //{
            //    sb2.Append($"{ secondIntArray[i] } ");
            //}

            //Console.WriteLine(sb2.ToString());


            //int[] result = new int[newIntArray.Length];

            //for (int i = 0; i < newIntArray.Length; i++)
            //{
            //    result[i] = newIntArray[i] + secondIntArray[i];
            //}

            //StringBuilder sb3 = new StringBuilder();

            //for (int i = 0; i < result.Length; i++)
            //{
            //    sb3.Append($"{ result[i] } ");
            //}

            //Console.WriteLine(sb3.ToString());
            #endregion

            #region Delegates Assignment

            AddArrays adition = delegate(int[] firstArray, int[] secondArray)
            {
                if (firstArray?.Length is 0 || secondArray?.Length is 0)
                {
                    return new int[0];
                }

                if (firstArray?.Length != secondArray?.Length)
                {
                    return new int[0];
                }

                int[] result = new int[firstArray.Length];

                for (int i = 0; i < firstArray.Length; i++)
                {
                    result[i] = firstArray[i] + secondArray[i];
                }

                return result;
            };

            int[] newArray = adition(helper.SubArray(0, helper.Array.Length, ArraySort.Unsorted),
                helper.SubArray(0, helper.Array.Length, ArraySort.Unsorted));

            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
