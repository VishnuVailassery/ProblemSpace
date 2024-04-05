using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver.Problems
{
    internal partial class Problem
    {
        //https://leetcode.com/problems/move-zeroes/description/
        public static void MoveZeroes(int[] nums)
        {
            var zCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zCount++;
                }
                else
                {
                    nums[i - zCount] = nums[i];
                }
            }

            for (int j = 0; j < zCount; j++)
            {
                nums[nums.Length - 1 - j] = 0;
            }
        }
    }
}
