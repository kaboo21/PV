using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11
{
    enum AnimalSize
    {
        Tiny,
        Small,
        Medium,
        Big
    }

    abstract class Animal
    {
        //Properties
        public string NickName { get; set; }
        public string Type { get; set; }
        public AnimalSize Size { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        public int PawsNumber { get; set; }
        public bool IsTail { get; set; }

        //constructor
        public Animal (string nickName, string type, AnimalSize size, string colour, int age, int pawsNumber, bool isTail)
        {
            this.NickName = nickName;
            this.Type = type;
            this.Size = size;
            this.Colour = colour;
            this.Age = age;
            this.PawsNumber = pawsNumber;
            this.IsTail = IsTail;
        }

        //Display general info about the animal
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{NickName}:\ttype {Type}; size {Size}; colour {Colour}; age {Age}; \n\tnumber of paws {PawsNumber}; tail existance {IsTail};");
        }

        //abstract method sound of the animal
        public abstract string Sound ();

    }
}
