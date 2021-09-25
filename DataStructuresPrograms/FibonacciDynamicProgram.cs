using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPrograms
{
    class FibonacciDynamicProgram
    {

        public static Dictionary<int, int> cache = new Dictionary<int, int>();

        public static int FIBDP(int n)
        {
            if (n < 2)
            {
                return n;
            }

            if (cache.ContainsKey(n))
            {
                return cache[n];
            }
            else
            {
                cache.Add(n, FIBDP(n - 2) + FIBDP(n - 1));
            }

            return cache[n];
        }

    }
}
