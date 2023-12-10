using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Data_Structures___Part_1.Algorthms
{
    static class BinarySearch
    {
        public static int BinarySearchAlgo(int[] array, int target)
        {
            int target_index = 0;
            int min = 0;
            int max = array.Length - 1;
            while (min < max)
            {
                int middle = (min + max) / 2;
                if (array[middle] == target)
                {
                    target_index = middle;
                    return target_index;
                }
                else if (array[middle] < target_index)
                {
                    min = middle;

                }
                else { max = middle; }



            }
            return target_index;

        }
    }
}
