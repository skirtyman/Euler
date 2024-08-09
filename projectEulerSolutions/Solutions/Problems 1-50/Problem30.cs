using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions.Problems_1_50
{
    static class Problem30
    {
        public static void Solve()
        {
            int res = 0;
            for (int i = 2; i < 10000000; i++)
            {
                if (isFifth(i)) res += i;
            }
            Console.WriteLine(res);
        }

        private static bool isFifth(int n)
        {
            int tmp = n; 
            int sum = 0; 
            while (n > 0)
            {
                sum += (int)Math.Pow(n % 10, 5);
                n /= 10;
            }
            return sum == tmp; 
        }
    }
}
