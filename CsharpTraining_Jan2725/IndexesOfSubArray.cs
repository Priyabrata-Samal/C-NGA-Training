using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class IndexesOfSubArray
    {
        public static void SubArray(int[] array, int target)
        {
            // 1st Approach
            // This approach finds all the sub array elements to match the target elements

            //for(int i = 0; i < array.Length; i++)
            //{
            //    int sum = 0;
            //    for(int j = i; j < array.Length; j++)
            //    {
            //        sum += array[j];
            //        if (target == sum)
            //        {
            //            Console.WriteLine("[" + (i + 1) + "," + (j + 1) + "]");
            //        }
            //    }
            //}

            // 2nd Approach

            int start = 0;
            int sum = 0;

            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                while (sum > target && start < i)
                {
                    sum -= array[start];
                    start++;
                }
                if (sum == target)
                {
                    Console.WriteLine("[" + (start + 1) + "," + (i + 1) + "]");
                    return;
                }
            }
            Console.WriteLine("-1");
        }
    }
}
