using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class Array
    {
        public void array(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                {
                    Console.WriteLine("The even elements are " + array[i]);
                }
                else
                {
                    Console.WriteLine("The odd elements are " + array[i]);
                }
            }
        }
    }
}
