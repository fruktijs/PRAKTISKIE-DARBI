using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakstiskais10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definēt int tipa masīvu ar 10 elementiem
            int[] masivs = new int[10];

            // Aizpildīt masīvu ar gadījuma skaitļiem no 1 līdz 20
            Random rand = new Random();
            for (int i = 0; i < masivs.Length; i++)
            {
                masivs[i] = rand.Next(1, 21);
            }

            // Izvadīt inicializēto masīvu uz ekrāna
            Console.WriteLine("Inicializētais masīvs:");
            IzvaditMasivu(masivs);

            // Apgriezt masīvu pretējā virzienā
            Array.Reverse(masivs);

            // Izvadīt apgriezto masīvu uz ekrāna
            Console.WriteLine("\nApgrieztais masīvs:");
            IzvaditMasivu(masivs);
        }

        // Palīgmetode masīva izvadīšanai uz ekrāna
        static void IzvaditMasivu(int[] masivs)
        {
            foreach (var elements in masivs)
            {
                Console.Write(elements + " ");
            }
            Console.WriteLine();
        }
    }
}
