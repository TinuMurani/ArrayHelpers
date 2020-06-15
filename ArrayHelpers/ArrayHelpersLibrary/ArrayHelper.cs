using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ArrayHelpersLibrary
{
    public class ArrayHelper<T> : IEquatable<T>
    {
        public int[,] Array { get; }
        
        public ArrayHelper(int[,] array)
        {
            this.Array = array ?? new int[0, 0];
        }

        public List<Tuple<int, int>> ElementPosition(int element)
        {
            int row = Array.GetLength(0);
            int column = Array.GetLength(1);

            List<Tuple<int, int>> elementPositionList = new List<Tuple<int, int>>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (Array[i, j].Equals(element))
                    {
                        elementPositionList.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            return elementPositionList;
        }

        public string IndexOf(int element)
        {
            int rows = Array.GetLength(0);
            int cols = Array.GetLength(1);

            string result = "";

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[i, j] == element)
                    {
                        result = $"Element is at index: [{ i }, { j }]";
                    }
                    else
                    {
                        result = "-1";
                    }
                }
            }

            return result;
        }

        public bool Equals(T element)
        {
            int row = Array.GetLength(0);
            int column = Array.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (Array[i, j].Equals(element))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
