using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrochnaOcenka
{
    public class Restart
    {
        public static void resetSoftware()
        {
            Program.Main();
        }
    }
    class Program
    {
        public static double totalOcenki
        {
            get;
            set;
        }
        public static int totalInvalid
        {
            get;
            set;
        }
        public static void Main()
        {
            Console.Title = "Срочна Оценка | https://github.com/dayofpay";
            List<double> spisukOcenki = new List<double>();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Моля, посочете всички оценки със (,) : ");
            var broiOcenki = Console.ReadLine();
            String[] broi = broiOcenki.Split(new[] { ',' });
            var realOcenki = broi.Length - 1;
            totalOcenki = realOcenki;
            for (int b = 0; b <= totalOcenki; b++)
            {
                if (int.Parse(broi[b]) > 6)
                {
                    Console.WriteLine("Това число беше игнорирано, тъй като е по-голямо от максималната оценка '6' [" + broi[b] + "]");
                    totalInvalid++;
                }
                if (int.Parse(broi[b]) < 2) {
                    Console.WriteLine("Това число беше игнорирано, тъй като е по-малко от минималната оценка '2' [" + broi[b] + "]");
                    totalInvalid++;
                }
                else if (int.Parse(broi[b]) >= 2 && int.Parse(broi[b]) <= 6)
                {
                    Console.WriteLine($"Оценка №{b} : {broi[b]}");
                    spisukOcenki.Add(int.Parse(broi[b]));
                }
            }
            // Изчисление ...
            if(totalInvalid > 0)
            {
                var sum = spisukOcenki.Sum();
                Calculation.Calc(sum, broi.Length - totalInvalid);
            }
            else
            {
                var sum = spisukOcenki.Sum();
                Calculation.Calc(sum, broi.Length);
            }
            // Изчисление ...
        }
    }
}
