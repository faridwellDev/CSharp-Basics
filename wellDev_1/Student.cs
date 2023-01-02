using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace wellDev_1
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;
        public static int songCount = 0;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
            songCount++; 
        }

        public int getSongCount()
        { return songCount;
        }
        //Getter & Setter Method

        //public double Result
        //{
        //    get { return gpa; }
        //    set
        //    {
        //        if (value >= 3.5)
        //        {
        //            gpa = value;
        //        }
        //        else
        //        {
        //            gpa = 0;
        //        }
        //    }
            //public bool HasHonors()
            //{
            //    if (gpa > 3.5)
            //        return true;
            //    return false;
            //}
     
    }
}
