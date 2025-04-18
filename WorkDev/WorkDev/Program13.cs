using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Program13
    {
        public string reverseTheString(string inputStr)
        {
            string outStr = string.Empty;
            for (int i = inputStr.Length-1; i >= 0; i--)
            {
                outStr += inputStr[i];
            }

            return outStr;
        }
    }
}
