using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 2, 8, 3, 5, 4, 9, 6 };
            myArray = QuickSort(myArray, 0, myArray.Length - 1);
            Console.ReadLine();
        }
        
        static int[] QuickSort(int[] inArray, int left, int right)
        {
            int pivot = (left + right) / 2;
            int l = left, r = right;
            while (l < r)
            {
                while (inArray[l] < inArray[pivot])
                {
                    l++;
                }
                while (inArray[r] > inArray[pivot])
                {
                    r--;
                }
                if (l < r)
                {
                    inArray[l] = inArray[l] + inArray[r];
                    inArray[r] = inArray[l] - inArray[r];
                    inArray[l] = inArray[l] - inArray[r];
                    l++;
                    r--;
                }
            }
            if (left < pivot)
            {
                QuickSort(inArray, left, pivot);
                QuickSort(inArray, pivot, right);
            }
            return inArray;
        }

        static int[] SwapArray(int[] inArray, int a, int b)
        {   
            inArray[a] = inArray[a] + inArray[b];
            inArray[b] = inArray[a] - inArray[b];
            inArray[a] = inArray[a] - inArray[b];

            return inArray;
        }
    }
}
