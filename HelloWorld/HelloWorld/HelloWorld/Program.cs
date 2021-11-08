using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Jak se jmenuješ?");
            //string name = Console.ReadLine();

            //Hello(name);


            Console.WriteLine("Zadej teplotu ve st. F.: ");
            //string num = Console.ReadLine();

            //int x = int.Parse(Console.ReadLine());

            //int y = Calc(x);


            double f = double.Parse(Console.ReadLine());
            double c = Temper(f); 

            //Console.WriteLine("Výsledek je: " + Calc(x));
            Console.WriteLine("Výsledek je: " + Temper(f));

        }


        static int Calc(int x)
        {
            // vytvorte metodu ktera vstup vynasoby 2
            // a pricte  10

            int result = x * 2 + 10;

            return result;

        }

        static double Temper(double f)
        {
            return (f - 32) / 1.8;
        }

            static void Hello(string name)
        {
            string name5p = name;

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
            string pozdrav = "Ahoj " + name5p + "!";
            Console.WriteLine(pozdrav);
        }
    }
}
