using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class Person
    {
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void setAge(int age)
        {
            Console.WriteLine("My age is " + age);
        }
    }
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying on the screen");
        }
        public void showAge(int age)
        {
            Console.WriteLine("My age is " + age);
        }
    }
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I am explaning");
        }
    }
}
