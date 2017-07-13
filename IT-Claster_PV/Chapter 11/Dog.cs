using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11
{
    enum Function
    {
        Hunting,
        Fighting,
        Decorative
    }
    class Dog:Animal,VoiceAndAttack,Ignore
    {
        //aditional properties for the dog
        public string Breed { get; set; }//порода
        public Function Function { get; set; }//призначення

        //constructor
        public Dog (string nickName, string type, AnimalSize size, string colour, int age, int pawsNumber, bool isTail, string breed, Function function) :base (nickName, type, size, colour, age, pawsNumber, isTail)
        {
            this.Breed = breed;
            this.Function = function;
        }

        //sound that dog make
        public override string Sound()
        {
            return "\"Wolf wolf!\"";
        }

        //display all info of the dog
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"\tbreed of the cat is {Breed}; function {Function};");
        }

        //Implementation of the methods from interfaces
        public void VoiceAndAttackMethod()
        {
            Console.WriteLine("Dog burks and attack you!");
        }
        public void IgnoreMethod()
        {
            Console.WriteLine("Dog ignores you!");
        }
    }
}
