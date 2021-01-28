using System;
using System.Globalization;

namespace CS322_DZ14_BojanPetrovic2745
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesi ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesi prezime: ");
            string prezime = Console.ReadLine();
            Console.WriteLine("Unesi dan rodjenja: ");
            int dan = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi mesec rodjenja: ");
            string mesec = Console.ReadLine();

            Console.WriteLine(zodiac_sign(dan, mesec));
        }

        static string zodiac_sign(int day, string month)
        {
            string astro_sign = "";

            if (month == "decembar")
            {

                if (day < 22)
                   return  astro_sign = "Strelac";
                else
                   return  astro_sign = "Jarac";
            }

            else if (month == "januar")
            {
                if (day < 20)
                    return astro_sign = "Jarac";
                else
                    return astro_sign = "Vodolija";
            }

            else if (month == "februar")
            {
                if (day < 19)
                    return astro_sign = "Vodolija";
                else
                    return astro_sign = "Ribe";
            }

            else if (month == "mart")
            {
                if (day < 21)
                    return astro_sign = "Ribe";
                else
                    return astro_sign = "Ovan";
            }
            else if (month == "april")
            {
                if (day < 20)
                    return astro_sign = "Ovan";
                else
                    return astro_sign = "Bik";
            }

            else if (month == "maj")
            {
                if (day < 21)
                    return astro_sign = "Bik";
                else
                    return astro_sign = "Blizanci";
            }

            else if (month == "jun")
            {
                if (day < 21)
                    return astro_sign = "Blizanci";
                else
                    return astro_sign = "Rak";
            }

            else if (month == "jul")
            {
                if (day < 23)
                    return astro_sign = "Rak";
                else
                    return astro_sign = "Lav";
            }

            else if (month == "avgust")
            {
                if (day < 23)
                    return astro_sign = "Lav";
                else
                    return astro_sign = "Devica";
            }

            else if (month == "septemar")
            {
                if (day < 23)
                    return astro_sign = "Devica";
                else
                    return astro_sign = "libra";
            }

            else if (month == "oktobar")
            {
                if (day < 23)
                    return astro_sign = "Vaga";
                else
                    return astro_sign = "Škorpija";
            }

            else if (month == "novembar")
            {
                if (day < 22)
                    return astro_sign = "Škorpija";
                else
                    return astro_sign = "Strelac";
            }

            return "";
        }

    }
}
