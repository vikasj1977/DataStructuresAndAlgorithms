using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPrograms
{
    class BubbleSort
    {

        //6 5 3 1 8 7 2 4

        public static int[] BubbleSortTest(int[] arr)
        {
            for (var i=0; i<arr.Length; i++)
            {
                for (var j=0; j<arr.Length-1; j++)
                if (arr[j] > arr[j+1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
            return arr;
        }

    }
}
