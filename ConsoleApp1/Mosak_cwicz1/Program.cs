using Microsoft.VisualBasic;
using System;
using System.Dynamic;


/* ZAD0 */
//namespace zad0
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            Console.ReadKey();
//        }
//    }
//}

/* ZAD1 */
//Zmienne liczbowe całkowite randomowe + wynik z dodawania
//namespace zad1a
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rand = new Random();
//            int a = rand.Next(0, 100);
//            double b = rand.NextDouble();
//            long c = rand.Next(-100,0);

//            Console.WriteLine($"zmienna a: {a} \nzmienna b: {b} \nzmienna {c}");
//            // \n - przenosi do kolejnej linii
//            var wynik = a + b + c;
//            Console.WriteLine($"Wynik dodawania a+b+c= {wynik}");
//            Console.ReadKey();
//        }
//    }
//}

//Zmienne liczbowe całkowite randomowe z klawiatury + konwersja do int i dodawanie
//namespace zad1b
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string text1, text2;
//            int liczba1, liczba2, wynik;

//            Console.WriteLine("Podaj pierwszą liczbę: ");
//            text1 = Console.ReadLine();

//            Console.WriteLine("Podaj drugą liczbę: ");
//            text2 = Console.ReadLine();

//            // Zmien wczytane teskty w liczby
//            Int32.TryParse(text1, out liczba1);
//            Int32.TryParse(text2, out liczba2);
//            wynik = liczba1 + liczba2;

//            Console.WriteLine($"zmienna a: {liczba1} \nzmienna b: {liczba2} \nwynik dodawania: {wynik}");
//            // \n - przenosi do kolejnej linii
//            Console.ReadKey();
//        }
//    }
//}

/* -------------------- ZAD3 ---------------------------------------------------- */
//namespace ZAD3
//Zadeklaruj tablicę elementów typu całkowitego o wielkości 30 elementów.Za pomocą pętliprzypisz elementom tablicy losową wartość.Następnie wyświetl w konsoli całą zawartośćtablicy.
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rand = new Random();
//            int[] tab = new int[5];

//            for (int i = 0; i < tab.Length; i++)
//            {
//                tab[i] = rand.Next(0, 100);
//                Console.WriteLine(tab[i]);
//            }

//            //System.IndexOutOfRangeException
//            //for (int i = 0; i < tab.Length; i++)
//            //{
//            //    Console.WriteLine(tab[i]);
//            //}

//            Console.ReadKey();
//        }
//    }
//}


//namespace zad3
//    // Druga wersja od razu z LP. dla każdej pozycji
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rand = new Random();
//            int[] tab1 = new int[30];

//            for (int i=0; i < tab1.Length; i++)
//            {
//                tab1[i] = rand.Next(0, 100);
//                Console.WriteLine($"{i+1}. {tab1[i]}");
//            }
//        }
//    }
//}


/* ---------------------------- ZAD4 ------------------------------------- */

//namespace zad4
// Napisz program obliczający pierwiastki równania kwadratowego. Użyj instrukcji if... else + pobiera dane z klawiatury
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string tekst1, tekst2, tekst3;
//            int a, b, c, delta;
//            double x0, x1, x2;
//            Console.WriteLine("Wzór na równanie kwadratowe = y= ax^2 + bx + c\nPodaj współczynnik a:");
//            tekst1 = Console.ReadLine();
//            Console.WriteLine("Podaj współczynnik b:");
//            tekst2 = Console.ReadLine();
//            Console.WriteLine("Podaj współczynnik c:");
//            tekst3 = Console.ReadLine();
//            Int32.TryParse(tekst1, out a);
//            Int32.TryParse(tekst2, out b);
//            Int32.TryParse(tekst3, out c);
//            delta = b * b -4 * a * c;
//           if (delta < 0)
//            {
//                Console.WriteLine($"Delta= {delta} => Delta < 0 => Brak pierwiastków");
//            }
//           else if (delta == 0)
//                {
//                x0 = -b/2*a;
//                Console.WriteLine($"Delta= {delta} => Delta = 0 => jest 1 pierwiastek równy: {x0}");
//            }
//            else
//            {
//                x1 = (-b-Math.Sqrt(delta)) / 2 * a;
//                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
//                Console.WriteLine($"Delta= {delta} => Delta > 0 => Są 2 pierwiastki:\nx1: {x1}\nx2:{x2}");
//            }
//        }
//    }
//}



