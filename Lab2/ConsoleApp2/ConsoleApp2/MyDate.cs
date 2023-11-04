using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyDate
    {
        public DateTime data;

        public MyDate()
        {
            this.data = DateTime.Now;
        }

        public void tydzienDoPrzodu()
        {
            data = data.AddDays(7);
        }
        public void tydzienDoTylu()
        {
            data = data.AddDays(-7);
        }
    }
}
