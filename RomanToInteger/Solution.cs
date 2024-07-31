using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int answer = 0;
            int num = 0;
            for (int x = s.Length - 1; x >= 0; x--)
            {
                switch (s[x])
                {
                    case 'I':
                        num = 1;
                        break;

                    case 'V':
                        num = 5;
                        break;

                    case 'X':
                        num = 10;
                        break;

                    case 'L':
                        num = 10;
                        break;

                    case 'C':
                        num = 100;
                        break;

                    case 'D':
                        num = 500;
                        break;

                    case 'M':
                        num = 1000;
                        break;

                       
                }
                if (4 * num < answer)
                {
                    answer -= num;
                }
                else
                {
                    answer += num;
                }
            }
            return answer;
        }
    }
}
