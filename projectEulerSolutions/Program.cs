﻿using projectEulerSolutions.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEulerSolutions
{
    internal class Program
    {
        // The following console can be used to gain each of the solutions to the problems on project euler that
        // I have solved. There is also a version that has been code-golfed, which is just for fun. These algorithms 
        // may not be the most efficient method of solving these problems but this is the best way I can come up with. 
        // 
        // You may wish to use these programs to validate your own answers. As all solutions given within the repo have 
        // given valid answers on the Project Euler website. Please for your own sake, use this code to just copy and paste
        // all of the correct answers. You are missing out on the enjoyment of programming. 
        // 
        // Each solution is given as a static class so simply change the static class to the problem number that you want and 
        // run this solution. The answer should be given in the console. The problem has also been defined in the class definition 
        // in case you do not want to look at the website yourself. 
        static void Main(string[] args)
        {
            Problem5.Solve();
            Console.ReadLine();
        }
    }
}