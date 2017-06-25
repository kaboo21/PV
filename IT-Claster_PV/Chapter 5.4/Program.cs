using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating new array
            Console.WriteLine("New array of 30 integers");
            Random rnd = new Random();
            int []someArr=new int[30];
            for (int i=0;i<someArr.Length;i++)
            {
                someArr[i] = rnd.Next(1, 30);
                if (i % 5 == 0)
                    Console.WriteLine();
                Console.Write("{0,5}",someArr[i]);
            }

            //searching indexes of the max value
            int maxValue = someArr.Max();
            int[] indexArr= new int[someArr.Length];
            int indexNumber = 0;
            for (int i = 0; i < someArr.Length; i++)
            {
                if (someArr[i] == maxValue)
                {
                    indexArr[indexNumber] = i+1;
                    indexNumber++;
                }
            }
            //output indexes
            Console.WriteLine($"\nIndex/es of maximum value ({maxValue}) in array");
            for (int i=0;i<indexNumber;i++)
                Console.WriteLine("{0,5}",indexArr[i]);


        }
    }
}
