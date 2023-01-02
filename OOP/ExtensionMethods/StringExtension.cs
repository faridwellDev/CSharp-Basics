using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    //public static class StringExtension
    //{
    //    //public static int GetWordCount(this string inputString)
    //    //{
    //    //    if(!string.IsNullOrEmpty(inputString))
    //    //    {
    //    //        //Split the string by a space
    //    //        string[] strArray = inputString.Split(' ');
    //    //        return strArray.Count();
    //    //    }
    //    //    else
    //    //    {
    //    //        return 0;
    //    //    }
    //    //}
    //}
    
    class Program1
    {
        static void Main(string[] args)
        {
            //string myWord = "Welcome to Dotnet Tutorials Extension Methods Article";
            //int wordCount = myWord.GetWordCount();
            //Console.WriteLine("string : " + myWord);
            //Console.WriteLine("Count: " + wordCount);
            //Console.ReadLine();

            //LINQ
            List<int> intList = new List<int>()
            {
                10,20,30,31,32
            };

            //If you go to the definition of Where method, then you will see that
            //it is implemented as an extension method
            var List1 = intList.Where(x => x > 20).ToList();
            foreach(int x in List1) {
                Console.Write(x + " ");
            }

            Console.ReadLine();

            //Here, if you go to the definition of the Where method, then you will
            //see that it is implemented as an extension method as shown in the below image.

            //public static IEnumerable<TSource> Where <TSource> (this IEnumerable<TSource> source, Func(TSource, bool> predicted);
        }
    }
}
