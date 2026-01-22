using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.feladat
{
    internal class Program
    {
        static int Osszead(int szam1, int szam2)
        {
            return szam1 + szam2;
        }
        static int Kivon(int szam1, int szam2)
        {
            return szam1 - szam2;
        }
        static int Szorzas(int szam1, int szam2)
        {
            return szam1 * szam2;
        }
        static double Osztas(int szam1, int szam2)
        {
            if (szam2==0)
            {
                throw new ArgumentException("Nullosztó!!!");
            }
            return szam1 / szam2;
        }

        static void Main(string[] args)
        {
            try
            {
                string valasz;
                do
                {
                    Console.Write("a = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Műveleti jel(+,-,*,/): ");
                    string mJel = Console.ReadLine();
                    switch (mJel)
                    {
                        case "+":
                            Console.WriteLine($"Eredmény: {Osszead(a, b)}");
                            break;
                        case "-":
                            Console.WriteLine($"Eredmény: {Kivon(a, b)}");
                            break;
                        case "*":
                            Console.WriteLine($"Eredmény: {Szorzas(a, b)}");
                            break;
                        case "/":
                            Console.WriteLine($"Eredmény: {Osztas(a, b)}");
                            break;

                        default:
                            Console.WriteLine("Nincs ilyen művelet!");
                            break;
                    }
                    Console.Write("\nAkarsz-e még egy számítást(i/n): ");
                    valasz = Console.ReadLine();
                } 
                while (valasz.ToLower()=="i");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Hiba! " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba! " + ex.Message);
            }
        }
    }
}
