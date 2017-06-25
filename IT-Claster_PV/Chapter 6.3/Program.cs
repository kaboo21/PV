using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._3
{
    class Program
    {
        struct Student
        {
            public string name;
            public string surname;
            public int course;
            public int age;

            public Student(string name1, string surname1, int cource1, int age1)
            {
                name = name1;
                surname = surname1;
                course = cource1;
                age = age1;
            }

            public void Info()
            {
                Console.WriteLine($"{name} {surname}: {course} course, {age} years");
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

            //Sorting students array by age
            for (int i = 0; i < students.Length; i++)
                for (int j=i;j<students.Length;j++)
                    if (students[i].age > students[j].age)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }

            //writing all info about students
            for (int i = 0; i < students.Length; i++)
                students[i].Info();
        }
    }
}
