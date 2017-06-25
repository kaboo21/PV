using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating new array
            Console.WriteLine("New array of 50 integers");
            Random rnd = new Random();
            int[] someArr = new int[50];
            for (int i = 0; i < someArr.Length; i++)
            {
                someArr[i] = rnd.Next(1, 70);
                if (i % 5 == 0)
                    Console.WriteLine();
                Console.Write("{0,5}", someArr[i]);
            }

            //read input number
            Console.WriteLine("\nWrite number you want to find");
            int inputNum = Int32.Parse(Console.ReadLine());
            
            //check if there is that number in array
            if (Array.IndexOf(someArr,inputNum)!=0 || someArr[0] == inputNum)
                Console.WriteLine("There is the number in this array");
            else
                Console.WriteLine("There isn't the number in this array");
            
        }
    }
}
