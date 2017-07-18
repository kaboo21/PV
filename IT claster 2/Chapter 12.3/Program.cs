using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chapter 12 ex.3
            string someString = "a ab abc abcd abc abcd aa ab a    12aa...";
            Console.WriteLine(someString);
            TextCl.DisplayWordsRepeat(someString);
        }
    }
}
