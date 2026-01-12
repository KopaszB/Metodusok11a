using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.feladat
{
    internal class Program
    {
        static double Osszead(double szam1,double szam2) 
        {
            return szam1 + szam2;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Első szám: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Második szám: ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine($"Összeg: {Osszead(a, b)}");
            }
            catch (Exception uzenet)
            {
                Console.WriteLine(uzenet);
            }
            
            

            Console.ReadKey();
        }
    }
}
