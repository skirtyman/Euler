using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions.Problems_1_50
{
    class Problem12
    {
        public static void Solve()
        {
            int c = 0;
            while (findNumberOfDivisors(nthTriangular(c)) < 500)
            {
                c++;
                if (c % 1000 == 0)
                {
                    Console.WriteLine(c);
                }
            }
            Console.WriteLine(nthTriangular(c));

        }

        private static int nthTriangular(int n) => (int)(0.5 * n * (n + 1));

        private static int findNumberOfDivisors(int n)
        {
            int tot = 0; 
            for (int i = 1; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    tot++;
                    if (i != n / i)
                    {
                        tot++;
                    }
                }
            }
            return tot; 
        }
    }
}
