﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Problem");

            // UC1-LineOfLength

            Console.WriteLine("Enter the value of x1 and y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2 and y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt((x2 - x1) ^ +(y2 - y1) ^ 2);
            Console.WriteLine("Line of length is: " + length);

            Console.WriteLine("Enter the value of x3 and y3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x4 and y4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());

            double line2 = Math.Sqrt((x3 - y3) ^ 2 + (x4 - y4) ^ 2);
            Console.WriteLine("Line of length is: " + line2);


            if (length.Equals(line2))
            {
                Console.WriteLine("Both line length are equal");
            }
            else
            {
                Console.WriteLine("Line length are not equal");
            }
        }
    }
}
