using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Sumator
    {
        private int[] liczby;

        public Sumator()
        {
            liczby = new int[] {};
        }
        public Sumator(int [] liczby)
        {
            this.liczby = liczby;
        }
        public int ileElementow()
        {
            return liczby.Length;
        }
        public void pisz()
        {
            Console.WriteLine("Elementy tablicy: ");
            foreach (int elem in liczby)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
        public void pisz(int lowIndex, int highIndex)
        {
            if (lowIndex < 0)
            {
                lowIndex = 0;
            }
            if(highIndex>= liczby.Length)
            {
                highIndex = liczby.Length - 1;
            }
            Console.WriteLine("Elementy tablicy: ");
            for (int i=lowIndex; i<highIndex; i++)
            {
                Console.Write(liczby[i] + " ");
            }
            Console.WriteLine();

        }
        public int Suma()
        {
            int suma = 0;

            foreach (int elem in liczby)
            {
                suma += elem;
            }

            return suma;
        } 
        public int SumaPodziel2()
        {
            int suma = 0;

            foreach (int elem in liczby)
            {
                if (elem % 2 == 0)
                {
                    suma += elem;
                }
            }

            return suma;
        }
    }
}
