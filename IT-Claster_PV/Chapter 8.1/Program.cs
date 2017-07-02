using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 6, 4, 8, 9, 6, 5, 2, 3, 4, 9 };
            Matem m1 = new Matem();
            m1.Info(arr1);//8.1. output the values of the array
            m1.MaxInArray(arr1);//8.2. output the max value of the array
            m1.SumOrProduct(arr1);//8.3. output sum/product of the array
        }
    }
}
