using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class MoveZero
    {
        public static void moveZero(int[] array)
        {
            int count = 0;
            Console.WriteLine("Updated elements");
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] != 0)
                {
                    Console.WriteLine(array[count++] = array[i]);
                }
            } 
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the size of the array");
        //    int size = Convert.ToInt32(Console.ReadLine());
        //    int[] array = new int[size];
        //    Console.WriteLine("Enter the array elements");
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    MoveZero.moveZero(array);
        //}

    }
}
