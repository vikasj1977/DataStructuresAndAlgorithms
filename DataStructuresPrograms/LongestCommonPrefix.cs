using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPrograms
{
    class LongestCommonPrefix
    {
        public static string LongestCommonPrefix1(string[] strs)
        {

            if (strs.Length == 0) { return ""; }

            String prefix = strs[0];

            for (var i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0) return "";
                }
            }
            return prefix;
        }
    }
}
