/* OBSŁUGA PROSTEGO WYJĄTKU PRZEKROCZENIA WARTOSCI MAX INT */
using System;
namespace ObslugaWyjatkowMaxInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            int b = 3;

            Console.WriteLine(unchecked(a + b));  // output: -2147483646
            try
            {
                int d = checked(a + b);
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Overflow occurred / when adding {a} to {b}.");
                // znak $ powoduje, że można wartości {a} i {b} wrzucić bezpośrednio w miejsce gdzie występują, a nie klasycznie:
                //Console.WriteLine("Overflow occurred when adding {0} to {1}.", a, b);
                Console.ReadKey();
            }
        }
    }
}



    /* OBSŁUGA PROSTEGO WYJĄTKU DZIELENIA PRZEZ ZERO */

//using System;
//namespace ObslugaWyjatkow
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            DzieleniePrzezZero dpz = new DzieleniePrzezZero(8, 0);
//            Console.ReadKey();
//        }
//    }
//    class DzieleniePrzezZero
//    {
//        int result = 0;
//        public DzieleniePrzezZero(int a, int b)
//        {
//            try
//            {
//                result = a / b;
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine("Zgłoszono wyjątek: {0}", ex);
//            }
//        }
//    }
//}
