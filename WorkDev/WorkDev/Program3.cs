using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    public class Program3
    {


        /// <summary>
        /// Number of Sub-arrays With Odd Sum
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int NumOfSubarrays(int[] arr)
        {
            int mod = (int)(1e9 + 7);
            int ans = 0;
            int pfSum = 0;
            int oddSum = 0;
            int evenSum = 1;

            foreach (int num in arr)
            {
                pfSum += num;
                if ((pfSum & 1) == 0)
                {
                    evenSum++;
                    ans += oddSum;
                }
                else
                {
                    oddSum++;
                    ans += evenSum;
                }
                ans %= mod;
            }

            return ans;
        }
    }
}