/* ------------------  ZAD 5 --------------------------------------------- */
//namespace zad5
// Napisz program który sprawdzi jaką wartość posiada zmienna. Do zmiennej przypiszwartości losowe z zakresu od 1 do 5. W celu sprawdzenia użyj instrukcji switch.
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}

// wprowadzasz liczbę z klawiatury i komputery wypisuje wszystkie liczby od 0 - tej liczby;

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string tekst;
//            int liczba;
//            int dlugoscTablicy = 4;  // Długość tablicy
//            int tablica[dlugoscTablicy];
//            Console.WriteLine("Podaj liczbę, do której komputer odliczy liczby od 0:");
//            //tekst = Console.ReadLine();
//            int.TryParse(tekst, out liczba);
//            //int[] tablica = new int[liczba];
//            Console.WriteLine(tablica.Length);
//            for (int i = 0; i <= tablica.Length; i++)
//            {
//                Console.WriteLine(tablica[i]);
//            }
//            int.Parse()


//            Console.ReadKey();
//        }
//    }
//}



//// Konwersja STRING na INT, dodanie +2 i zamiana spowrotem na STRING;
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string a, c;
//            int b;

//            Console.WriteLine("Podaj stringa: ");
//            a = Console.ReadLine();
//            int.TryParse(a, out b);
//            b += 2;
//            Console.WriteLine($"Podaną liczbę zwięszkono o 2: {b}");
//            a = b.ToString();
//            Console.WriteLine($"Teraz liczba jest stringiem: {a}");


//        }
//    }
//}

//             Console.Clear(); -- czyści konsole z dotychczasowych wpisów
//             Console.ForegroundColor - kolor czcionki
//             Console.BackgroundColor - kolor tła, ale tylko tego pod literami


/* ------------------------ ZAD  -------------------------------------------------------- */
//namespace zad
//    // Tworzy prostokąt z gwiazdek o podanych przez użytownikach bokach
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a, b;
//            string szerokosc, wysokosc;

//            Console.WriteLine("Podaj szerokość prostokątu: ");
//            szerokosc = Console.ReadLine();
//            int.TryParse(szerokosc, out a);

//            Console.WriteLine("Podaj wysokość prostokątu: ");
//            wysokosc = Console.ReadLine();
//            int.TryParse(wysokosc, out b);

//            int c = a * b;
//            Console.WriteLine($"Pole kwadratu a*b= {c}");

//            for (int i = 0; i < b; i++)
//            {
//                for (int j = 0; j < a; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }

//            Console.ReadKey();
//        }
//    }
//}


/* --------------------  ZAD -------------------------------------- */
// Gra w zgadywanie liczby pseudolosowej na pętli do while i if
//namespace zad

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rand = new Random();
//            int szukana, a;
//            int ileRazy = 0;
//            string strzal;

//            //for (int i = 0; i < 50; i++)
//            //{
//            //    szukana = rand.Next(0, 11); // wartosc losowa od 0-10
//            //    Console.WriteLine(szukana);
//            //}
//            Console.WriteLine("Komputer wylosował liczbę z zakresu 0-10, spróbuj ją zgadnąć.");
//            szukana = rand.Next(0, 11); // wartosc losowa od 0-10
//            do
//            {
//                Console.WriteLine("Podaj liczbę: ");
//                strzal = Console.ReadLine();
//                int.TryParse(strzal, out a);
//                if (a > 10 || a < 0)
//                {
//                    Console.WriteLine("Podałeś liczbę z poza zakresu.");
//                }
//                else
//                {
//                    ileRazy++;
//                    if (a < szukana)
//                    {
//                        Console.WriteLine("Twoja liczba jest za mała");
//                    }
//                    else if (a > szukana)
//                    {
//                        Console.WriteLine("Twoja liczba jest za duża");
//                    }
//                    else
//                    {
//                        Console.ForegroundColor = ConsoleColor.Yellow;
//                        Console.WriteLine($"BRAWO! Zgadałeś za {ileRazy} razem");
//                    }
//                }
//            } while (szukana != a);


