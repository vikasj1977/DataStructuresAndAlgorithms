using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPrograms
{
    class FactorialRecursive
    {
        
        //public static int FindFactorialRecursive(int FactNum)
        //{
        //    var intFact = FactNum;
        //    if (intFact == 0)
        //    {
        //        return intFact;
        //    }
        //    intFact = FaindFactorialRecursive(FctNum * (FactNum - 1);
        //    FactNum - 1);
        //    return intFact;
        //} 

        public static int FindFactorialRecursive1(int FactNum)
        {
            if (FactNum == 1)
            {
                return FactNum;
            }

            var answer = FactNum * FindFactorialRecursive1(FactNum - 1);
            return answer;
        }
    }
}
