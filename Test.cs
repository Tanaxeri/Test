using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {


                Console.WriteLine("Adja meg az első egész számot!");
                int EgyesEgeszSzam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Adja meg a második egész számot!");
                int KettesEgeszSzam = Convert.ToInt32(Console.ReadLine());

                if (EgyesEgeszSzam > KettesEgeszSzam)
                {

                    Console.WriteLine($"A {EgyesEgeszSzam} a nagyobb!");

                }
                else
                {

                    Console.WriteLine($"A {KettesEgeszSzam} a nagyobb!");

                }
                

            Console.WriteLine("\nProgram vége");
            Console.ReadKey();
        }
    }
}
