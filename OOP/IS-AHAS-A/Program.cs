using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace IS_AHAS_A
{
    internal class Program
    {

        //Is-A relationship
        static void Main(string[] args) 
        {
            //Cuboid cuboid = new Cuboid(3, 5, 7);
            //Console.WriteLine($"Volume is : {cuboid.Volume()}");
            //Console.WriteLine($"Area is : {cuboid.Area()}");
            //Console.WriteLine($"Permiter is : {cuboid.Perimeter()}");

            //HAS-A Relationship

            Address address = new Address("B1-3029", "BBSR", "Odisha");
            Employee employee = new Employee(1001, "Ramesh", address);
            employee.Display();


            Console.ReadLine();
        }
    }

    //Has-A Relationship

    class Address
    {
        public string AddressLine, City, State;
        public Address(string addressLine, string city, string state)
        {
            AddressLine = addressLine;
            City = city;
            State = state;
        }
    }
    class Employee
    {
        //Using Address is Employee class
        //Establishing Has-A relationship i.e. Employee Has-A Address
        public Address address;
        public int Id;
        public string Name;
        public Employee(int id, string name, Address adrs)
        {
            Id = id;
            Name = name;
            address = adrs;
        }
        public void Display()
        {
            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"AddressLine: {address.AddressLine}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"State: {address.State}");
        }
    }

    //IsA Relationship

    //class Rectangle
    //{
    //    //Data Members
    //    public int Length;
    //    public int Breadth;

    //    //Member Functions
    //    public int Area()
    //    {
    //        return Length * Breadth;
    //    }
    //    public int Perimeter()
    //    {
    //        return 2 * (Length + Breadth);
    //    }
    //}

    //Establishing Parent-Child Relationship
    //IS-A relationship i.e. Cuboid IS-A Rectangle

    //class Cuboid : Rectangle
    //{
    //    public int Height;
    //    public Cuboid(int l, int b, int h)
    //    {
    //        Length = l;
    //        Breadth = b;
    //        Height = h;
    //    }
    //    public int Volume()
    //    {
    //        return Length * Breadth * Height;
    //    }
    //}

}
