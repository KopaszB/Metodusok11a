using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.feladat
{
    internal class Program
    {
        static int Maximum(int a, int b)
        {
            return a > b ? a : b;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Első szám: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Második szám: ");
                int b = int.Parse(Console.ReadLine());
                /*
                if (a==b)
                {
                    Console.WriteLine("A számok egyformák!");
                }
                else
                {
                    Console.WriteLine(Maximum(a, b) + " a nagyobb!");
                }
                */
                Console.WriteLine(a==b? "A számok egyformák!" : Maximum(a, b) + " a nagyobb!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }



            Console.ReadKey();
        }
    }
}
