/*

//Shows that im using the system librarys

using System;

//This gives it a namespace (i think its opptional tho)

namespace FirstProject
{

//Gives it a class

    class Program
    {

        //Every C# needs a main method to run

        static void Main(string[] args)
        {

            // Tells it to print Hello World in the terminal

            Console.WriteLine("Hello, World");
        }
    }
}


// This is the easier way

Console.WriteLine("Hello, World");



using System;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I like to code in C#");
            Console.WriteLine("it is a fun language to learn");
            Console.WriteLine("I am going to learn C#");
            Console.Beep();
        }
    }
}





using System;

namespace ThirdProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.ReadKey();
        }
    }
}

*/

using System;

namespace FourthProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
         int x;   //declaration
         x = 123;   //initialization

         int y = 321;  //declaration and initialization

         double z = 3.14;  //lets you have decimal numbers

         bool isCSharpFun = true;  // true or false

         char myGrade = 'A';  //single character

         string myName = "Zubeir";  //string of characters


            Console.WriteLine("Hello" + myName + "");

            Console.ReadKey();
        }
    }
}