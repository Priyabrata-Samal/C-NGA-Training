using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class JackedArray
    {
        public void jackedArray(int[][] array)
        {
            for(int i = 0; i <  array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine(array[i][j]);
                }
            }
        }
    }
}
