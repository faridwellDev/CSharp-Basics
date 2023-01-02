using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wellDev_1
{
    internal class Italianchef : Chef 
    {
       public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes bbq ribs");
        }
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }
    }
}
