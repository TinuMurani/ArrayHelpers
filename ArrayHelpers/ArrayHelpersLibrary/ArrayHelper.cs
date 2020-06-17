using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ArrayHelpersLibrary
{
    public class ArrayHelper<T> : IEquatable<T>
    {
        public T[,] Array { get; }
        
        public ArrayHelper(T[,] array)
        {
            this.Array = array ?? new T[0, 0];
        }

        /// <summary>
        /// Returns all the occurences of the searched element of the Array property
        /// contained in the ArrayHelper class
        /// </summary>
        /// <param name="value">The value needed to be retrieved</param>
        /// <returns>Returns the result as a string value of every occurence or returns '-1' in case there are no results.</returns>
        public string IndexOf(T value)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[i, j].Equals(value))
                    {
                        result.Append($"[{ i },{ j }],");
                    }
                }
            }

            if (result.Length > 2)
            {
                result.Remove(result.Length - 1, 1);
            }

            if (string.IsNullOrEmpty(result.ToString()))
            {
                result.Clear();
                result.Append("-1");
            }

            return result.ToString();
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

        public SearchResult<T> ElementAt(int row, int column)
        {
            if ((row < 0 || column < 0) || (row >= this.Array.GetLength(0) || column >= this.Array.GetLength(1)))
            {
                return new SearchResult<T>(false, default);
            }

            return new SearchResult<T>(true, this.Array[row, column]);
        }

        public T[] SubArray(int fromPosition, int numberOfElements, ArraySort order = ArraySort.Unsorted)
        {
            if (fromPosition < 0 || fromPosition >= this.Array.Length || numberOfElements <= 0)
            {
                return new T[0];
            }

            int index = 0;
            T[] singleArray = new T[this.Array.GetLength(0) * this.Array.GetLength(1)];

            for (int i = 0; i < this.Array.GetLength(0); i++)
            {
                for (int j = 0; j < this.Array.GetLength(1); j++)
                {
                    singleArray[index] = this.Array[i, j];
                    index++;
                }
            }

            if (fromPosition + numberOfElements > singleArray.Length)
            {
                T[] result = new T[singleArray.Length - fromPosition];

                for (int i = fromPosition, j = 0; i < singleArray.Length; i++, j++)
                {
                    result[j] = singleArray[i];
                }

                return result;
            }

            T[] single = new T[numberOfElements];

            for (int i = fromPosition, j = 0; i < singleArray.Length && j < numberOfElements; i++, j++)
            {
                single[j] = singleArray[i];
            }

            return single;
        }
    }
}
