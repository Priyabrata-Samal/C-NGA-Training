using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class Max
    {
        public int maxElement(int[] array)
        {
            int max = array[0];
            int min = array[0];
            int diff;
            Console.WriteLine("Max elements is");
            for(int i = 0; i < array.Length; i++)
            {
                if(max < array[i])
                {
                    max = array[i];
                }
                if(min > array[0])
                {
                    min = array[i];
                }
            }
            diff = max - min;
            Console.WriteLine("Minimum elements is " + min);
            Console.WriteLine("Difference between min and max " + diff);
            return max;
        }
    }
}
