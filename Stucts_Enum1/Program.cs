using System.Security.Cryptography.X509Certificates;

namespace Stucts_Enum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //var myColor = Color.Red;
            //Console.WriteLine(myColor);

            //Casting to Value

            var myColor = Color.Black;
            var myColorValue = (int)myColor;
            Console.WriteLine(myColorValue); //3

            var myColor2 = 4;
            var myColorEnum = (Color)myColor2;
            Console.WriteLine(myColorEnum); //White

            //Enumeration as Bit Flags
            //Months birthdayMonths = Months.January
            //            | Months.March
            //            | Months.September
            //            | Months.November;

            //Console.WriteLine($"Your family has birthdays in {birthdayMonths}");
            ////Output: Your family has birthdays in January, March, September, November

            Months birthdayMonths = Months.January
                        | Months.March
                        | Months.September
                        | Months.November;

            Months otherBirthdays = Months.January
                                    | Months.April
                                    | Months.September;

            Console.WriteLine($"The months in both groups are {birthdayMonths & otherBirthdays}");
            //Output: The months in both groups are January, September
        }
        public enum Color //By default it is int type but we can modify it like : public enum Color : short
        {
            Red = 1, Green = 2, Black = 3, White = 4
        }

        //Enumerations as Bit Flags
        [Flags]
        public enum Months
        {
            January = 1, //2^0
            February = 2, //2^1
            March = 4, //2^2
            April = 8, //2^3
            May = 16, //2^4
            June = 32, //2^5
            July = 64, //2^6
            August = 128, //2^7
            September = 256, //2^8
            October = 512, //2^9
            November = 1024, //2^10
            December = 2048 //2^11
        }

    }
}