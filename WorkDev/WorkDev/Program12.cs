using System;

namespace WorkDev
{
    public class Program12
    {
        /// <summary>
        /// Longest Palindromic Substring
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome(string s)
        {
            if (s.Length <= 1)
                return s;

            int maxLen = 1;
            string maxStr = s.Substring(0, 1);

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + maxLen; j <= s.Length; j++)
                {
                    string subStr = s.Substring(i, j - i); // FIX: j - i is the correct length
                    if (j - i > maxLen && IsPalindrome(subStr))
                    {
                        maxLen = j - i;
                        maxStr = subStr;
                    }
                }
            }

            return maxStr;
        }

        /// <summary>
        /// To check if a string is a palindrome
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
