using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New array of 20 integers");
            Random ran = new Random();
            int[] someArr = new int[20];
            int sum = 0;
            for (int i=0;i<someArr.Length;i++)
            {
                someArr[i] = ran.Next(0, 10);
                Console.WriteLine(someArr[i] + "  ");
                if (i % 2 == 0)
                    sum += someArr[i];
            }
            Console.WriteLine($"Sum of even numbers is {sum}");


        }
    }
}
