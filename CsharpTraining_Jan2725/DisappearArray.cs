using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class DisappearArray
    {
        public void DisappearArra(int[] array)
        {
            int n = array.Length;
            int sum = n * (n + 1) / 2;
            int add = 0;
            foreach (int num in array) 
            {
                add += num;
            }
            Console.WriteLine($"The missing number is {sum - add}");
        }
    }
}

