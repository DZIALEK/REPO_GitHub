using System;
using System.Reflection.Metadata;

namespace Lekcja0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            if (a > 0 && a >=5)
            {
                Console.WriteLine("a większe od zera | " + a);
                Console.WriteLine("a większe od 5 | " + a);
            }
            else if (a > 0)
            {
                Console.WriteLine("a większe od zera | " + a);
            }
            else if (a == 0)
            {
                Console.WriteLine("Pokazuje sie a, bo jest równe zero | " + a);
            }
            else
            {
                Console.WriteLine("Pokazuje sie a, bo if mniejsze od zera | " + a);
            }
            Console.ReadKey();
        }
    }
}
