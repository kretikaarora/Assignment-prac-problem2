using System;

namespace lines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");


            Console.WriteLine("enter x and y coordinates of point 1 ");
            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter x and y coordinates of point 2");
            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2= Convert.ToDouble(Console.ReadLine());

            double X = X1 - X2;
            double Y = Y1 - Y2;
            double multi = X * X + Y * Y;
            double rad = Math.Round(Math.Sqrt(multi), 3, MidpointRounding.AwayFromZero);

            Console.WriteLine("The lenth of line segment: {0}", rad);


        }
    }
}
