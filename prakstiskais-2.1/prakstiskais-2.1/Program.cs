using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakstiskais_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadiet skaitli a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Īevadiet skaitli b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            //ToInt32 - Pārvērš norādīto skaitļa virknes attēlojumu par 32 bitu veselu skaitli.

            int rezultats1 = a + b;
            int rezultats2 = a - b;
            int rezultats3 = a * b;
            int rezultats4 = a / b;
            int rezultats5 = a % b;
            double rezultats6 = (double)a / b;
            int rezultats7 = a * a + b * b;

            Console.WriteLine("1) a + b = " + rezultats1);
            Console.WriteLine("2) a - b = " + rezultats2);
            Console.WriteLine("3) a * b = " + rezultats3);
            Console.WriteLine("4) a / b (dalīšanas vesela daļa) = " + rezultats4);
            Console.WriteLine("5) a % b (dalīšanas atlikums) = " + rezultats5);
            Console.WriteLine("6) a / b (dalīšanas rezultāts -> daļskaitlis) = " + rezultats6);
            Console.WriteLine("7) a^2 + b^2 = " + rezultats7);

            Console.ReadLine();
    
}
    }
}
