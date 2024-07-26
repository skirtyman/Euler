using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions
{

    /// <summary>
    /// Solves Problem 1 on Project Euler. The problem is defined below: 
    /// 
    /// Problem 1: "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    ///             The sum of these multiples is 23. 
    ///             
    ///             Find the sum of all the mutiples of 3 or 5 below 1000."
    /// </summary>
    static class Problem1
    {
        public static void Solve()
        {
            int total = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }


        // Trying to code golf this, I am very close, but do not know how to compact the ouput.
        public static void golfSolve(int total = 0, int i = 0)
        {
            if (i < 1000)
            {
                golfSolve(total + ((i % 3 < 1 | i % 5 < 1) ? i : 0), i + 1);
            }
            else
            {
                Console.WriteLine(total);
            }
        }
    }
}
