using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Abstract
    {
        public abstract void animlaSound();

        public int value = 100;
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    public class Cow : Abstract
    {
        public override void animlaSound()
        {
            Console.WriteLine("The cow says: Humba humba");
        }
    }
}
