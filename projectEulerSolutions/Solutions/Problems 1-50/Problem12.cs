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

            //for (int i = 1; i <= 12375; i++)
            //{
            //    //Console.Write(nthTriangular(i) + "> ");
            //    Console.WriteLine(findNumberOfDivisors(nthTriangular(i)));
            //}
        }

        private static double nthTriangular(int n) => 0.5 * n * (n + 1);

        private static int findNumberOfDivisors(double n)
        {
            int tot = 1; 
            for (int i = 1; i <= Math.Sqrt(n)+1; i++)
            {
                if (n % i == 0)
                {
                    tot++;
                }
            }
            return tot; 
        }
    }
}
