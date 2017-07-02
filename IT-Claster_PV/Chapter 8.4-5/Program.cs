using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //8.4 some students
            Student st1 = new Student("Braun", "Peter", 4, 21);
            Student st2 = new Student("Kovalenko", "Teriana", 3, 20);
            Student st3 = new Student("Jeferson", "Robert", 5, 22);
            Student st4 = new Student("Polo", "Mery", 2, 19);
            //8.4Number of students
            Console.WriteLine($"Number of students is - {Student.studentCounter}");

            //8.5 Sum of scholarships
            st1.scholarshipSum();
            st2.scholarshipSum(1000, 700);
            st3.scholarshipSum(500, 1000, 800, 900);
            st4.scholarshipSum(800, 1200, 700, 560);
        }
    }
}
