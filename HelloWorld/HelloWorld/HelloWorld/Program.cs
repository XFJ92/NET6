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




            int[] numbers = { 1, 2, -30, 4, 20, 256, -45, 99 };

            //where - filtruje kolekci


            /*
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






            foreach (var item in results) //jedna se o kolekci dat, takze k nim pristupujeme pres foreach
            {
                Console.WriteLine(item);
            }



        }
    }
}