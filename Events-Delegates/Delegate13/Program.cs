using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Anonymous Method Accessing Variables Defined Outside:
namespace Delegate13
{
    internal class Program
    {
        public delegate string GreetingsDelegate(string name);
        static void Main(string[] args)
        {
            string Message = "Welcome to Dotnet Tutorials";

            GreetingsDelegate gd = delegate (string name)
            {
                return "Hello @" + name + " " + Message;
            };

            string GreetingsMessage = gd.Invoke("Pranaya");
            Console.WriteLine(GreetingsMessage);
            Console.ReadLine();
        }
    }
}
