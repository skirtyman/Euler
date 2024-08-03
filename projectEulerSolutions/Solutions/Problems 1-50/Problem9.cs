using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions.Problems_1_50
{
    /// <summary>
    /// Solution to Problem 9 on Project Euler. The problem is defined below: 
    ///
    /// "A pythagorean triplet is a set of three natural numbers, a<b<, for which, a^2 + b^2 = c^2.
    ///  For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2. There exists exactly one Pythagorean triplet for 
    ///  which a+b+c=1000. Find the product of abc."
    /// 
    /// </summary>
    static class Problem9
    {
        static Random rng = new Random();   

        public static void Solve()
        {
            (int, int) seed;
            int msquared;
            int nsquared; 
            int[] triple = { 0, 0, 0 };

            while (triple.Sum() != 1000)
            {
                seed = GenerateSeeds();
                msquared = seed.Item1 * seed.Item1;
                nsquared = seed.Item2 * seed.Item2;
                triple = new int[] { 2 * seed.Item1 * seed.Item2, msquared - nsquared, msquared + nsquared };
            }

            Console.WriteLine(Product(triple)); 
        }
        
        private static int Product(int[] triple)
        {
            return triple[0] * triple[1] * triple[2];   
        }

        private static (int, int) GenerateSeeds()
        {
            int m = 1; 
            int n = 1;  
            while (m * (m + n) != 500 && m <= n)
            {
                m = rng.Next(100); 
                n = rng.Next(100);
            }

            return (n > m) ? (n, m) : (m, n);
        }
    }
}
