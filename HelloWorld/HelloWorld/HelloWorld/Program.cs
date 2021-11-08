using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {

            // zeptejte se uzivatele na datum narozeni a reknete, zda je plnolety

            Console.WriteLine("   ---   Zadejte své datum narození   ---   ");

            DateTime date = new DateTime(2020, 12, 24, 23, 59, 59);

            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            var twoweeks = date.AddDays(14);
            Console.WriteLine(date.ToShortDateString());

            TimeSpan diff = now - date;

            Console.WriteLine("Zadej datum oddelene teckami");
            DateTime datum = DateTime.Parse(Console.ReadLine());

            TimeSpan ts = DateTime.Now - datum;
            if (ts.TotalDays / 365.0 >= 18)
            {
                Console.WriteLine("Jsi dospely.");
            }
            else
            {
                Console.WriteLine("Nejsi dospely.");
            }



            /*
            // uzivatel zada jmeno a vek do konzole, budeme ukladat do souboru stylem: jmeno;vek


            Console.WriteLine("Zadejte jméno: ");
            string name = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Zadejte věk: ");
            string age = Console.ReadLine();

            if(name == "x" | surname == "x" | age == "x")
            {
                Console.WriteLine("Ukončili jste program.");
            }
            else
            {
                try
                {
                    File.AppendAllText("lide.txt", $"{name};{surname};{age}" + Environment.NewLine);
                }

                catch (Exception ex)
                {
                    File.AppendAllText("log.txt", "General exception: " + ex.Message + Environment.NewLine);
                    Console.WriteLine("Chyba!");
                }
            }
            */

            /*
            string name = "     Xaver Jandura     ";

            if (string.IsNullOrEmpty(name))
            {
                //mam jmeno
            }


            string name_trimmed = name.Trim();
            Console.WriteLine(name);
            Console.WriteLine(name_trimmed);

            string[] items = name_trimmed.Split(" ");
            string firstname = items[0];
            string lastname = items[1];
            Console.WriteLine(firstname);
            Console.WriteLine($"firstname: {firstname} lastname: {lastname}");

            bool hasXaver = name.Contains("Xaver", StringComparison.Ordinal);
            Console.WriteLine($"hasXaver: {hasXaver}");

            if (name.ToLower() == "xaver")
            {

            }
            */

            /*
            Console.WriteLine("Zadávej teplotu v F nebo zmáčnkni " + "x" + "pro konec");
            string input = "";

            while(input != "x")
            {
                input = ConvertFtoCandPrint();
            }

            // program, ktery na vstupu nacte cislo, pak prevedeme na stupne F, pokud zada pismeno x, program skonci

            */
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

            try
            {
                double f = double.Parse(user_input);
                double c = ConvertFtoC(f);
                Console.WriteLine($"{f}°F je {c}°C");
            }
            /*
            catch (FormatException ex)
            {
                if (user_input != "x")
                    File.AppendAllText("errorlog.txt","Bad format: " + ex.Message + Environment.NewLine);
            }
            */
            catch (Exception ex)
            {
                File.AppendAllText("errorlog.txt","General exception: " + ex.Message + Environment.NewLine);
            }
                return user_input;
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