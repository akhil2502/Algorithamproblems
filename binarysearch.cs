using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BinarySearchWord<T> where T : IComparable
    {
        T[] array;
        public BinarySearchWord(T[] array)
        {
            this.array = array;
            Array.Sort(this.array);
        }
        public int BinarySearch(T[] array, T element)
        {
            int min = 0, max = array.Length - 1;
            if (min <= max)
            {
                int mid = (min + max) / 2;
                int key = element.CompareTo(array[mid]);
                if (key == 0)
                    return mid;
                if (key > 0)
                    min = mid + 1;
                
                else 
                    max = mid - 1;
                
            }
            return -1;
        }
    }
}