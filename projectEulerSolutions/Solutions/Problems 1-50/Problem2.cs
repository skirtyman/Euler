﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions
{
    /// <summary>
    /// Solves Problem 2 on Project Euler. The problem is defined below: 
    /// 
    /// "Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 
    /// 2, the first 10 terms will be: 
    ///         1,2,3,5,8,13,21,34,55,89,...
    /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of 
    /// the even-valued terms. 
    /// </summary>
    static class Problem2
    {
        public static void Solve()
        {
            int a = 1;
            int b = 2;
            int tmp;
            int nextTerm = 0;
            int total = b; 
            while (nextTerm < 4000000)
            {
                nextTerm = a + b;
                if (nextTerm % 2 == 0)
                {
                    total += nextTerm;
                }
                tmp = b; 
                b = nextTerm;
                a = tmp; 
            }
            Console.WriteLine(total);
        }

        public static void golfSolve()
        {

        }
    }
}
