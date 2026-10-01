using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment8
{
    public class FixedSizeList<T>
    {
        private T[] _items;
        private int _count;
        public FixedSizeList(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Size must be greater than zero.");
            }
            _items = new T[size];
            _count = 0;
        }
        public void Add(T item)
        {
            if (_count >= _items.Length)
            {
                throw new InvalidOperationException("List is full.");
            }
            _items[_count] = item;
            _count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
            return _items[index];
        }

    }
}
