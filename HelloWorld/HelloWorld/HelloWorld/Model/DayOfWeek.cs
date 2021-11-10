using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    class DayOfWeek
    {

        public DayOfWeek()
        {

        }

        public static string GetDayNameCZ(int dayIndex)
        {
            if (dayIndex == 1)
                return "pondělí";
            else if (dayIndex == 2)
                return "úterý";
            else if (dayIndex == 3)
                return "středa";
            else if (dayIndex == 4)
                return "čtvrtek";
            else if (dayIndex == 5)
                return "pátek";
            else if (dayIndex == 6)
                return "sobota";
            else if (dayIndex == 7)
                return "neděle";
            else
                return "byla zadána hodnota mimo rozsah 1-7.";
        }

        /// <summary>
        /// Pouziti metody switch.
        /// </summary>
        /// <param name="dayIndex"></param>
        /// <returns></returns>
        public static string GetDayNameCZswitch(int dayIndex)
        {
            switch (dayIndex)
            {
                case 1:
                    return "pondělí";
                case 2:
                    return "úterý";
                case 3:
                    return "středa";
                case 4:
                    return "čtvrtek";
                case 5:
                    return "pátek";
                case 6:
                    return "sobota";
                case 7:
                    return "neděle";
                default:
                    return "byla zadána hodnota mimo rozsah 1-7.";
            }
        }



        public static bool IsPracovniDen(int dayIndex)
        {
            switch (dayIndex)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    return true;
                case 7:
                    return false;
                default:
                    throw new Exception("index dne musi byt v rozsahu 1-7");
            }
        }

        public static string GetDayNameCZarray(int dayIndex)
        {
            string[] days = new[] { "pondělí", "úterý", "středa", "čtvrtek", "pátek", "sobota", "neděle" };
            return days[dayIndex - 1];
        }

        //vytvorte program, ktery na vstupu dostane nazev dne (s diakritikou) v tydnu a vypise jeho poradi v tydnu
        //program bude odolny na velka a mala pismena

        public static string[] days = new[] { "pondělí", "úterý", "středa", "čtvrtek", "pátek", "sobota", "neděle" };

        public static int GetDayIndex(string dayName)
        {
            for (int i = 0; i < 7; i++)
            {
                if (days[i] == dayName.ToLower())
                    return i + 1;
            }
            return -1;
        }
    }
}



