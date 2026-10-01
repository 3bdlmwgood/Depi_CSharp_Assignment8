using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment8
{
    public class Range<T> where T : IComparable<T>
    {
        private T _minimum;
        private T _maximum;

        public Range(T minimum, T maximum)
        {
            _minimum = minimum;
            _maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(_minimum) >= 0 && value.CompareTo(_maximum) <= 0;
        }

        public dynamic Length()
        {
            return (dynamic)_maximum - (dynamic)_minimum;
        }

    }
}
