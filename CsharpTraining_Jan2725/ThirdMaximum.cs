using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class ThirdMaximum
    {
        public int ThirdMax(int[] nums)
        {
            int FirstMax = 0, SecondMax = 0, ThirdMax = 0;

            foreach(int num in nums)
            {
                if(num == FirstMax || num == SecondMax || num == ThirdMax)
                {
                    continue;
                }
                else if(num >  FirstMax || FirstMax == num)
                {
                    ThirdMax = SecondMax;
                    SecondMax = FirstMax;
                    FirstMax = num;
                }
                else if(num >  SecondMax || num == SecondMax)
                {
                    ThirdMax = SecondMax;
                    SecondMax = num;
                }
                else
                {
                    ThirdMax = num;
                }
            }
            return ThirdMax;
        }
    }
}