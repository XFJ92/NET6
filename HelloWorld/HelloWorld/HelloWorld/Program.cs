using HelloWorld.Data;
using HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.IO;
using DayOfWeek = HelloWorld.Model.DayOfWeek;
using System.Linq; //dovoli pouzivat SQL dotazy a knihovny

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] numbers = { -2079, -498, 2920, -1856, 332, -2549, -674, -120, -992, 2782, 320, -524, 135, 952, 1868, 2509, -230, -138, -904, -480 };

            /// z "numebers" zjistěte:
            /// 1. počet prvků v poli
            var count = numbers.Count();
            Console.WriteLine(count);

            /// 2. největší hodnotu
            var max = numbers.Max();
            Console.WriteLine(max);

            /// 3. nejmenší hodnotu
            var min = numbers.Min();
            Console.WriteLine(min);

            /// 4. průměr
            var avg = numbers.Average();
            Console.WriteLine(avg);

            /// 5. kolik obsahuje pole kladných čísel

            var positive = numbers
                .Where(x => x >= 0).Count();
            Console.WriteLine(positive);

            /// 6. kolik obsahuje pole záporných čísel
            var count_neg = numbers
                .Where(x => x <= 0).Count();
            Console.WriteLine(count_neg);

            /// 7. sumu všech hodnot
            var sum = numbers.Sum();
            Console.WriteLine(sum);

            /// 8. sumu kladných hodnot
            var sum_pos = numbers
                .Where(x => x >= 0).Sum();
            Console.WriteLine(sum_pos);

            /// 9. seřaďte pole od nejmenších po největší hodnoty,
            /// přeskočte první 3 prvky a sečtěte zbytek hodnot

            var sort = numbers.OrderBy(x => x)
                .Skip(3)
                .Sum();
            Console.WriteLine($"Vysledek je: {sort}");





            /*
            //where - filtruje kolekci
            var results = numbers
                .Where(number => number >= 0) //nebo lze zapsat v jednom dotazu: (number => number >= 0 && number <= 100)
                .Where(number => number <= 100); //alternativa k zapisu dalsi podminky - retezeni podminek
            */

            //orderby = razeni
            //var results = numbers.OrderBy(sort => sort); //seradi nam prvky v kolekci od nejmensiho po nejvetsi

            //preskoceni nebo oseknuti kolekce > take, skip

            //var results = numbers.Take(5); //uvidim z kolekce prvnich 5 cisel
            //var results = numbers.Skip(5); //preskoci prvnich 5 cisel z kolekce - orizne je

            //var results = numbers.SkipWhile(n => n > 0); //podminka, ktera postupne prochazi kolekci, podiva se na 1 (podminka plati) a preskoci dal, podiva se na 2 (podminka plati) a zase jede dal, podiva se na -30 (podminka NEKPLATI) a vypise vsechno dal


            /*
            //agregacni operatory - max, min, sum, average
            var sum = numbers.Sum();  //vraci nejakou hodnotu a ne kolekci, nebude tudiz fungovat foreach
            Console.WriteLine(sum); //vypise sumu z kolekce

            var avg = numbers.Average();
            Console.WriteLine(avg);
            */


            /*
            //vezme jeden prvek z kolekce - first, last
            var first = numbers.First();
            Console.WriteLine(first);
            var last = numbers.Last();
            Console.WriteLine(last);
            */


            /*
            foreach (var item in results) //jedna se o kolekci dat, takze k vyrazum z DB prevazne pristupujeme pres foreach
            {
                Console.WriteLine(item);
            }
            */


        }
    }
}