using System;

namespace CsharpTraining_Jan2725
{
    public struct MyStruct
    {
        public int x;

        public MyStruct(int x)
        {
            this.x = x;
        }

        public void Method1()
        {
            Console.WriteLine("The method is " + x);
        }
    }
}