//            Console.ReadKey();
//        }


//    }

//}



//namespace zad5
//// Napisz program który sprawdzi jaką wartość posiada zmienna. Do zmiennej przypiszwartości losowe z zakresu od 1 do 5. W celu sprawdzenia użyj instrukcji switch
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            int a = rnd.Next(1, 6); // wybiera z zakresu 1-5

//            switch (a)
//            {
//                case 2: // sprawdza czy a == 2
//                    Console.WriteLine("Liczba równa 1");
//                    break;
//                case 1:
//                    Console.WriteLine("Liczba równa 2");
//                    break;
//                case 3:
//                    Console.WriteLine("Liczba równa 1");
//                    break;
//                case 5:
//                    Console.WriteLine("Liczba równa 2");
//                    break;
//                case 4:
//                    Console.WriteLine("Liczba równa 2");
//                    break;
//                default:
//                    Console.WriteLine("Coś poszło nie tak...");
//                    break;
//            }
//            Console.ReadKey();
//        }
//    }
//}


/* ---------------------------------- ZAD 6 ------------------------------------ */

//namespace zad6
/* Napisz   program,   który   za   pomocą   pętli   wyświetli   w   konsoli   100   losowych   liczbrzeczywistych.Wskazówka:Aby wylosować liczbę rzeczywistą należy użyć metody NextDouble():Random rnd = new Random();double a = rnd.NextDouble(); */

// Bez tablicy
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            for (int i = 0; i < 3; i++)
//            {
//                double liczbaLosowa = rnd.NextDouble();
//                Console.WriteLine(liczbaLosowa);
//            }
//        }
//    }
//}


// Zad6 za pomocą tablicy - ciekawy  Console.WriteLine i tablica na double - random

//class Program
//{
//    static void Main(string[] args)
//    {
//        Random rnd = new Random();
//        double[] tab = new double[3];


//        for (int i = 0; i < tab.Length; i++)
//        {
//            tab[i] = rnd.NextDouble();
//            Console.WriteLine($"Pozycja tab[{i}] = {tab[i]}");
//        }
//        Console.ReadKey();
//    }
//}

/* ------------------------------------------------------------------------------------------ */
// Poniższy przykład tworzy tablicę int elementów, inicjuje tablicy i drukuje zawartość tablicy

//using System;
//class ArrayExample
//{
//    static void Main()
//    {
//        int[] a = new int[10];
//        for (int i = 0; i < a.Length; i++)
//        {
//            a[i] = i * i;
//        }
//        for (int i = 0; i < a.Length; i++)
//        {
//            Console.WriteLine($"a[{i}] = {a[i]}");
//        }
//    }
//}

/* -------------------------------  ZAD 7 ---------------------------------------------------- */
//namespace zad7
// Zmodyfikuj pętlę for tak aby wyrażenie początkowe znalazło się przed pętlą, a wyrażeniemodyfikujące i warunkowe wewnątrz pętli.
// Właściwie puszczamy pustego for po to by wypełnił się if w środku, ale że nie ma blokady dajemy else i break na końcu, bo pętla by się nie skończyła

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] tab = { 100, 200, 300, 400 };


//            for (int i=0; ;)
//            {
//                if (i < tab.Length)
//                {
//                    Console.WriteLine(tab[i]);
//                    i++;
//                }
//                else
//                    break;
//            }
//            Console.ReadKey();
//        }
//    }

//}

/* ----------------------------------  ZAD 8 ----------------------------------- 
 * Napisz program który za pomocą pętli for wypisze na ekranie 50 losowych liczb całkowitych niepodzielnych przez 3. Użyj instrukcji continue.Aby sprawdzić czy liczba jest podzielna przez inną liczbę należy posłużyć się dzieleniemmodulo:if (zmienna % 3 == 0){// ...  */

