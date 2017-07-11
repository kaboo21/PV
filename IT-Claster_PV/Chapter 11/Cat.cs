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
    class Cat : Animal
    {
        public string Breed { get; set; }//порода
        public FurSize FurSize { get; set; }//розмір шерсті

        public Cat (string nickName, string type, AnimalSize size, string colour, int age, int pawsNumber, bool isTail, string breed,FurSize fursize):base (nickName, type, size, colour, age, pawsNumber, isTail)
        {
            this.Breed = breed;
            this.FurSize = fursize;
        }

        public override string Sound()
        {
            return "Meow";
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"breed of the cat is {Breed}; fur size {FurSize};");
        }
    }
}
