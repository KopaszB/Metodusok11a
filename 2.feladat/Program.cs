using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void Koszont(string nev)
        { 
            Console.WriteLine($"Üdvözöllek {nev}!"); 
        }

        static void Main(string[] args)
        {
            Koszont("Robotzsaru");

            Console.ReadKey();
        }
    }
}
