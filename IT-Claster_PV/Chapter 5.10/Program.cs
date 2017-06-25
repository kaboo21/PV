using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating new matrix
            Console.WriteLine("New 3x5 matrix\n");
            Random rnd = new Random();
            int[,] someMatrix = new int[3, 5];
            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    someMatrix[i, j] = rnd.Next(1, 10);
                    Console.Write("{0,5}", someMatrix[i, j]);
                }
                Console.WriteLine();
            }

            //Writing products of the columns numbers
            Console.WriteLine("Products of numbers in columns of the matrix\n");
            int columnProduct = 1;
            for (int j = 0; j < someMatrix.GetLength(1); j++)
            {
                for (int i = 0; i < someMatrix.GetLength(0); i++)
                {
                    columnProduct *= someMatrix[i, j];
                }
                Console.Write("{0,5}",columnProduct);
                columnProduct = 1;
            }
        }
    }
}
