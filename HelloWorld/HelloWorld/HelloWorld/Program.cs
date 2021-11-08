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

            Console.WriteLine("Jak se jmenuješ?");
            string name3 = Console.ReadLine();
            string name5p = name3;

            if (name == "Xaver")
            {
                name5p = "Xavere";
            }
            else if (name == "Iva")
            {
                name5p = "Ivo";
            }
            else if (name == "Petr")
            {
                name5p = "Petře";
            }
            else
            {
                name5p = name5p + ", promň, ale tvé jméno neumím skloňovat";
            }
            string pozdrav3 = "Ahoj " + name5p + "!";
            Console.WriteLine(pozdrav3);


        }
    }
}
