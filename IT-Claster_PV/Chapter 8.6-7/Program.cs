using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 6, 4, 8, 9, 6, 5, 2, 3, 4, 9 };
            Matem.Info(arr1);//8.6. output the values of the array
            Matem.MaxInArray(arr1);//8.7. output the max value of the array
        }
    }
}
