using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class IntersectiomArray
    {
        public void Intersection(int[] array1, int[] array2)
        {
            HashSet<int> set1 = new HashSet<int>(array1);
            HashSet<int> result = new HashSet<int>();

            foreach (int i in set1) 
            {
                if (set1.Contains(i))
                {
                    result.Add(i);
                }
            }
            Console.WriteLine("Intersection elements: " + string.Join(" ", result)); 
        }
    }
}
