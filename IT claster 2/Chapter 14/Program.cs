using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex.1 Complex numbers
            Console.WriteLine($"ex.1 Complex numbers");
            ComplexNumber cNum1 = new ComplexNumber("10+i*15");
            ComplexNumber cNum2 = new ComplexNumber("5 + i * 10");
            Console.WriteLine($"cNum1 = {cNum1}\ncNum2 = {cNum2}\n");

            //ex.2 operators
            Console.WriteLine($"\nex.2 operators");
            Console.WriteLine("cNum1-cNum2 = {0}, cNum1+cNum2 = {1}, cNum1==cNum2 - {2}, cNum1>cNum2 - {3}",cNum1-cNum2, cNum1 + cNum2, cNum1 == cNum2, cNum1>cNum2);

            //ex.3 explicit, implicit operators
            Console.WriteLine($"\nex.3 explicit, implicit operators");
            ComplexNumber cNum3 = (ComplexNumber)"1 + i*2";
            string strCNum = cNum3;
            cNum3.RealPart = 100;
            Console.WriteLine(cNum3);
            Console.WriteLine(strCNum);

            //ex.6 Indexers
            Console.WriteLine($"\nex.6 Indexers");
            ComplexSet cSet = new ComplexSet();
            cSet[0] = (ComplexNumber)"10 + i * 15";
            cSet[1] = (ComplexNumber)"5 + i * 10";
            Console.WriteLine($"cSet[0] = {cSet[0]}\ncSet[1] = {cSet[1]}\n");
            Console.WriteLine($"cSet[10+i*15] = {cSet["10+i*15"]}\n");

            //ex.7 write complex number using foreach
            Console.WriteLine($"\nex.7 write complex number using foreach");
            foreach (ComplexNumber comNum in cSet)
                Console.WriteLine(comNum);
        }
    }
}