//namespace zad8

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            int liczbaLosowa;

//            for (int liczbaWydrukow = 0; liczbaWydrukow < 50; )
//            {
//                liczbaLosowa = rnd.Next(0,1000);
//                if (liczbaLosowa % 3 == 0)
//                {
//                    continue;
//                }
//                else
//                {
//                    ++liczbaWydrukow;
//                    Console.WriteLine($"liczba {liczbaWydrukow}: {liczbaLosowa}");
//                }
//            }
//        }
//    }
//}


/* ------------------------------- ZAD 9 ------------------------------------------------- */
// Zmodyfikować zad 8 by zastosowac pętle while; while (warunek){// dopóki warunek jest spełniony będą wykonywane instrukcje tutaj zapisane}

//namespace zad9

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            int liczbaLosowa;
//            int liczbaWydrukow = 0;

//            while (liczbaWydrukow < 5)
//            {
//                liczbaLosowa = rnd.Next(0, 1000);
//                if (liczbaLosowa % 3 == 0)
//                // jeśli liczba wylosowana jest podzielna przez 3 (nie daje reszty z dzielenia przez 3) np. 9 % 3 = 0, a 7 % 3 = 1 to wykonaj continue; jeśl nie to else => wypisujemy i zliczamy
//                {
//                    continue; // kontynuuje, ale nie przechodzi do else tylko robi nowe okrążenie
//                }
//                else
//                {
//                    ++liczbaWydrukow;
//                    Console.WriteLine($"liczba {liczbaWydrukow}: {liczbaLosowa}");
//                }
//                {
//                }
//            }
//        }
//    }
//}




/* ------------------------- ZAD 10 ------------------------------------------- 
Korzystając z pętli do... while wypisz w kolejności malejącej liczby nieparzyste z zakresuod 50 do 1.Wskazówka:Konstrukcja pętli do... while do{// dopóki warunek jest spełniony będą wykonywane instrukcje tutaj zapisane}while (warunek) */

//namespace zad10

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 49;
//            int liczbaPrzejsc = 0;

//            do
//            {
//                liczbaPrzejsc++;
//                Console.WriteLine($"Liczba {liczbaPrzejsc}: {a}");
//                a -= 2;
//            }
//            while (a >= 1);
//            Console.ReadKey();
//        }
//    }
//}



/* --------------------------------ZAD ------------------------------------------------------- */
// Porównanie float, decimal, double

//namespace zad11

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            float f1 = 12.00f, f2 = 0.008f, f3 = 3e-3f;
//            double d4 = 12.00, d5 = 0.008, d6 = 3e-3;
//            decimal m7 = 12.00m, m8 = 0.008m, m9 = 3e-3m;

//            Console.WriteLine($"FLOAT: {f1}  {f2}  {f3}");
//            Console.WriteLine($"DOUBLE: {d4}  {d5}  {d6}");
//            Console.WriteLine($"DECIMAL: {m7}  {m8}  {m9}");

//        }
//    }
//}


/* --------------------------  ZAD 11 ------------------------------------------ */
// DOwolna tablica + wyświetlenie długości tablicy - przypisywanie wartości, deklatacji tablicy

//namespace zad11

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            float[] tablica = new float[5] { 32.0f, 44.0f, 12f, 0.89f, 0 };
//            //            int[] liczba = { 1, 2, 3, 4, 5 };     można też napisać od razu w deklaracji wszystkie wartosci tablicy
//            Console.WriteLine($"Dlugosc tablicy: {tablica.Length}");

//            for (int i = 0; i < tablica.Length; i++)
//            {
//                Console.WriteLine($"pozycja {i}: {tablica[i]}");
//            }

//            Console.ReadKey();
//        }

//    }
//}


