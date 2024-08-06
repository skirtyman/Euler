using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions.Problems_1_50
{
    static class Problem14
    {
        public static void Solve()
        {
            int limit = 1000000;
            int longest = 0;
            int start = 0;
            for (int i = limit / 2; i <= limit; i++)
            {
                int length = collatzSequence(i).Item2.Length;
                if (length > longest)
                {
                    longest = length;
                    start = i;
                }
            }
            Console.WriteLine(start);
        }

        // Computes the next step in the collatz chain given a starting number n. 
        private static long oneStep(long n) => n % 2 == 0 ? n / 2 : n + (n << 1) + 1;

        private static long base2ChainLength(long n)
        {
            return (long)Math.Log(n, 2);
        }

        //Computes the collatz sequence given a starting point n.  
        private static (int, long[]) collatzSequence(long n)
        {
            long tmp = n;
            long next;
            List<long> chain = new List<long>();
            chain.Add(tmp);
            while (tmp > 1)
            {
                next = oneStep(tmp);
                chain.Add(next);
                tmp = next;
            }
            return (chain.Count, chain.ToArray());
        }

    }
}
