using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,counterNumber=0,sum = 0;
            float avarege;

            Console.WriteLine("Write digits");
            //read digits from keyboard
            string input = Console.ReadLine();            
            while (input!="0")
            {
                //check if it digit
                if (Int32.TryParse(input, out number))
                {
                    counterNumber++;
                    sum += number;
                }                
                input = Console.ReadLine();
            }

            avarege = (float)sum / (float)counterNumber;
            Console.WriteLine($"Number of digits\t{counterNumber}\n" +
                $"Sum of digits\t\t{sum}\n" +
                $"Avarage of digits\t{avarege}");

        }
    }
}
