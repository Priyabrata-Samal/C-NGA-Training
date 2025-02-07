using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class Kdanes
    {
        public static void Kdane(int[] array)
        {
            int max = 0;
            for(int i = 0; i < array.Length; i++)
            {
                int total = 0;
                for (int j = i; j < array.Length; j++)
                {
                    total += array[j];
                    if (total > max)
                    {
                        max = total;
                    }
                }
            }
            Console.WriteLine($"Maximum Kdane element {max}");
        }
    }
}
