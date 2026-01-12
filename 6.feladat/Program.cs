using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.feladat
{
    internal class Program
    {
        static int NegyzetTerulet(int oldal)
        {
            return oldal * oldal;
        }
        static void Main(string[] args)
        {
            Console.Write("A négyzet oldala: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"A négyzet területe: {NegyzetTerulet(a)}");

            Console.ReadKey();
        }
    }
}
