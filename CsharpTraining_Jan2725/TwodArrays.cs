using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    internal class TwodArrays
    {
        public void TwodArray(int[,] array)
        {
            Console.WriteLine("Entering the array elements");
            for(int i = 0; i< array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Updated array elements are");
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
    }
}

