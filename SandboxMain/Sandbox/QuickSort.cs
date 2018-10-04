using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSort
    {
        
        
        static public void SortQuick(int[] arr, int left, int right)
        {
            if (left >= right) return;
            int pivot = arr[(left + right) / 2]; // get pivot value
            int index = partition(arr, left, right, pivot); // get partition point
            SortQuick(arr, left, index - 1); // recurse on left side
            SortQuick(arr, index, right); // recurse on right side
        }

        public static int partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right) // move pointers in towards each other
            {
                while (array[left] < pivot) left++; // move left pointer
                while (array[right] > pivot) right--; // move right pointer
                if (left <= right) // if the left pointer is less than the right pointer
                {   
                    int t = array[left];
                    array[left] = array[right];
                    array[right] = t;
                    left++;
                    right--;
                }
            }
            return left; //return partition point.
        }
    }
}
