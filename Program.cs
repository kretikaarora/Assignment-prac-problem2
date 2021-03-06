﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace lines
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            double lengthOfLine1 = LengthofLine();
            Console.WriteLine("length of line 1 is {0}", lengthOfLine1);
            Console.WriteLine("enter the points of another line");
            double lengthOfLine2 = LengthofLine();
            Console.WriteLine("length of line 1 is {0}", lengthOfLine2);
            double LengthofLine()
            {
                Console.WriteLine("enter x and y coordinates of point 1");
                double X1 = Convert.ToDouble(Console.ReadLine());
                double Y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter x and y coordinates of point 2");
                double X2 = Convert.ToDouble(Console.ReadLine());
                double Y2 = Convert.ToDouble(Console.ReadLine());
                double X = X1 - X2;
                double Y = Y1 - Y2;
                double multiplication1 = X * X + Y * Y;
                return Math.Round(Math.Sqrt(multiplication1), 3, MidpointRounding.AwayFromZero);
            }

            double comparator = lengthOfLine1.CompareTo(lengthOfLine2);
            if (comparator == 1)
            {
                Console.WriteLine("Line 1 is greater in length than line 2");
            }
            else if (comparator == -1)
            {
                Console.WriteLine("Line 2 is greater in length than line1");
            }
            else
            {
                Console.WriteLine(" The length of both the lines are equal");
            }

        }
    }
}
