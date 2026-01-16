using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.feladat
{
    internal class Program
    {
        static long Faktorial(int szam) 
        {
            long fakt = 1;
            for (int i = 1; i <= szam; i++)
            {
                fakt = fakt * i;
            }
            return fakt;
        }
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot: ");
            int.TryParse(Console.ReadLine(),out int szam);
            Console.WriteLine($"{szam}! = {Faktorial(szam)}");

            Console.ReadKey();
        }
    }
}
