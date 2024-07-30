using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    public class Solution
    {
        public bool IsPolindrom(int x)
        {
            if (x < 0) return false; 

            int original = x; 
            int reversed = 0;

            while (x!=0) 
            {
                int digit = x % 10;
                x/= 10;
                reversed=reversed*10 + digit;
            }
            return reversed == original;
        }
    }
}
