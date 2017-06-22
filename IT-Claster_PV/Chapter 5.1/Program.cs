using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("New array of 100 integers");
            Random ran = new Random();
            int[] someArr = new int[100];
            for (int i = 0; i < someArr.Length; i++)
            {
                someArr[i] = ran.Next(1, 999);
                Console.Write(someArr[i] + "  ");
            }
            Console.WriteLine("\nSum of the array is "+someArr.Sum());


        }
    }
}
