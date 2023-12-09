using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktiskais11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietotāja ievade masīvu izmēriem
            Console.Write("Ievadiet pirmā masīva izmēru: ");
            int pirmaMasivaIzmers = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet otro masīva izmēru: ");
            int otraMasivaIzmers = int.Parse(Console.ReadLine());

            // Inicializēt divus string tipa masīvus
            string[] pirmaMasivaVērtības = new string[pirmaMasivaIzmers];
            string[] otraMasivaVērtības = new string[otraMasivaIzmers];

            // Pirmā masīva aizpildīšana
            Console.WriteLine("Ievadiet vērtības pirmajam masīvam:");
            for (int i = 0; i < pirmaMasivaIzmers; i++)
            {
                Console.Write($"Ievadiet vērtību {i + 1}: ");
                pirmaMasivaVērtības[i] = Console.ReadLine();
            }

            // Otra masīva aizpildīšana
            Console.WriteLine("Ievadiet vērtības otrojam masīvam:");
            for (int i = 0; i < otraMasivaIzmers; i++)
            {
                Console.Write($"Ievadiet vērtību {i + 1}: ");
                otraMasivaVērtības[i] = Console.ReadLine();
            }

            // Izvadīt abus masīvus uz ekrāna
            Console.WriteLine("\nPirmā masīva vērtības:");
            Console.WriteLine(string.Join(", ", pirmaMasivaVērtības));

            Console.WriteLine("\nOtra masīva vērtības:");
            Console.WriteLine(string.Join(", ", otraMasivaVērtības));

            // Izveidot vienu simbolu rindu no abiem masīviem
            Console.WriteLine("\nSimbolu rinda no abiem masīviem:");
            for (int i = 0; i < Math.Max(pirmaMasivaIzmers, otraMasivaIzmers); i++)
            {
                if (i < pirmaMasivaIzmers)
                {
                    Console.Write(pirmaMasivaVērtības[i]);
                }

                if (i < otraMasivaIzmers)
                {
                    Console.Write(otraMasivaVērtības[i]);
                }
            }

            Console.WriteLine(); // Jaunas rindas pāreja
        }
    }
}
