using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._10
{
    class Program
    {
        struct Student
        {
            //general information
            public string name;
            public string surname;
            public int course;
            public int age;

            internal enum Grade
            {
                Excellent = 5,
                Good=4,
                Satisfactory=3,
                Poor=2,
                Failure=1
            }
            //education subjects
            public Grade math;
            public Grade computerScience;
            public Grade philosophy;
            public Grade physicalEducation;

            //Constructor
            public Student(string name1, string surname1, int cource1, int age1)
            {
                name = name1;
                surname = surname1;
                course = cource1;
                age = age1;
                math = 0;
                computerScience = 0;
                philosophy = 0;
                physicalEducation = 0;
            }

            //General info method
            public void Info()
            {
                Console.Write($"{name} {surname}: {course} course, {age} years");
            }

            //reading grades method
            public void Grades(int math1, int computerScience1, int philosophy1, int physicalEducation1)
            {
                math = (Grade)math1;
                computerScience = (Grade)computerScience1;
                philosophy = (Grade)philosophy1;
                physicalEducation = (Grade)physicalEducation1;
            }
        }


        static void Main(string[] args)
        {
            //Creating 10 students
            Student[] students = new Student[10];
            students[0] = new Student("Ivan", "Petrovky", 2, 19);
            students[1] = new Student("Olia", "Mokiy", 3, 20);
            students[2] = new Student("Petro", "Gima", 1, 18);
            students[3] = new Student("Maria", "Koval", 5, 21);
            students[4] = new Student("Jack", "Rebrov", 3, 21);
            students[5] = new Student("Paul", "Piterson", 4, 20);
            students[6] = new Student("Polly", "Monro", 1, 19);
            students[7] = new Student("Mike", "Melnyk", 4, 21);
            students[8] = new Student("Stefun", "Rogerson", 3, 19);
            students[9] = new Student("Kolia", "Prokopiv", 5, 21);

            //Writing students grades 
            students[0].Grades(2, 3, 2, 3);
            students[1].Grades(1, 3, 3, 4);
            students[2].Grades(3, 5, 4, 3);
            students[3].Grades(3, 3, 3, 3);
            students[4].Grades(4, 5, 5, 5);
            students[5].Grades(5, 5, 5, 5);
            students[6].Grades(2, 3, 4, 4);
            students[7].Grades(5, 4, 5, 3);
            students[8].Grades(3, 4, 5, 5);
            students[9].Grades(5, 5, 5, 5);


            //writing students with "good" and "exellent" grades
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].math >= Student.Grade.Good && students[i].computerScience >= Student.Grade.Good && students[i].philosophy >= Student.Grade.Good &&
                    students[i].physicalEducation >= Student.Grade.Good)
                {
                    Console.Write($"{i + 1}. ");
                    students[i].Info();
                    Console.Write($"  Grades: {students[i].math}, {students[i].computerScience},  {students[i].philosophy}, {students[i].physicalEducation}\n"); 
                }
            }

        }
    }
}
