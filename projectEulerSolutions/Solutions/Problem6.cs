using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions
{
    /// <summary>
    /// Solution to Problem 6 on Project Euler. The problem is defined below: 
    ///
    /// "The sum of the squares of the first ten natural numbers is, 1^2 + 2^2+...+10^2 = 385.
    /// 
    ///  The square of the sum of the first ten natural numbers is, (1+2+...+10)^2 = 55^2 = 3025.
    ///  
    ///  Hence the difference betwen the sum of the squares of the first ten natural numbers and the square of the 
    ///  sum is 3025 - 385 = 2640. Find the difference between the sum of the squares of the first one hundred 
    ///  natural numbers and the square of the sum. "
    /// 
    ///
    /// </summary>
    static class Problem6
    {
        public static void Solve()
        {
            int squareSum = 0;
            int sumSquare = 0;
            for (int i = 1; i <= 100; i++)
            {
                squareSum += i;
                sumSquare += i*i; 
            }
            Console.WriteLine( squareSum * squareSum - sumSquare);

        }

        public static void golfSolve()
        {

        }
    }
}
