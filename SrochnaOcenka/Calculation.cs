using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrochnaOcenka
{
    class Calculation
    {
        public static double final
        {
            get;
            set;
        }
        public static void Calc(double gradeSum, double totalGrades)
        {
            final = gradeSum / totalGrades;
            if(final > 6)
            {
                Console.WriteLine("Вашата оценка е: 6.00");
                Console.WriteLine($"[DEBUG] Изчисление : {gradeSum} / {totalGrades}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Натиснете бутон 'R' за да рестартирате програмата ...");
                var resetKey = Console.ReadKey();
                if(resetKey.Key == ConsoleKey.R)
                {
                    SrochnaOcenka.Restart.resetSoftware();
                }
            }
            else
            {
                Console.WriteLine("Вашата оценка е: " + final);
                Console.WriteLine($"[DEBUG] Изчисление : {gradeSum} / {totalGrades}");
                Console.WriteLine("Натиснете бутон 'R' за да рестартирате програмата ...");
                var resetKey = Console.ReadKey();
                if (resetKey.Key == ConsoleKey.R)
                {
                    SrochnaOcenka.Restart.resetSoftware();
                }
            }
        }
    }
}
