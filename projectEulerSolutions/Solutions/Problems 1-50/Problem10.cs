using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions.Problems_1_50
{
    /// <summary>
    /// This is the solution to Problem 10 on Project Euler. The problem is defined below: 
    ///
    /// "The sum of theprimes below 10 is 2 + 3 + 5 + 7 = 17. 
    ///  
    ///  Find the sum of all the primes below two million. "
    ///
    /// </summary>
    class Problem10
    {
        public static void Solve()
        {
            long tot = 0;
            int upper = 2000000;
            bool[] primes = sieve(upper); 
            for (int i = 2; i <= upper; i++)
            {
                if (!primes[i])
                {
                    tot += i;   
                }
            }
            Console.WriteLine(tot); 
        }

        private static bool[] sieve(int n)
        {
            bool[] A = new bool[n+1];
            int sqrt = (int)Math.Sqrt(n);
            for (int i = 2; i <= sqrt; i++)
            {
                if (A[i] == false)
                {
                    for (int j = i*i; j <= n; j += i)
                    {
                        A[j] = true;
                    }
                }
            }
            return A; 
        }

    }
}
