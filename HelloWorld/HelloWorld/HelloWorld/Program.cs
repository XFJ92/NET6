using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak se jmenuješ?");
            string name3 = Console.ReadLine();

            Hello(name3);
        }

        static void Hello(string name3)
        {
            string name5p = name3;

            if (name3 == "Xaver")
            {
                name5p = "Xavere";
            }
            else if (name3 == "Iva")
            {
                name5p = "Ivo";
            }
            else if (name3 == "Petr")
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
