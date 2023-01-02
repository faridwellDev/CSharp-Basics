using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Delegate Real-Time Example1 in C#:

namespace Delegate7
{
    public delegate void WorkPerformedHandler(int hours, string workType);
    public delegate void WorkCompleteHandler(string workType);
    public class Worker
    {
        public void DoWork(int hours, string workType, WorkPerformedHandler del1, WorkCompleteHandler del2)
        {
            //Now, if you go to the Worker class and within the DoWork method,
            //then it allows you to make the delegate instance null.

            //del1 = null; //Allowing to set null
            //del2 = null; //Allowing to set null

            //Do work here and notify the consumer that work has been performed
            for(int i = 0; i < hours; i++)
            {
                //Do Some Processing
                Thread.Sleep(1000);
                //Notify how much works have been done
                del1(i + 1, workType);
            }

            //Notify the consumer that work has been completed
            del2(workType);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(Worker_WorkPerformed);
            WorkCompleteHandler del2 = new WorkCompleteHandler(Worker_WorkCompleted);

            Worker worker = new Worker();
            worker.DoWork(5, "Generating Report", del1, del2);
            Console.ReadLine();
        }

        //Delegate Signature must watch with the method signature
        static void Worker_WorkPerformed(int hours, string workType)
        {
            Console.WriteLine($"{hours} Hours completed for {workType}");
        }

        static void Worker_WorkCompleted(string workType)
        {
            Console.WriteLine($"{workType} work completed");
        }
    }
}
