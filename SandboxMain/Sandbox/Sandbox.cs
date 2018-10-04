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
            int[] myArray = new int[] { 4, 2, 1, 3 };
            QuickSort.QuickSort.SortQuick(myArray, 0, myArray.Length - 1);
            Console.ReadLine();
        }
    }
}
