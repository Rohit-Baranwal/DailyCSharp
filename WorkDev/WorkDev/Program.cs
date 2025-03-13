using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Program
    {
        static void Main()
        {
            #region Find Missing and Repeated Values
            //Program1 p1 = new Program1();
            //int[][] grid = { new int[] { 1, 3 }, new int[] { 2, 2 } };

            //int[] ans = p1.FindMissingAndRepeatedValues(grid);

            //foreach (int item in ans)
            //{
            //    Console.Write(item + "  ");
            //}
            //Console.WriteLine();
            #endregion

            #region Closest Prime Numbers in Range
            //Program2 p2 = new Program2();
            //int left = 10, right = 19;
            //int[] ans1 = p2.ClosestPrimes(left, right);

            //foreach (int item in ans1)
            //{
            //    Console.Write(item + "  ");
            //}
            //Console.WriteLine();
            #endregion

            #region Number of Sub-arrays With Odd Sum
            //Program3 p3 = new Program3();
            //int[] arr = new int[] { 1, 3, 5 };

            //Console.WriteLine(p3.NumOfSubarrays(arr));

            //Console.WriteLine();
            #endregion

            #region Minimum Recolors to Get K Consecutive Black Blocks
            //Program4 p4 = new Program4();
            //string blocks = "WBBWWBBWBW";
            //int k = 7;
            //Console.WriteLine(p4.MinimumRecolors(blocks, k));
            //Console.WriteLine();
            #endregion

            #region Alternating Groups II
            //Program5 p5 = new Program5();
            //int[] colors = { 0, 1, 0, 1, 0 };
            //int k1 = 3;
            //Console.WriteLine(p5.NumberOfAlternatingGroups(colors, k1));
            //Console.WriteLine();
            #endregion

            #region Count of Substrings Containing Every Vowel and K Consonants II

            //Program6 p6 = new Program6();
            //string word = "aeiou";
            //int k3 = 0;
            //Console.WriteLine(p6.CountOfSubstrings(word, k3) + Environment.NewLine);
            #endregion

            #region Number of Substrings Containing All Three Characters

            //Program7 pr7 = new Program7();
            //string input = "abcabc";
            //Console.WriteLine(pr7.NumberOfSubstrings(input));

            #endregion

            #region Partition Array According to Given Pivot

            //Program8 pr8 = new Program8();
            //int[] nums = { 9, 12, 5, 10, 14, 3, 10 };
            //int pivot = 10;
            //int[] result = pr8.PivotArray(nums, pivot);
            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region Maximum Count of Positive Integer and Negative Integer

            //Program9 pr9 = new Program9();
            //int[] nums = { -2, -1, -1, 1, 2, 3 };
            //Console.WriteLine(pr9.MaximumCount(nums));

            #endregion

            #region Zero Array Transformation II

            Program10 pr10 = new Program10();
            int[] nums = {2,0,2};
            int[][] queries = { new int[] { 0, 2, 1 }, new int[]{ 0, 2, 1 }, new int[]{ 1, 1, 3 } };
            Console.WriteLine(pr10.MinZeroArray(nums, queries));


            #endregion

            Console.Read();
        }
    }
}
