using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._6_7
{
    static class Matem
    {
        //output the values of the array
        static public void Info(int[] arr)
        {
            Console.WriteLine("Values of the array");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "  ");
            Console.WriteLine();
        }

        //output the max value of the array
        static public void MaxInArray(int[] arr)
        {
            Console.WriteLine($"\nMaximum value of the array is {arr.Max()}");
        }
    }
}
