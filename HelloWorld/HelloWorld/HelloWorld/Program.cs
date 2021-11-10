using HelloWorld.Data;
using HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.IO;
using DayOfWeek = HelloWorld.Model.DayOfWeek;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(DayOfWeek.GetDayNameCZ(2));
            Console.WriteLine(DayOfWeek.GetDayNameCZarray(5));
            Console.WriteLine(DayOfWeek.GetDayNameCZswitch(7));
            Console.WriteLine(DayOfWeek.GetDayIndex("středa"));



            /*
            Point2D pointA = new Point2D(10, 15);
            Point2D pointB = new Point2D(100, 100);


            Console.WriteLine(pointA);
            Console.WriteLine(pointB);
            var soucet = PointMath.AddPoints(pointA, pointB);
            Console.WriteLine($"{soucet}");
            */

            //vypsat lidi ze souboru people.txt do konzole tak, aby byla videt pouze jejich jmena a zaroven byla oddelena carkou

            /*
            var people = PersonData.LoadPeople();

            Console.WriteLine($"V souboru je: {people.Count} lidí");

            foreach (var item in people)
            {
                Console.Write(item.FirstName + ", ");
            }

            Console.ReadLine();
            // funkcni, ale ma to na konci jmena carku, coz nechceme (viz nize)
            */

            /*
            List<string> names = new List<string>();
            foreach (var p in PersonData.LoadPeople())
            {
                names.Add(p.FirstName + " " + p.LastName);

            }
            
            var joined = string.Join(", ", names);
            Console.WriteLine(joined);
            */

            /*
            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();
            Person p4 = new Person();
            Person p5 = new Person();

            List<Person> people = new List<Person>() { p1, p2, p3, p4, p5 };

            foreach(var p in people)
            {

            }


            var people = PersonData.LoadPeople();

            Console.WriteLine(people.Count);
            */

            /*
            Person p = new Person("Martin", "Novák", new DateTime(1999, 11, 22)); // var p = new Person("Martin", "Novák", new DateTime(1999, 11, 22));
            //p.HomeAddress = new Address("Praha", "Trojská");
            p.HomeAddress.City = "Praha";
            p.HomeAddress.Street = "Ječná";

            Person p2 = new Person("Jarmila", "Nováková", new DateTime(1989, 01, 12));
            p2.HomeAddress.City = "Brno";
            p2.HomeAddress.Street = "Jilemnická";

            Person p3 = new Person("Iveta", "Bednářová", new DateTime(1899, 03, 24));
            p3.HomeAddress.City = "Karviná";
            p3.HomeAddress.Street = "Pražská";

            Person p4 = new Person("Mia", "Levicová", new DateTime(1921, 05, 27));
            p4.HomeAddress.City = "Praha";
            p4.HomeAddress.Street = "Vítečná";

            Person p5 = new Person("Karel", "Vomáčka", new DateTime(1938, 02, 28));
            p5.HomeAddress.City = "Brno";
            p5.HomeAddress.Street = "Strakonická";

            Person p6 = new Person("Josef", "Pepík", new DateTime(1966, 09, 10));
            p6.HomeAddress.City = "Brno";
            p6.HomeAddress.Street = "Bulharová";

            Person p7 = new Person("Alois", "Pumpička", new DateTime(1968, 08, 11));
            p7.HomeAddress.City = "Hradec Králové";
            p7.HomeAddress.Street = "U hradu";

            Person p8 = new Person("Vítek", "Bugot", new DateTime(1967, 05, 22));
            p8.HomeAddress.City = "Plzeň";
            p8.HomeAddress.Street = "V ulici";

            Person p9 = new Person("Ivana", "Salámová", new DateTime(1912, 05, 18));
            p9.HomeAddress.City = "Ostrava";
            p9.HomeAddress.Street = "Pražská";

            Person p10 = new Person("Božena", "Tichá", new DateTime(1998, 01, 09));
            p10.HomeAddress.City = "Brno";
            p10.HomeAddress.Street = "Nová";

            PersonData.SavePerson(p);
            PersonData.SavePerson(p2);
            PersonData.SavePerson(p3);
            PersonData.SavePerson(p4);
            PersonData.SavePerson(p5);
            PersonData.SavePerson(p6);
            PersonData.SavePerson(p7);
            PersonData.SavePerson(p8);
            PersonData.SavePerson(p9);
            PersonData.SavePerson(p10);

            */

            //List<int> numbers = new List<int>();
            //List<string> names = new List<string>();

            //Console.WriteLine(p);


            //Car car = new Car("C12345", "silver", 794124.4);

        }


        private static void StarsiOsoba()
        {

            Person p1 = new Person();
            p1.FirstName = "Xaver František";
            p1.LastName = "Jandura";
            p1.DateOfBirth = new DateTime(1992, 03, 25);
            int age1 = p1.Age();

            Person p2 = new Person();
            p2.FirstName = "Alois";
            p2.LastName = "Pumpička";
            p2.DateOfBirth = new DateTime(1991, 12, 24);
            int age2 = p2.Age();

            Person oldest = p1.Age() >= p2.Age() ? p1 : p2;

            Console.WriteLine($"Nejstarší je {oldest.FirstName} {oldest.LastName}");


            Car opel = new Car();
            opel.PlateNumber = "A12345";
            opel.Color = "Green";
            opel.Kilometers = 5478.8;
            

            Car skoda = new Car();
            skoda.PlateNumber = "B12345";
            skoda.Color = "Red";
            skoda.Kilometers = 78987.1;



            /*
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

            */

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

        private static void FindOldest()
        {
            int age_max = 0;
            string name_oldest = "";

            foreach (var line in File.ReadLines("lide.txt"))  //foreach pouziju na cteni kazdeho radku
            {
                string[] items = line.Split(';'); //rozdelim si hodnoty podle stredniku

                string firstname = items[0];
                string surname = items[1];
                string age_s = items[2];

                int age = int.Parse(age_s); //prevedu string na cislo

                if (age > age_max)
                {
                    age_max = age;
                    name_oldest = firstname;
                }

            }

            Console.WriteLine($"Nejstarší je {name_oldest} ({age_max})");
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

        static int AgeSolver(DateTime dateofbirth)
        {
            DateTime today = DateTime.Today;

            return (int)(today - dateofbirth).TotalDays / 365;
        }

        static int Compare(int x, int y)
        {
            /*if (x > y)
                return x;
            else
                return y;
            */
            
            //return Math.Max(x,y);
            
            return (x > y ? x : y);
        }

        static bool IsEndingOva(string jmeno)
        {
            return jmeno.EndsWith("ova");
        }

        static bool IsEndingOva(string jmeno, bool ignoreCase)
        {
            return jmeno.EndsWith("ova", StringComparison.OrdinalIgnoreCase);
        }

    }
}