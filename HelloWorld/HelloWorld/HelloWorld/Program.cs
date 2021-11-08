﻿using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej teplotu v F nebo zmáčnkni " + "x" + "pro konec");
            string input = "";

            while(input != "x")
            {
                input = ConvertFtoCandPrint();
            }

            // program, ktery na vstupu nacte cislo, pak prevedeme na stupne F, pokud zada pismeno x, program skonci


        }


        /// <summary>
        /// Convert temperature from F to C and print to console
        /// </summary>
        static string ConvertFtoCandPrint()
        {
            // vytvorte metodu ktera prevadi stupne F na C
            // a prevadejte cisla ze vstupu od uzivatele

            Console.WriteLine("Zadej teplotu ve stupnich F:");

            string user_input = Console.ReadLine();

            if (user_input == "x")
            return user_input;

            else
            {

                double f = double.Parse(user_input);
                double c = ConvertFtoC(f);

                Console.WriteLine($"{f}°F je {c}°C");
                return user_input;
            }
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