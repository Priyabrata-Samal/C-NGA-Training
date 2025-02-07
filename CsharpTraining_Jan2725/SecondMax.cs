using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class SecondMax
    {
        public int SecMax(int[] array)
        {
            int max = 0;
            int sec = 0; ;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max || max == array[i])
                {
                    sec = max;
                    max = array[i];
                }
                else if (array[i] > sec && array[i] < max)
                {
                    sec = array[i];
                }
            }
            return sec;
        }
    }
}
