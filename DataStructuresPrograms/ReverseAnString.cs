using System;
using System.Text;
using System.Collections.Generic;
using DataStructuresPrograms;

namespace DataStructuresPrograms
{
    public class ReverseAnString
    {
        public static string ReverseAString(string str)
        {
            var strBuilder = new StringBuilder();
            //var strOut = "";
            for (var i=str.Length - 1; i>=0; i--)
            {
                //strOut += str[i];
                strBuilder.Append(str[i]);
            }

            return strBuilder.ToString();
        }

        static void Main(string[] args)
        {

            var str = "pwwkew";

            var max = LongestSubString.LengthOfLongestSubstring(str);


            //var arr = new string[] {"flower","flow","flight" };

            //var str = LongestCommonPrefix.LongestCommonPrefix1(arr);

            //Console.WriteLine(str);
            //Console.ReadLine();

            //var FibDP = FibonacciDynamicProgram.FIBDP(34);

            //Console.WriteLine(FibDP);
            //Console.ReadLine();

            //var FibNum = FibonacciResursive.ReverseStringRecursively("Yash is a good boy");

            //var myArr = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };

            //var sortedArr = new int[myArr.Length];

            //sortedArr = BubbleSort.BubbleSortTest(myArr);

            //foreach(int item in sortedArr)
            //{
            //    Console.Write(" " + item + " ");
            //}
            //Console.ReadLine();

            //var factNum = FactorialRecursive.FindFactorialRecursive1(5);

            //Console.WriteLine("the factorial of 5 is : " + factNum);
            //Console.ReadLine();
            //BST tree = new BST();
            //node root = new node();

            //tree.Insert(4);
            //tree.Insert(2);
            //tree.Insert(5);
            //tree.Insert(1);
            //tree.Insert(3);

            //tree.DisplayTree();

            //var str = "Vikas";

            //LinkedList<string> MyList = new LinkedList<string>();
            //MyList.AddLast("Vikas");
            //MyList.AddLast("Yash");
            //MyList.AddLast("Shubh");
            //MyList.AddLast("Garima");

            //LinkedList.LinkedListTest(MyList);

            //var arr1 = new int[] { 2,1,1,5 };
            //var ObjFirstRecurChar = FirstRecurringChar.ReturnFirstRecurChar(arr1);

            //if (ObjFirstRecurChar == 0)
            //{
            //    Console.WriteLine("First recurring char is: UnDefined ");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("First recurring char is: " + ObjFirstRecurChar);
            //    Console.ReadLine();
            //}

        }
    }
}
