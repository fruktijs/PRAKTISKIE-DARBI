using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikais5__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                {
                    Console.WriteLine("3. uzdevums");

                    string dashes = new string('-', 82);
                    for (int i = 0; i <= 10; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("y/x\t|");
                            for (int j = 1; j <= 10; j++)
                            {
                                Console.Write($"{j}\t");
                            }
                            Console.Write($"\n{dashes}\n");
                        }

                        else
                        {
                            Console.Write($"{i}\t|");
                            for (int j = 1; j <= 10; j++)
                            {
                                Console.Write($"{j * i} \t");
                            }
                            Console.Write("\n");
                        }
                    }
                }
            }
        }
    }
}
