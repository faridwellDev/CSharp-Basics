using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//LINQ Query to Array

namespace LINQ1
{
    // Use for loop to fine elements from the collection
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ Query to Array
            /*
            string[] names = { "Bill", "Steve", "James", "Mohan" }; //This is called data source

            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            foreach(var name in myLinqQuery)
            {
                Console.WriteLine(name + " ");
            }
            */

            // Use for loop to fine elements from the collection
            Student[] studentArray =
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
                new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
            };

            Student[] students = new Student[10];

            int i = 0;

            foreach (Student student in studentArray)
            {
                if(student.Age > 12 && student.Age < 20)
                {
                    students[i++] = student;
                    //i++;
                }
            }
            for(int j = 0; j < i; j++)
            {
                Console.WriteLine(students[j].StudentID);
            }
            Console.ReadLine();
        }
    }
}
