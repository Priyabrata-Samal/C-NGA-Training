using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class Person2
    {
        public string name { get; set; }

        public Person2(string name)
        {
            this.name = name;
        }

        public override string ToString() 
        {
            return name;
        }
    }
    public class Student2 : Person2
    {
        public Student2(string name) : base(name) 
        {

        }
        public void Study1()
        {
            Console.WriteLine("The student is Studying");
        }
    }
    public class Teacher2 : Person2
    {
        public Teacher2 (string name) : base(name)
        {

        }
        public void Explaining()
        {
            Console.WriteLine("The teacher is explaning");
        }
    }
}
