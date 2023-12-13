using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais
{
    internal class Program
    {
        static void Main()
        {
            // Ievada skaitļus A un B
            Console.Write("Ievadiet skaitli A: ");
            double skaitlisA = double.Parse(Console.ReadLine());

            Console.Write("Ievadiet skaitli B: ");
            double skaitlisB = double.Parse(Console.ReadLine());

            // visu darbību izpilde un rezultātu izvadīšana konsolē
            double reizinajums = skaitlisA * skaitlisB;
            Console.WriteLine($"Operācijas reizināt darbība: {skaitlisA} * {skaitlisB} = {reizinajums}");

            double starpiba = skaitlisA - skaitlisB;
            Console.WriteLine($"Operācijas atņemt darbība: {skaitlisA} - {skaitlisB} = {starpiba}");

            double summa = skaitlisA + skaitlisB;
            Console.WriteLine($"Operācijas summa darbība: {skaitlisA} + {skaitlisB} = {summa}");

            // DALIJUMAM VISTICAMĀK IR JĀBŪT DECIMĀLDAĻĀS
            double dalijums = skaitlisA / skaitlisB;
            Console.WriteLine($"Operācijas dalīt darbība: {skaitlisA} / {skaitlisB} = {dalijums}");

            Console.ReadLine(); // Lai saglabātu konsoles logu atvērtu
        }
    }
}

