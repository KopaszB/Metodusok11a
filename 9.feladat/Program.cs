using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.feladat
{
    internal class Program
    {
        static bool PrimE(int szam)
        {
            int osztokSzama = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam%i==0)
                {
                    osztokSzama++;
                }
            }
            if (osztokSzama==2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Kérek egy számot: ");
                int szam = int.Parse(Console.ReadLine());
                if (PrimE(szam) == true)
                {
                    Console.WriteLine("A szám prím!");
                }
                else
                {
                    Console.WriteLine("A szám nem prím!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba!" + ex.Message);
            }

            
            Console.ReadKey();
        }
    }
}
