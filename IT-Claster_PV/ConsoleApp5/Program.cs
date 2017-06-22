using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New array of 50 integers\n");
            Random ran = new Random();
            int[] someArr = new int[50];
            int sum = 0;
            for (int i=0;i<someArr.Length;i++)
            {
                someArr[i] = ran.Next(-10,10);
                Console.Write("{0,6}",someArr[i]);
                if (someArr[i] > 0)
                    sum += someArr[i];
                if ((i+1) % 5 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine($"\nSum of the positive numbers is {sum}");
        }
    }
}
