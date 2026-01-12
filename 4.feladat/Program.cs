using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.feladat
{
    internal class Program
    {
        static bool ParosE(int szam)
        {
            return szam % 2 == 0 ? true : false;
        }

        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            /*
            if (ParosE(a))
            {
                Console.WriteLine("A szám páros!");
            }
            else
            {
                Console.WriteLine("A szám páratlan!");
            }
            */

            //hármas operandusú feltételvizsgálat
            Console.WriteLine(ParosE(a) ? "A szám páros!" : "A szám páratlan!");

            Console.ReadLine();
        }
    }
}
