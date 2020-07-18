using System;
namespace Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            short s;
            int i;
            double d;
            // Inicjowanie zmiennych
            s = 10;
            i = 20;
            d = s + i;
            // Wyświetlenie w konsoli wartości kolejnych zmiennych
            // Rezultat wykonania programu: s = 10, i = 20, d = 30
            Console.WriteLine("s = {0}, i = {1}, d = {2}", s, i, d);
            Console.ReadLine();
        }
    }
}
