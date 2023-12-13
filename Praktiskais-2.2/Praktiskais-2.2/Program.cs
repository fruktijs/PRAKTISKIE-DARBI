using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_2._2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            for (int x = 1; x <= 10; x++)
            {
                for (int z = 1; z <= 10; z++)
                {
                    int result = x * z;
                    Console.Write(result + "\t"); // Izvada reizināšanas rezultātu, atdalot ar tabulācijas simbolu
                }
               

                Console.WriteLine(); // Jauno rindu pēc katras rindas izvadīšanas
            }
        }
    }
}
