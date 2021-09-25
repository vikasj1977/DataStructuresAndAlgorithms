using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace DataStructuresPrograms
{
    class LongestSubString
    {
        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            int length = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (letters.TryGetValue(s[i], out int index))
                {
                    length = Math.Max(length, letters.Count);
                    i = index;
                    letters.Clear();
                }
                else
                {
                    letters.Add(s[i], i);
                }
            }
            length = Math.Max(length, letters.Count);
            return length;
        }
        //public static int LengthOfLongestSubstring(string s)
        //{
        //    Dictionary<char, int> prevAppearance = new Dictionary<char, int>();
        //    int maxSubstringLength = 0;
        //    int prevNonRepeatingSubstringStartIndex = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (prevAppearance.Keys.Contains(s[i]))
        //        {
        //            prevNonRepeatingSubstringStartIndex =
        //                Math.Max(prevAppearance[s[i]] + 1, prevNonRepeatingSubstringStartIndex);
        //        }
        //        maxSubstringLength =
        //            Math.Max(maxSubstringLength, i - prevNonRepeatingSubstringStartIndex + 1);
        //        prevAppearance[s[i]] = i;
        //    }

        //    return maxSubstringLength;
        //}

        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            var hashSet = new Hashtable();

            var set = new HashSet<char>();
            int left = 0;
            set.Add(s[0]);
            int max = 1;

            for(int i = 1; i < s.Length; i++)
            {
                while(set.Contains(s[i])) {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(s[i]);
                max = Math.Max(max, set.Count);
            }
            return max;
        }

    }
}
