using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPrograms
{
    class FirstRecurringChar
    {

        public static int ReturnFirstRecurChar(int[] arrayInt)
        {

            var intChar = 0;

            var hashTemp = new HashSet<int>();

            for (var i=0; i<arrayInt.Length; i++)
            {
                if (hashTemp.Contains(arrayInt[i]))
                {
                    intChar = arrayInt[i];
                    return intChar;
                }
                else
                {
                    hashTemp.Add(arrayInt[i]);
                }
            }
                        
            return intChar;
        }

    }
}
