using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Universe!");

            string name = "Xaver";
            string zvolani = "Hello";
            string pozdrav = zvolani + ", " + name + "!";
            Console.WriteLine(pozdrav);


            Console.WriteLine();

            Console.WriteLine("Jak se jmenuješ?");
            string name2 = Console.ReadLine();
            string pozdrav2 = zvolani + ", " + name2 + "!";
            Console.WriteLine(pozdrav2);

            Console.WriteLine();



        }
    }
}
