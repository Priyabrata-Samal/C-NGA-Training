using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public delegate void GetMethod();
    public class DelegatesDemo
    {
        public void Method1()
        {
            Console.WriteLine("Running method 1");
        }
        public void Method2(int i)
        {
            Console.WriteLine("Running method 2" + i);
        }
        public void Method3()
        {
            Console.WriteLine("Running method 3");
        }
        public void Method4()
        {
            Console.WriteLine("Running method 4");
        }
        public void Method5()
        {
            Console.WriteLine("Running method 5");
        }
    }
}
