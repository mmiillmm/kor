using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    class Program
    {
        static void Main()
        {
            double sugar;

            Console.Write("Kérem adja meg a kör sugarát: ");

            string szoveg = Console.ReadLine();
            sugar = Convert.ToDouble(szoveg);

            double terulet, kerulet;

            terulet = Math.Pow(sugar, 2) * Math.PI;
            kerulet = 2 * sugar * Math.PI;

            Console.WriteLine($"A kör területe: {terulet}");
            Console.WriteLine($"A kör kerülete: {kerulet}");

            Console.ReadKey();
        }
    }
}
