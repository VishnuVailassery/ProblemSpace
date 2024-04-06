using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver.Problems
{
    internal static partial class Solution
    {
        // https://leetcode.com/problems/plus-one/
        public static int[] PlusOne(int[] digits)
        {
            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1]++;
                return digits;
            }

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                    if (i == 0)
                    {
                        Array.Resize(ref digits, digits.Length + 1);
                        digits[i] = 1;
                        digits[digits.Length - 1] = 0;
                    }
                }
                else
                {
                    digits[i]++;
                    break;
                }
            }

            return digits;
        }
    }
}
