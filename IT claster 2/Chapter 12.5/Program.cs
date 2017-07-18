using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Chapter_12._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chapter 12 ex.5
            string someText1 = "+01:23:45:67:89:AB   01:23:45:67:89:Az";
            Console.WriteLine("Find correct MAC adress in text:\n {0}\n", someText1);
            Regex reg1 = new Regex("([0-F]{2}:){5}[0-F]{2}");
            MatchCollection macAddresses = reg1.Matches(someText1);
            foreach (Match macAddress in macAddresses)
            Console.WriteLine("Correct adress is - {0}\n",macAddress.Value);

            //Chapter 12 ex.6
            string someText2 = "+3 (050) 12-34-567  050-12345-67";
            Console.WriteLine("\n\nFind correct tellephone number in text:\n {0}\n", someText2);
            Regex reg2 = new Regex("\\+3 \\(0\\d{2}\\) \\d{2}-\\d{2}-\\d{3}");
            MatchCollection tellNumbers= reg2.Matches(someText2);
            foreach (Match tellNumber in tellNumbers)
                Console.WriteLine("Correct tellephon number is - {0}\n", tellNumber.Value);

        }
    }
}
