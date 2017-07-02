using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._1
{
    class Matem
    {
        //output the values of the array
        public void Info(int[] arr)
            {
                Console.WriteLine("Values of the array");
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + "  ");
                Console.WriteLine();
            }

        //output the max value of the array
        public void MaxInArray(int[] arr)
            {
                Console.WriteLine($"\nMaximum value of the array is {arr.Max()}");
            }

        //output sum/product of the array
            public void SumOrProduct(int[] arr)
        {
            int sum=0, product=1;
            ConsoleKey key;
            Console.WriteLine("\nDo you want to know Sum or Product of values in the array " +
                "press \"+\" for sum and \"*\" for Product");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.Add)
            {
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
                Console.WriteLine($"\nSum of values of the array is {sum}");
            }
            else if (key == ConsoleKey.Multiply)
            {
                for (int i = 0; i < arr.Length; i++)
                    product *= arr[i];
                Console.WriteLine($"\nProduct of values of the array is {product}");
            }


        }
    }
}
