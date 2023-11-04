using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Licz
    {
        private int value;

        public Licz()
        {
            this.value = 0;
        }
        public Licz(int value)
        {
            this.value = value;
        }

        public int dodaj(int a)
        {
            value += a;
            return value;
        }
        public int odejmij(int a)
        {
            value -= a;
            return value;
        }
        public void pisz()
        {
            Console.WriteLine(this.value);
        }
        public int getValue()
        {
            return this.value;
        }
    }
}
