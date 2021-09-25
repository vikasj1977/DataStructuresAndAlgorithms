using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPrograms
{
    class FibonacciResursive
    {
        public static int FindFibonacciRecursive(int num)
        {
            Console.WriteLine(num);
            //[0,1,1,2,3,5,8]
            if (num == 0 || num == 1)
                return num;

            return FindFibonacciRecursive(num-1) + FindFibonacciRecursive(num-2);
        }

        public static int FindFibIterative(int InNum)
        {
            var arr = new int[] {0,1 };

            for (var i=2; i< InNum+1; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }

            return arr[InNum];
        }

        public static string ReverseStringRecursively(string str)
         {
            if(str.Length == 0)
            { return ""; }

            return str.Substring(str.Length-1,1) + ReverseStringRecursively(str.Substring(0, str.Length - 1)); ;
        }
    }
}
