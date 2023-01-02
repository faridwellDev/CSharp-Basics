using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example to Understand Delegate in C#:
//Example to Understand Anonymous Methods in C#

namespace Delegate12
{
    internal class Program
    {
        public delegate string GreetingsDelegate(string name);
        //public static string Greetings(string name)
        //{
        //    return "hello @" + name + "Welcome to Dotnet Tutorials";
        //}

        static void Main(string[] args)
        {
            //GreetingsDelegate gd = new GreetingsDelegate(Program.Greetings);
            //We can do the same call using anonymous method
            GreetingsDelegate gd = delegate (string name)
            {
                return "hello @" + name + " Welcome to Dotnet Tutorials";
            };
            string GreetingsMessage = gd.Invoke("Priyanka");
            Console.WriteLine(GreetingsMessage);
            Console.ReadLine();
        }
    }
}
