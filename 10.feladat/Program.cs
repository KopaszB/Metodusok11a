using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.feladat
{
    internal class Program
    {
        static int Legnagyobb(List<int> lista) 
        {
            return lista.Max(x=>x);
        }
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            Console.WriteLine("Hány számot adsz meg?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1}.elem = ");
                int elem = int.Parse(Console.ReadLine());
                szamok.Add(elem);
            }
            Console.WriteLine($"A legnagyobb szám: {Legnagyobb(szamok)}");

            Console.ReadKey();
        }
    }
}
