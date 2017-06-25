using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating new matrix
            Console.WriteLine("New 7x5 matrix\n");
            Random rnd = new Random();
            int[,] someMatrix = new int[7,5];
            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    someMatrix[i, j] = rnd.Next(1, 10);
                    Console.Write("{0,5}", someMatrix[i, j]);
                }
                Console.WriteLine();
            }

            //writing maximum number in row
            int maxInRow = 0;
            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    if (someMatrix[i, j] > maxInRow)
                         maxInRow = someMatrix[i, j];
                    if (j == someMatrix.GetLength(1) - 1)
                        Console.WriteLine($"Maximum number in row {i} is {maxInRow}");

                }
                maxInRow = 0;
                Console.WriteLine();
            }
        }
    }
}
