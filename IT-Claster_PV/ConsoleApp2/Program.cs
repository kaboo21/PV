using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Write a number to get sum");
            int numberSum, sum=0;
            if (Int32.TryParse(Console.ReadLine(), out numberSum))
            {
                for (int i = 1; i <= numberSum; i++)
                    sum += i;
                Console.WriteLine($"Sum of your number is - {sum}");
            }
            else
                Console.WriteLine("You write not a number");
                        
        }
    }
}
