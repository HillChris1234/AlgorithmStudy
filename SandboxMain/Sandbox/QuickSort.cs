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
            if (left >= right) return; // terminate if the left point is higher than the right point.
            int pivot = arr[(left + right) / 2]; // get pivot value
            int index = partition(arr, left, right, pivot); // get partition point
            SortQuick(arr, left, index - 1); // recurse on left side
            SortQuick(arr, index, right); // recurse on right side
        }

        public static int partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right) // move pointers in towards each other
            {
                while (array[left] < pivot) left++; // move left pointer until it hits a number higher than the pivot
                while (array[right] > pivot) right--; // move right pointer until it hits a number lower than the pivot
                if (left <= right) // if the left pointer is less than the right pointer
                {   
                    int t = array[left]; // Swap the numbers
                    array[left] = array[right];
                    array[right] = t;
                    left++; //Move the pointers
                    right--;
                }
            }
            return left; //return partition point.
        }
    }
}
