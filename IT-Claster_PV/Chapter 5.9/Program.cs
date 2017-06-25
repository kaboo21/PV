using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating new matrix
            Console.WriteLine("New 3x8 matrix\n");
            Random rnd = new Random();
            int[,] someMatrix = new int[3, 8];
            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    someMatrix[i, j] = rnd.Next(1, 10);
                    Console.Write("{0,5}", someMatrix[i, j]);
                }
                Console.WriteLine();
            }

            //Counting even numbers
            int evenNumbers = 0;
            for (int i = 0; i < someMatrix.GetLength(0); i++)
            
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                    if (someMatrix[i, j] % 2 == 0)
                        evenNumbers++;
            Console.WriteLine($"There are {evenNumbers} even numbers in the matrix");
              

        }
    }
}
