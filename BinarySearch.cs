using System;
namespace Algoritmes
{
    public static class BinarySearch
    {
        public static (bool, int) Do<T>(T[] sorted_values, int value, bool descending = false) where T : IComparable
        {
            int left = 0;
            for (int right = sorted_values.Length, middle; left < right;)
            {
                if (sorted_values[left].CompareTo(value) == 0)
                    return (true, left);
                middle = left + (right - left) / 2;
                var c = sorted_values[middle].CompareTo(value);
                if (c == 0)
                {
                    if (middle == left + 1)
                        return (true, middle);
                    right = middle + 1;
                }
                if ((c < 0) == descending)
                    right = middle;
                else
                    left = middle + 1;
            }
            return (false, left);
        }

    }
}
