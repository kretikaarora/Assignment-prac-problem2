using System;
using System.Security.Cryptography.X509Certificates;

namespace lines
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
<<<<<<< HEAD
            double lengthOfLine1 = LengthofLine();
            Console.WriteLine("length of line 1 is {0}", lengthOfLine1);
            Console.WriteLine("enter the points of another line");
            double lengthOfLine2 = LengthofLine();
            Console.WriteLine("length of line 1 is {0}", lengthOfLine2);
            double LengthofLine()
=======


            Console.WriteLine("enter x and y coordinates of point 1 (line 1) ");
            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter x and y coordinates of point 2 (line1)");
            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2= Convert.ToDouble(Console.ReadLine());

            double X = X1 - X2;
            double Y = Y1 - Y2;
            double multiplication1 = X * X + Y * Y;

            double lengthOfLine1 = Math.Round(Math.Sqrt(multiplication1), 3, MidpointRounding.AwayFromZero);

            //uc2

            Console.WriteLine("The lenth of line segment 1: {0}", lengthOfLine1) ;

            double LengthOfLine1 = Math.Round(Math.Sqrt(multiplication1), 3, MidpointRounding.AwayFromZero);

            Console.WriteLine("The lenth of line segment: {0}", LengthOfLine1);


            Console.WriteLine("enter x and y coordinates of point 1 (line 2) ");
            double X3 = Convert.ToDouble(Console.ReadLine());
            double Y4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter x and y coordinates of point 2 (line2)");
            double X5 = Convert.ToDouble(Console.ReadLine());
            double Y6 = Convert.ToDouble(Console.ReadLine());

            double T = X3 - X5;
            double Z = Y4 - Y6;
            double multiplication2 = T * T + Z * Z;
            double lengthOfLine2 = Math.Round(Math.Sqrt(multiplication2), 3, MidpointRounding.AwayFromZero);

            Console.WriteLine("The lenth of line segment 2: {0}", lengthOfLine2);


            if (lengthOfLine1==lengthOfLine2)


            if (LengthOfLine1==lengthOfLine2)

>>>>>>> 56df3c037cfa3e380adc7f12bece02a7667ba8ae
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
<<<<<<< HEAD
=======
            else
            {
                Console.WriteLine("lines are not equal");
            }



            //uc3
>>>>>>> 56df3c037cfa3e380adc7f12bece02a7667ba8ae

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
<<<<<<< HEAD
=======
    


>>>>>>> 56df3c037cfa3e380adc7f12bece02a7667ba8ae
        }
    }
}
