using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Anonymous Method Real-Time Example in C#
namespace Delegate14
{
    // Step1
    // Create a class called Employee with
    // ID, Name, Gender and Salary Properties
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<Employee> employeePredicate = new Predicate<Employee>(IsEmployeeExist);

            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Pranaya", Gender = "Male", Salary = 100000},
                new Employee{ ID = 102, Name = "Priyanka", Gender = "Female", Salary = 200000},
                new Employee{ ID = 103, Name = "Anurag", Gender = "Male", Salary = 300000},
                new Employee{ ID = 104, Name = "Preety", Gender = "Female", Salary = 400000},
                new Employee{ ID = 104, Name = "Sambit", Gender = "Male", Salary = 500000},
            };

            Employee employee = listEmployees.Find(x => employeePredicate(x));
            Console.WriteLine(@"ID : {0}, Name : {1}, Gender : {2}, Salary : {3}", employee.ID, employee.Name, employee.Gender, employee.Salary);
            Console.ReadLine();
        }
        public static bool IsEmployeeExist(Employee Emp)
        {
            return Emp.ID == 103;
        }
    }
}
