using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a three-digit number");
            
            //read number from keyboard
            string threeDigitNumberString=Console.ReadLine();

            //check if number is threedigit
            if (threeDigitNumberString.Length == 3)
            {
                int threeDigitNumber;
                //check if it is a number
                if (Int32.TryParse(threeDigitNumberString, out threeDigitNumber))
                {
                    //digites of number
                    int num1 = threeDigitNumber % 10;
                    int num2 = threeDigitNumber % 100 / 10;
                    int num3 = threeDigitNumber / 100;
                    //product of three-digit number
                    int product = num1 * num2 * num3;
                    Console.WriteLine($"Product of three-digit number is {product}");

                }
                else
                    Console.WriteLine("You write not a number");
            }
            else
                Console.WriteLine("It is not three-digit number");           
            
        }
    }
}
