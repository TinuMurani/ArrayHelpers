using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelpersLibrary
{
    public class SearchResult<T>
    {
        public bool IsValid { get; }
        public T Element { get; }

        public SearchResult(bool isValid, T element)
        {
            this.IsValid = IsValid;
            this.Element = element;
        }
    }
}
