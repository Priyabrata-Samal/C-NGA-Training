using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class MissingNumbers
    {
        public static void MissingNumber(int[] array)
        {
            int count = 1;
            for (int i = 0; i < array.Length; i++) 
            {
                for (int j = i + 1; j < array.Length; j++) 
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            if (array[array.Length - 1] == 1)
            {
                Console.WriteLine($"Missing number is {2}");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != count)
                    {
                        Console.WriteLine("Missing numbers is " + count);
                        return;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
        }
    }
}
