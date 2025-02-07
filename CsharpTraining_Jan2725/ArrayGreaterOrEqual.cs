using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class ArrayGreaterOrEqual
    {
        public static void GreaterOrEqual(int[] array)
        {
            int max = array[0];

            List<int> list = new List<int>() { max };
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > max || array[i] == max)
                {
                    max = array[i];
                    list.Add(array[i]);
                }
            }
            Console.WriteLine("ELements are");
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
