using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Logger
    {
        public static void Log(string ClassName, string MethodName, string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, ClassName: {ClassName}, MethodName: {MethodName}, Message: {Message}");
        }
        public static void Log(string uniqueId, string ClassName, string MethodName, string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, UniqueId: {uniqueId}, ClassName: {ClassName}, MethodName:{MethodName}, Message:{Message}");
        }
        public static void Log(string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, Message: {Message}");
        }
        public static void Log(string ClassName, string MethodName, Exception ex)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, ClassName: {ClassName}, MethodName:{MethodName}, Exception Message:{ex.Message}, \nException StackTrace: {ex.StackTrace}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string ClassName = "Program";
            //    string MethodName = "Main";
            //    string UniqueId = Guid.NewGuid().ToString();
            //    Logger.Log(ClassName, MethodName, UniqueId);
            //    Logger.Log(UniqueId, ClassName, MethodName);
            //    Logger.Log("Message 3");

            //    try
            //    {
            //        int Num1 = 10, Num2 = 0;
            //        int result = Num1 / Num2;
            //        Logger.Log(UniqueId, ClassName, MethodName, "Message 4");
            //    }
            //    catch (Exception ex)
            //    {
            //        Logger.Log(ClassName, MethodName, ex);
            //    }

            //Operator Overloading

            OperatorOverloading c1 = new OperatorOverloading(3,7);
            c1.Display();
            OperatorOverloading c2 = new OperatorOverloading(5,7);
            c2.Display();
            OperatorOverloading c3 = c1 + c2;
            c3.Display();
            //OperatorOverloading c3 = new OperatorOverloading(6,7);
            //c3.Display();
            Console.ReadLine();
        }
    }
}
