using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodajDwieLiczby3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // int wynik = x + y;

            // Console.WriteLine("Suma podanych wartości wynosi: " + wynik);
            // Console.WriteLine("Suma podanych wartości wynosi: {0}", wynik);
            Console.WriteLine($"Suma podanych wartości wynosi: {x+y}");
            Console.ReadKey();
        }
    }
}
