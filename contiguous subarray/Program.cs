using System;
using System.Collections.Generic;
using System.Linq;

namespace contiguous_subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 4, 6, 7 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] output = getLargestCommonSubArray(arr1, arr2);
            foreach (int n in output)
            {
                Console.WriteLine(n);
            }
        }
        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
     
            List<int> common = new List<int>();
            
            Array.Sort(a);
            Array.Sort(b);
            
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        common.Add(a[i]);
                    }
                }
            }
            
            HashSet<int> hs = new HashSet<int>();
            
            foreach (int n in common)
            {
                hs.Add(n);
            }
            
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            
            foreach (int y in hs)
            {
                int m = y;
                  int sum = 0;
                 List<int> digits = new List<int>();
                 if (!hs.Contains(m - 1))
                while (hs.Contains(m))
                    {
                         sum = sum + m;
                         digits.Add(m);
                         m++;
                    }
         if (!map.ContainsKey(sum))
                {
                 map.Add(sum, digits);
                }
            }
            
            int max_sum = map.Keys.Max();
            List<int> final_list = map[max_sum];
            return final_list.ToArray();
        }
    }
}
