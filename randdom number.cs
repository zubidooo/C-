using System;

namespace random_number
{
    class program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();

            random.Next(1, 100);


            Console.WriteLine(random.Next(1, 100));
            Console.ReadKey();
        }
    }
}