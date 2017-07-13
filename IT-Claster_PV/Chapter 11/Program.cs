using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cat cat1 = new Cat ("Samon", "Chordata", AnimalSize.Small, "white",5,4,true, "Maine coon",FurSize.Short);
            cat1.DisplayInfo();
            Console.WriteLine(cat1.Sound() + "\n");

            Dog dog1 = new Dog ("Rex", "Chordata", AnimalSize.Big, "Broun", 7, 4, true, "Shepherd", Function.Hunting);
            dog1.DisplayInfo();
            Console.WriteLine(dog1.Sound()+"\n");

            Console.WriteLine("if you come in CAT:");
            cat1.RunAwayMethod();
            cat1.IgnoreMethod();
            Console.WriteLine();

            Console.WriteLine("if you come in DOG:");
            dog1.IgnoreMethod();
            dog1.VoiceAndAttackMethod();

        }
    }
}
