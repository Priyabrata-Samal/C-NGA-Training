using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class Concatenate
    {
        public void concatenateArray(string[] array)
        {
            Console.WriteLine("Array elements are");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}
