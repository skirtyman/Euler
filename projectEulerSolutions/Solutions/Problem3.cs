using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions
{
    /// <summary>
    /// Solution to Problem 3 on Project Euler. The problem is defined below: 
    ///
    /// "The prime factors of 13195 are 5, 7, 13, 29. What is the largest factor of the number 600851475143. 
    /// 
    ///
    /// </summary>
    static class Problem3
    {
        public static void Solve()
        {
            long num = 600851475143;
            int largestPrime = 0; 
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    if (i > largestPrime)
                    {
                        largestPrime = i;
                    }
                    num /= i; 
                }
            }
            Console.WriteLine(largestPrime);   
        }

        public static void golfSolve()
        {

        }
    }
}
