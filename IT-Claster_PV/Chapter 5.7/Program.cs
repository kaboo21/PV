using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating new array
            Console.WriteLine("New 5x5 matrix\n");
            Random rnd = new Random();
            int[,] someArr = new int[5,5];
            for (int i = 0; i < someArr.GetLength(0); i++)
            {
                for (int j = 0; j < someArr.GetLength(1); j++)
                {
                    someArr[i,j] = rnd.Next(1, 10);
                Console.Write("{0,5}", someArr[i,j]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nArray with diagonal of zeros\n");
            for (int i = 0; i < someArr.GetLength(0); i++)
            {
                for (int j = 0; j < someArr.GetLength(1); j++)
                {
                    if (i == j)
                        someArr[i, j] = 0;
                    Console.Write("{0,5}", someArr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
