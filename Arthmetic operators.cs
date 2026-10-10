using System;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            double friends = 10;

          //  hard way  friends = friends + 2;

          //  friends += 2; easy way
          //  friends++; only adds 1 to the variable

          //  friends = friends - 1;
          //  friends -= 1;
          //  friends--;

          // friends = friends * 2;
          // friends *= 2;
          
          
        // friends = friends / 2;
        // friends /= 2;

        double remainder = friends % 3; //gives you the remainder of a division


        Console.WriteLine(remainder);

             
        Console.WriteLine(friends);

            Console.ReadKey();
        }
    }
}