using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car : Vehicle
    {
        //public string color = "red";
        //public int maxSpeed = 200;
        //public string model;

        //public void fullThrottle()
        //{
        //    Console.WriteLine("The car is going as fast as it can!");
        //}

        //public Car(string modelName)
        //{
        //    model = modelName;
        //}

        // Properties

        //private string name; //field
        //public string Name //property
        //{
        //    get { return name; } //get method
        //    set { name = value; } //set method
        //}

        //Short hand property
        //public string Name  // property
        //{ get; set; }

        public string modelName = "Mustang"; //car field
    }
}
