using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions
{
    /// <summary>
    /// Solution to Problem 6 on Project Euler. The problem is defined below: 
    ///
    /// "2520 is the smallest number that can be divided by each of numbers from 1 to 10 without any remainder.
    ///  What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20"
    /// 
    /// </summary>
    static class Problem5
    {
        public static void Solve()
        {
            int n = 2; 
            while(checkDivisible(n) == false)
            {
                bool valid = checkDivisible(n);
                n++;
            }
            Console.WriteLine(n); 
        }

        private static bool checkDivisible(int n)
        {
            for(int i = 2; i <= 20; i++)
            {
                if (n % i != 0)
                {
                    return false; 
                }
            }
            return true; 
        }
    }
}
