using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class MissingNumber
    {
        public int missingNumber(int[] array)
        {
            int n = array.Length;
            int sum = n * (n + 1) / 2;
            Console.WriteLine("Missing number is");
            int actualsum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                actualsum += array[i];
            }
            return sum - actualsum;
        }
    }
}
