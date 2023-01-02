using AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccessSpecifiers
{
    public class Program
    {
        static void Main(string[] args)
        {
            AnotherAssemblyClass2 name = new AnotherAssemblyClass2();
            name.Display3();
            Console.ReadLine();
        }
    }
    public class AnotherAssemblyClass1 : AssemblyOneClass1
    {
        public void Display4()
        {
            //You cannot access the private member from the derived class
            //from other assemblies
            Console.WriteLine(Id); //Compile time error
            Console.ReadLine();
        }
    }

    public class AnotherAssemblyClass2
    {
        public void Display3()
        {
            //You cannot access the private member from the non-derived classes
            //from other assemblies
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.Id); //Compile time errror
            Console.ReadLine(); 
        }
    }
}
