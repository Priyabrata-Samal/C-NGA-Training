using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class ArrayLeaders
    {
        public static void ArrayLead(int[] array)
        {
            int max = array[array.Length - 1];

            Console.WriteLine("Leader elements are");
            List<int> lead = new List<int>() { max };
            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                    lead.Add(array[i]);
                }
            }
            lead.Reverse();

            foreach (int i in lead)
            {
                Console.WriteLine(i + " ");
            }
        }

        // public static void Max(int[] array)
        // {
        //     int max = array[0];
        //     int count = 0;
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         if (array[i] > max)
        //         {
        //             max = array[i];
        //         }
        //     }
        //     Console.WriteLine("Max element is: " + max);
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         if (array[i] == max)
        //         {
        //             count++;
        //         }
        //     }
        //     Console.WriteLine("Number elements that is match with the max element is " + count);
        // }
        static void Main(string[] args)
        {
            Console.WriteLine("Program started");
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            ArrayLeaders.ArrayLead(array);
            Console.WriteLine("Program Ended");
        }
    }
}
