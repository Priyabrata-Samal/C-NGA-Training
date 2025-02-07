using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class CountLeaders
    {
        public static void CountLead(int[] array)
        {
            int count = 0;
            int max = array[array.Length - 1];
            List<int> lead = new List<int>() { max };
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    lead.Add(array[i]);
                    count++;
                }
            }
            Console.WriteLine(count + " ");
        }
    }
}
