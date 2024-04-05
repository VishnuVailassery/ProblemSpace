namespace ProblemSolver.Problems
{
    internal static partial class Solution
    {
        //https://leetcode.com/problems/power-of-three/
        public static bool IsPowerOfThree(int n)
        {
            if (n == 0)
            {
                return false;
            }

            while (n != 1)
            {
                if (n % 3 != 0)
                {
                    return false;
                }

                n = n / 3;
            }

            return true;
        }
    }
}
