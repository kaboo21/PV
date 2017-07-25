using System;

namespace Chapter_9
{

    class Student
    {
        //input data
        private string surname;
        private string name;
        private int cource;
        private int age;

        //points 
        private int math;
        private int philosophy;
        private int physics;
        private int biology;

        //point property
        public int Math
        {
            get => math;
            set
            {
                if (value >= 2 && value <= 5)
                    math = value;
                else
                    Console.WriteLine("It's not correct point");
            }
        }
        public int Philosophy
        {
            get => philosophy;
            set
            {
                if (value >= 2 && value <= 5)
                    philosophy = value;
                else
                    Console.WriteLine("It's not correct point");
            }
        }
        public int Physics
        {
            get => physics;
            set
            {
                if (value >= 2 && value <= 5)
                    physics = value;
                else
                    Console.WriteLine("It's not correct point");
            }
        }
        public int Biology
        {
            get => biology;
            set
            {
                if (value >= 2 && value <= 5)
                    biology = value;
                else
                    Console.WriteLine("It's not correct point");
            }
        }

        //autoproperty scholarship
        public int Scholarship {get;set;}


        //Constructor
        public Student(string surname, string name, int cource, int age)
        {
            this.surname = surname;
            this.name = name;
            this.cource = cource;
            this.age = age;
        }

        //method get age
        public int GetAge ()
        {
            return age;
        }

        //method set cource
        public void SetCource (int c)
        {
            cource = c;
        }
        
        //write Name and Surname of the student
        public void NameInfo ()
        {
            Console.WriteLine(surname + " " + name);
        }

        //write points info
        public void PoitsInfo()
        {
            Console.WriteLine("points:{0} {1} {2} {3}\n", math,philosophy,physics,biology);
        }

        //all info of the student
        public void Info()
        {
            Console.WriteLine($"{surname} {name}, {cource} cource, {age} years");
        }

        public void SetPoints (int math, int philosophy, int physics, int biology)
        {
                Math = math;
                Philosophy = philosophy;
                Physics = physics;
                Biology = biology;
        }
    }
}
