using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._4_5
{
    class Student
    {
        public string surname;
        public string name;
        public int course;
        public int age;

        public static int studentCounter=0;

        //8.8 static constructor
        static Student()
        {
            Console.WriteLine($"The first student was created at {DateTime.Now}\n");
        }

        //constructor
            public Student (string surname, string name, int course, int age)
        {
            this.surname = surname;
            this.name = name;
            this.course = course;
            this.age = age;
            studentCounter++;
        }

        //Sum of scholarships
        public void scholarshipSum ()
        {
            Console.WriteLine($"\nYou dont write the monce scholaships for {surname} {name}");
        }
        public void scholarshipSum(int s1, int s2=0, int s3=0, int s4=0)
        {
            int sum = s1 + s2 + s3 + s4;
            Console.WriteLine($"\n{surname} {name}    sum of monce scholarship is - {sum}");
        }
    }
}
