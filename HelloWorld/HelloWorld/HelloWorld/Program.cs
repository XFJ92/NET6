using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            ConvertFtoCandPrint();


        }


        /// <summary>
        /// Convert temperature from F to C and print to console
        /// </summary>
        static void ConvertFtoCandPrint()
        {
            // vytvorte metodu ktera prevadi stupne F na C
            // a prevadejte cisla ze vstupu od uzivatele

            Console.WriteLine("Zadej teplotu ve stupnich F:");

            double f = double.Parse(Console.ReadLine());
            double c = ConvertFtoC(f);

            Console.WriteLine($"{f}°F je {c}°C");
        }

        static void Hello(string name)
        {
            string name5p = name;

            if (name == "Xaver")
            {
                name5p = "Xavere";
            }
            else if (name == "Karel")
            {
                name5p = "Karle";
            }
            else if (name == "Petr")
            {
                name5p = "Petře";
            }
            else
            {
                name5p += ", omlouvám se, ale tvoje jméno neumím skloňovat.";
            }

            string pozdrav = "Ahoj " + name5p;

            Console.WriteLine(pozdrav);
        }

        static int Calc(int x)
        {
            // vytvorte metodu ktera vstup vynasoby 2
            // a pricte  10

            int result = x * 2 + 10;

            return result;
        }

        /// <summary>
        /// converts temperature from F to C
        /// </summary>
        /// <param name="tempF">temperature F as double</param>
        /// <returns>temperature C</returns>
        static double ConvertFtoC(double tempF)
        {
            return (tempF - 32) / 1.8;
        }
    }

}