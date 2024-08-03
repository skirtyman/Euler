using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions
{
    /// <summary>
    /// Solution to Problem 7 on Project Euler. The problem is defined below: 
    ///
    /// "By listing the first sixe prime numbers: 2, 3, 5, 7, 11 and 13, we can see that the 6th prime is 13. 
    ///  What is the 10001st prime number? "
    /// 
    ///
    /// </summary>
    static class Problem7
    {
        public static void Solve()
        {
            int primesFound = 0;
            int start = 1;
            while (primesFound != 10002)
            {
                bool isPrime = H(start);
                if (isPrime)
                {
                    primesFound++;
                }
                start++;
            }
            Console.WriteLine(start - 1);
        }

        public static bool H(int n, int i = 2) => (n == 2 || n % i != 0) && (i * i > n || H(n, i + 1));

        //public static void Solve()
        //{
        //    int primesFound = 0;
        //    int start = 2;
        //    for (; primesFound < 10001; start++) if (H(start)) primesFound++;
        //    Console.WriteLine(start - 1);
        //}

        public static void golfSolve(){bool H(int n,int i=2)=>(n==2||n%i!=0)&&(i*i>n||H(n,i+1));int p=0,s=0;while(p<10002)if(H(s++))p++;Console.Write(s-1);}
    }
}
