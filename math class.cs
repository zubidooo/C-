using System;

namespace math
{
    class program
    {
        static void Main(string[] args)
    {

        double x = 3;
        double y = 5;
//          to the power of___
        double a = Math.Pow(x, 3);

//          square root of___

     double b = Math.Sqrt(x);

//            absolute value of___

      double c = Math.Abs(x);

//            ungefär till ___

      double d = Math.Round(x);

//            ungefär uppåt till ___

      double e = Math.Ceiling(x);

//          ungefär nedåt till ___

      double f = Math.Floor(x);
 
//          finds the maximum between two numbers

      double g = Math.Max(x, y);

//          finds the minimum between two numbers

      double h = Math.Min(x, y);

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(h);

        Console.ReadKey();
        }
    }
}