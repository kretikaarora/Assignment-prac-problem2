using System;

namespace lines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");


            Console.WriteLine("enter x and y coordinates of point 1 (line 1) ");
            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter x and y coordinates of point 2 (line1)");
            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2= Convert.ToDouble(Console.ReadLine());

            double X = X1 - X2;
            double Y = Y1 - Y2;
            double multiplication1 = X * X + Y * Y;
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

            if (LengthOfLine1==lengthOfLine2)
            {
                Console.WriteLine("Lines have equal lenth");

            }
            else
            {
                Console.WriteLine("lines are not equal");
            }


        }
    }
}
