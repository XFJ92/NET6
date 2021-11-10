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

            var results = numbers.Where(number => number >= 0 && number <= 100);

            foreach(var item in results)
            {
                Console.WriteLine(item);
            }



        }
    }
}