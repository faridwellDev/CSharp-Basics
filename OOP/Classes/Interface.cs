using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Interfaces can contain properties and methods, but not fields.

namespace Classes
{
    //interface Interface
    //{
    //    void animalSound(); //interface method (does not have a body)
    //}

    //// Pig "implements" the Interface 
    //class Doll : Interface
    //{
    //    public void animalSound()
    //    {
    //        // The body of animalSound() is provided here
    //        Console.WriteLine("The Doll says: How you doin?");
    //    }
    //}

    //Multiple inheritance using interface

    interface IFirstInterface
    {
        void myMethod();
    }

    interface ISecondInterface
    {
        void myOtherMethod();
    }


    //Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod() 
        {
            Console.WriteLine("Some text...");
        }
        public void myOtherMethod() {
            Console.WriteLine("Some other text...");
        } 
    }
}
