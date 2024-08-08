using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions.Problems_1_50
{
    /// <summary>
    /// The solution to problem 34 on Project Euler. It is defined below: 
    /// 
    /// " 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145. 
    ///   Find the sum of all numbers which are equal to the sym of the factorial of their digits. 
    ///   
    ///   Note: As 1! = 1 and 2! = 2 are not sums they are not included. "
    ///
    /// </summary>
    static class Problem34
    {
        public static void Solve()
        {
            long sum = 0;
            long upper = 7 * fac(9); 
            for (int i = 10; i < upper; i++)
            {
                if (isCurious(i))
                {
                    sum += i; 
                }
            }
            Console.WriteLine(sum);
        }

        private static bool isCurious(long n)
        {
            long tmp = n;
            long sum = 0; 
            while (tmp != 0)
            {
                sum += fac(tmp % 10);
                tmp /= 10; 
            }
            return sum == n; 
        }

        private static long fac(long n)
        {
            long res = 1; 
            while (n > 1)
            {
                res *= n;
                n--;
            }
            return res; 
        }
    }
}
