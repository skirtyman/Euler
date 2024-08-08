using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions.Solutions
{
    /// <summary>
    /// This is my solution to problem 4 as defined on Project Euler, this is defined below: 
    /// 
    /// "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit
    ///  numbers is 9009 = 91 x 99. 
    ///  
    ///  Find the largest palindrome made from the produce of two 3-digit numbers. "
    /// 
    /// </summary>
    static class Problem4
    {
        public static void Solve()
        {
            int largest = 0; 
            for (int i = 999; i >= 0; i--)
            {
                for (int j = 999; j >= 0; j--)
                {
                    if (isPalindromic(i * j) && i * j > largest)
                    {
                        largest = i * j; 
                    }
                }
               
            }
            Console.WriteLine(largest); 
        }

        private static bool isPalindromic(int n)
        {
            string tmp = n.ToString();
            string num = ""; 
            while (n > 0)
            {
                int digit = n % 10; 
                n /= 10;
                num = num + digit;  
            }
            return tmp == num; 
        }

    }
}
