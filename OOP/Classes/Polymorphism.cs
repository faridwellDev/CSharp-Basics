using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Polymorphism //Base class (parent)
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Polymorphism
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Polymorphism // Derived class (child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }
}
