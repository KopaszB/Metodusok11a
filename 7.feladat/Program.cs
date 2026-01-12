using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.feladat
{
    internal class Program
    {
        static string ForditottSzoveg(string szoveg)
        {
            //return new string(szoveg.Reverse().ToArray());
            
            string fszoveg = "";
            for (int i = szoveg.Length-1; i >=0; i--)
            {
                fszoveg = fszoveg + szoveg[i];
            }
            return fszoveg;
        }
        static void Main(string[] args)
        {
            Console.Write("Kérek egy szöveget: ");
            string text = Console.ReadLine();
            Console.WriteLine($"A szöveg megfordítva: {ForditottSzoveg(text)}");

            Console.ReadKey();
        }
    }
}
