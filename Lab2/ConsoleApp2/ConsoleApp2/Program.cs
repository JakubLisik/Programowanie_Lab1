using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie1();
            //zadanie2();
            zadanie3();
        }
        static void zadanie1()
        {
            Licz licz = new Licz(89);
            licz.pisz();
            licz.dodaj(22);
            licz.pisz();
            licz.odejmij(8);
            licz.pisz();

            Licz nowyObjekt = new Licz(23);
            nowyObjekt.dodaj(12);
            nowyObjekt.pisz();
        }

        static void zadanie2()
        {
            int[] oceny = { 3, 5, 4, 2, 1, 2 };
            Sumator dane = new Sumator(oceny);
            Console.WriteLine(dane.Suma());
            Console.WriteLine(dane.SumaPodziel2());
        }
        static void zadanie3()
        {
            MyDate czasRozpoczeciaZajec = new MyDate();
            Console.WriteLine(czasRozpoczeciaZajec.data);
            czasRozpoczeciaZajec.tydzienDoPrzodu;
            Console.WriteLine("Za tydzień będzie: " + czasRozpoczeciaZajec.data);
        }
    }
    

}
