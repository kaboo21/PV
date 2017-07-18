using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_claster_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chapter 12 ex.1
            Console.WriteLine("Chapter 12 ex.1");
            string someStr1 = "a ab abc abcd abdcde 53abcd...";
            Text.ReplaceWordsInText(ref someStr1, 4, "XXXXXX");
            Console.WriteLine(someStr1);

            //Chapter 12 ex.2
            Console.WriteLine("Chapter 12 ex.2");
            string someStr2 = "a ab abc abcd abdcde 53abcd...";
            string someStr3 = someStr2.Insert(4, "YYYYYY");
            Console.WriteLine(someStr3);

            //Chapter 12 ex.4
            Console.WriteLine("Chapter 12 ex.4");
            string someStr4 = "a ab abc abcd abdcde 53abcd...";
            Text.UpperWords(ref someStr4);
            Console.WriteLine(someStr4);

        }
    }
}
