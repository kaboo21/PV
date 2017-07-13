using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11
{
    enum FurSize //розмір шерсті
    {
        None,
        Short,
        Long
    }
    class Cat : Animal, RunAway,Ignore
    {
        //aditional properties for the cat
        public string Breed { get; set; }//порода
        public FurSize FurSize { get; set; }//розмір шерсті

        //constructor
        public Cat (string nickName, string type, AnimalSize size, string colour, int age, int pawsNumber, bool isTail, string breed,FurSize fursize):base (nickName, type, size, colour, age, pawsNumber, isTail)
        {
            this.Breed = breed;
            this.FurSize = fursize;
        }
        
        //sound that cat make
        public override string Sound()
        {
            return "\"Meow!\"";
        }

        //display all info of the cat
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"\tbreed of the cat is {Breed}; fur size {FurSize};");
        }

        //Implementation of the methods from interfaces
        public void RunAwayMethod()
        {
            Console.WriteLine("Cat run away from you!");
        }
        public void IgnoreMethod()
        {
            Console.WriteLine("Cat ignores you!");
        }
    }
}
