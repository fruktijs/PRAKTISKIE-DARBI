using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikais4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadiet skaitli X: ");
            double skaitlisx = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ievadiet skaitli Y: ");
            double skaitlisy = Convert.ToDouble(Console.ReadLine());

            if (skaitlisy == 0)
            {
                // izvada tekstu, JA skaitlis Y ir ievadīts kā 0, ar kuru nav iespējams dalīt
                Console.WriteLine("Dalīšana ar 0 nav iespējama!");
            }
            else
            {
                // izvada tekstu, JA skaitlis Y ir ievadīts lielāks kā 0
                double rezultats = skaitlisx / skaitlisy;
                Console.WriteLine("Dalījuma rezultāts: " + rezultats);
            }
        }
    }
}
