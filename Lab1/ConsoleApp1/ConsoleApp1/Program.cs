using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Obliczanie delty i pierwiastków");
            Console.WriteLine("Podaj a:");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            double c = Convert.ToInt32(Console.ReadLine());
            double delta = Math.Pow(b,2) - (4 * a * c);
            Console.WriteLine(Math.Sqrt(delta));

            If(delta > 0){
                double x1 = (b * (-1) - Math.Sqrt(delta)) / (2 * a);
                double x2 = (b * (-1) + Math.Sqrt(delta)) / (2 * a);
                Console.Write(x1 + " ");
                Console.Write(x2);
            }
            else if (delta==0) {
            }
            

            double a, b, c;
            a = readDouble();
            b = readDouble();
            c = readDouble();
            Zadanie1(a, b, c);
            */
            Zadanie2();
        }

        static double readDouble()
        {
            Console.WriteLine("Podaj liczbe rzeczywista");
            double a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        static void Zadanie1 (double a, double b, double c)
        {
            //Console.WriteLine(a + b + c);
            double delta = Math.Pow(b, 2) - (4 * a * c);

            if(delta > 0){
                double x1 = (b * (-1) - Math.Sqrt(delta)) / (2 * a);
                double x2 = (b * (-1) + Math.Sqrt(delta)) / (2 * a);
                Console.Write("Pierwiastki: " + x1 + " ");
                Console.Write(x2);
            }
            else if (delta == 0)
            {
                double x0 = (b * (-1)) / (2 * a);
                Console.WriteLine("Pieriwstek: " + x0);
            }
            else
            {
                Console.WriteLine("Brak pierwiastkow");
            }
        }
        static void Zadanie2()
        {
            while (true)
            {
                Console.WriteLine("kakulator");
                Console.WriteLine("1: Suma");
                Console.WriteLine("2: Roznica");
                Console.WriteLine("9: Koniec obliczeń\n");
                Console.WriteLine("Wybierz akcje:");

                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1: Dodawanie(); break;
                    case 2: Odejmowanie(); break;
                    case 2: Odejmowanie(); break;
                    case 2: Odejmowanie(); break;
                    case 9: return;
                    default: Console.WriteLine("Brak takiej opcji"); break;
                }
            }
        }
        static void Dodawanie()
        {
            Console.WriteLine("Podaj dwie liczby");
            double a = readDouble();
            double b = readDouble();
            Console.WriteLine("Wynik dodawania: " + (a + b));
        }
        static void Odejmowanie()
        {
            Console.WriteLine("Podaj dwie liczby");
            double a = readDouble();
            double b = readDouble();
            Console.WriteLine("Wynik odejmowania: " + (a - b));
        }
        static void Mnozenie()
        {
            Console.WriteLine("Podaj dwie liczby");
            double a = readDouble();
            double b = readDouble();
            Console.WriteLine("Wynik mnozenia: " + (a - b));
        }
        static void Dzielenie()
        {
            Console.WriteLine("Podaj dwie liczby");
            double a = readDouble();
            double b = readDouble();
            Console.WriteLine("Wynik dzielenia: " + (a - b));
        }
    }
}
