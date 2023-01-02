// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using wellDev_1;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //Show something in console
                                               //Console.ReadLine(); //Write something in console
                                               //Console.WriteLine("    /|");
                                               //Console.WriteLine("   / |");
                                               //Console.WriteLine("  /  |");
                                               //Console.WriteLine(" /___|");

            //Varibles and Data types

            //string phrase = "Giraffe Academy " + "is cool";
            //char grade = 'A';
            //int age = 30;
            //double gpa = 3.2;
            //bool isMale = true;

            //String 
            //Console.WriteLine(phrase);
            //Console.WriteLine(phrase.Length);
            //Console.WriteLine(phrase.ToUpper());
            //Console.WriteLine(phrase.Contains("Academy")); //Check string absent or not
            //Console.WriteLine(phrase[0]);
            //Console.WriteLine(phrase.IndexOf("Academy"));
            //Console.WriteLine(phrase.Substring(8, 3)); //starting at index 8 and go to next 3 index
            //Console.WriteLine(phrase.Substring(phrase.IndexOf("Academy")));

            //Console.WriteLine( 5 + 8 * 2 );
            //Console.WriteLine(5.0 / 2);
            //Console.WriteLine(Math.Abs(-40));
            //Console.WriteLine(Math.Pow(2.5, 2));
            //Console.WriteLine(Math.Sqrt(36));
            //Console.WriteLine(Math.Max(4, 90));
            //Console.WriteLine(Math.Round(4.6));


            //Console.Write("Enter your name: ");
            //string userName = Console.ReadLine();
            //string age = Console.ReadLine();

            //Console.WriteLine("Hello " + userName + " You are " + age);
            //Console.ReadLine();

            //Building a calculator

            //Console.Write("Enter a number: ");
            //double num = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(num + num1);
            //Console.ReadLine();

            //Building a madlibs game

            //string color, pluralNoun, celebrity;

            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();

            //Console.Write("Enter a Plural Noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.Write("Enter a celebrity: ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I love " + celebrity);

            //Arrays

            //int[] luckyNumbers = { 4, 8, 15, 16, 17, 18, };
            //string[] friends = new string[10];
            //friends[0] = "Jim";
            //friends[1] = "Kelly";

            //Console.WriteLine(friends[0]);
            //Console.WriteLine(luckyNumbers[2]);

            //Methods
            //cube(6);

            //int cubedNumber = Cube(5);
            //Console.WriteLine(cubedNumber);

            //If statements

            //bool isMale = true;

            //if(isMale)
            //{
            //    Console.WriteLine("This person is male");

            //}
            //else
            //{
            //    Console.WriteLine("This person is not male");
            //}

            // Console.WriteLine(GetMax(10, 8));
            // Building a better Calculator

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter a operator: ");
            //string op = Console.ReadLine();

            //Console.Write("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if(op=="+")
            //{
            //    Console.WriteLine (num1 + num2); 
            //}
            //else if(op =="-")
            //{
            //    Console.WriteLine (num1 - num2);
            //}
            //else if(op =="*")
            //{
            //    Console.WriteLine (num1 * num2);
            //}
            //else
            //{
            //    Console.WriteLine (num1 / num2);
            //}

            //Switch statements
            //Console.WriteLine(GetDay(5));
            //2D Array
            //int[,] numberGrid =
            //{
            //    {1,2 }, {3,4}, {5,6}
            //};
            //int[,] mynewArray = new int[2, 3];
            //Console.WriteLine(mynewArray.Length);
            //Console.WriteLine(numberGrid[1, 1]);

            //Exception Handling

            try
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.ToString());
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally { Console.WriteLine()}
        Console.ReadLine();
        }

        //static string GetDay(int dayNum)
        //{
        //    string dayName;

        //    switch(dayNum)
        //    {
        //        case 0:
        //            dayName = "Saturday";
        //            break;
        //            case 1:
        //            dayName = "Sunday";
        //            break;
        //            case 2:
        //            dayName = "Monday";
        //            break;
        //            case 3:
        //            dayName = "Tuesday";
        //            break;
        //            case 4:
        //            dayName = "Wednesday";
        //            break;
        //            case 5:
        //            dayName = "Thursday";
        //            break;
        //            case 6:
        //            dayName = "Friday";

        //            break;
        //        default:
        //            dayName = "Invalid Number";
        //            break;
        //    }
        //    return dayName;
        //}
        //static int GetMax(int num1, int num2)
        //{
        //    int result;
        //    if(num1 > num2)
        //    {
        //        result = num1;
        //    }
        //    else
        //    {
        //        result = num2;
        //    }
        //    return result;
        //}
        //static int Cube (int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}
        //Book book1 = new Book("Harry Potter", "JK Rowling", 400);

        //Object Methods

        //Console.WriteLine(book1.title);

        //Student student1 = new Student("Farid", "CSE", 2.8);
        //Student student2 = new Student("Zubair", "CSE", 3.6);

        //Console.WriteLine(student1.gpa);
        //Console.WriteLine(Student.songCount);
        //Console.WriteLine(student1.getSongCount());

        //UsefulTools.SayHi("Farid");
        //Console.WriteLine(student2.Result);

        ////Chef chef = new Chef();
        ////    chef.MakeChicken();
        ////    Italianchef chef2 = new Italianchef();
        ////    chef2.MakeChicken();
        ////    chef2.MakePasta();
        ////    chef2.MakeSpecialDish(); 
        ////    Console.ReadLine();
        //}
    }
}