/* -------------------------------- ZAD 12 --------------------------------------------- */
// Utwórz tablicę 2-wymiarową o dowolnej długości i zapełnij ją dowolnymi liczbami – np.losowymi albo wybranymi w inny sposób. Oblicz sumę wszystkich elementów tablicy i wyświetl ją w konsoli
//namespace zad12

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int sumaTablicy = 0;
//            int[,] tablica = new int[3, 4]{        // 2 wiersze na 3 kolumny
//            {1,2,4,9 }, // wiersz o indeksie 0
//            {3,1,5,0 }, // wiersz o indeksie 1
//            {6,7,1,1 } // wiersz o indeksie 2
//            };
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 4; j++)
//                {
//                    Console.WriteLine($"a[{i},{j}] = {tablica[i, j]}");
//                    sumaTablicy += tablica[i,j];
//                }
//            }
//            Console.WriteLine( $"Suma Tablicy wynosi: {sumaTablicy}");
//            Console.ReadKey();
//        }
//    }
//}


/* ---------------------- ZAD 12 ------------------------------------------------ */
// zadanie 12 zrobione według tego co J.Mosakowski z użyciem Get.Lenght(0) bez pokazywania elementów, ale oblicza sumę

//namespace Cw_01_12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Deklaracje
//            int[,] tablica = new int[50, 10];
//            int suma = 0;
//            // Zapelnij tablice
//            for (int i = 0; i < tablica.GetLength(0); ++i)
//            {
//                for (int j = 0; j < tablica.GetLength(1); ++j)
//                {
//                    tablica[i, j] = i * j;
//                }
//            }
//            // Policz sume wszystkich elementow tablicy i wydrukuj ja na ekranie
//            for (int i = 0; i < tablica.GetLength(0); ++i)
//            {
//                for (int j = 0; j < tablica.GetLength(1); ++j)
//                {
//                    suma += tablica[i, j];
//                }
//            }
//            Console.WriteLine("Suma elemetów tablicy wynosi: " + suma);
//            Console.ReadKey();
//        }
//    }
//}


/* --------------------------- KONWERSJA BOOL NA INT ------------------------------- */

//namespace zad11

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool falseFlag = false;
//            bool trueFlag = true;

//            Console.WriteLine("{0} converts to {1}.", falseFlag,
//                              Convert.ToInt32(falseFlag));
//            Console.WriteLine("{0} converts to {1}.", trueFlag,
//                              Convert.ToInt32(trueFlag));
//            Console.ReadKey();
//        }
//    }
//}




/* -----------------------  ZADANIE -------------------------------------------- */
// Podaje z ręki ilosc elementów tablicy oraz wyliczam ich sumę
//class Program
//{
//    static void Main(string[] args)
//    {
//        int i, n, wynik;
//        int[] a;

//        //pobierz dane od uzytkownika
//        Console.WriteLine("Podaj liczbe elementow tablicy");
//        n = int.Parse(Console.ReadLine());
//        a = new int[n];
//        for (i = 0; i < n; i++)
//        {
//            Console.WriteLine("Podaj element a[" + i + "]");
//            a[i] = int.Parse(Console.ReadLine());
//        }

//        //oblicz sume elementow
//        wynik = 0;
//        for (i = 0; i < n; i++)
//        {
//            wynik += a[i];
//        }

//        //podaj wynik
//        Console.WriteLine("Suma elementow tablicy to " + wynik);
//    }
//}





/* 
 * GetLength takes an integer that specifies the dimension of the array that you're querying and returns its length. Length property returns the total number of items in an array:
  Samo Lenght zlicza wszystkie elementy tablicy , a GetLenght(0) - tylko z 1 wiersza

int[,,] a = new int[10,11,12];
Console.WriteLine(a.Length);           // 1320
Console.WriteLine(a.GetLength(0));     // 10
Console.WriteLine(a.GetLength(1));     // 11
Console.WriteLine(a.GetLength(2));     // 12

*/






/* ------------------------------- ZAD 13 ------------------------------------------ */
//namespace zad13

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.ReadKey();
//        }

//    }
//}









//namespace zad12

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.ReadKey();
//        }

//    }
//}