using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating 10 students
            Student[] students = new Student[10];
            students[0] = new Student("Ronaldo", "Olia", 2, 20);
            students[1] = new Student("Pavlov", "Ivan", 4, 21);
            students[2] = new Student("Kozlov", "Petro", 3, 20);
            students[3] = new Student("Durov", "Semen", 2, 19);
            students[4] = new Student("Romanov", "Kevin", 5, 21);
            students[5] = new Student("Stark", "Mark", 2, 18);
            students[6] = new Student("Enshtein", "Robert", 1, 18);
            students[7] = new Student("Lucenko", "Clara", 3, 20);
            students[8] = new Student("Tataren", "Maria", 4, 20);
            students[9] = new Student("Baranova", "Nadia", 6, 22);

            //ex. 1 Name and surname students older 20 years
            Console.WriteLine("Exercise 1 - Name and surname students older 20 years");
            foreach (Student  st in students)
                if (st.GetAge() > 20)
                    st.NameInfo();

            //ex.2 change cource for 3 students
            students[0].SetCource(1);
            students[1].SetCource(1);
            students[2].SetCource(1);

            //ex.3 sorting students array
            Console.WriteLine("\nExercise 3 - sorting students array");
            for (int i=0; i<10;i++)
                for (int j=i+1; j<10;j++)
                    if (students[i].GetAge() > students[j].GetAge())
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
            foreach (Student st in students)
                st.Info();

            //ex.4 Set points
            students[0].SetPoints(2, 3, 4, 3);
            students[1].SetPoints(4, 3, 4, 3);
            students[2].SetPoints(5, 5, 5, 5);
            students[3].SetPoints(4, 4, 4, 3);
            students[4].SetPoints(3, 3, 4, 3);
            students[5].SetPoints(4, 4, 4, 4);
            students[6].SetPoints(5, 5, 5, 5);
            students[7].SetPoints(3, 3, 3, 3);
            students[8].SetPoints(2, 2, 2, 2);
            students[9].SetPoints(4, 5, 4, 5);

            //ex.5 Bad students
            Console.WriteLine("\nExercise 5 - bad students");
            foreach (Student st in students)
                if (st.Math==2|| st.Philosophy == 2 || st.Physics == 2 || st.Biology== 2 )
                {
                    st.NameInfo();
                    st.PoitsInfo();
                }

            //ex.6 Good studets first 
            Console.WriteLine("\nExercise 6 - Good studets first");
            for (int i = 0; i < 10; i++)
                if (students[i].Math != 5 && students[i].Philosophy != 5 && students[i].Physics != 5 && students[i].Biology != 5)
                {
                    for (int j = i + 1; j < 10; j++)
                        if (students[j].Math == 5 && students[j].Philosophy == 5 && students[j].Physics == 5 && students[j].Biology == 5)
                        {
                            Student temp = students[i];
                            students[i] = students[j];
                            students[j] = temp;
                        }
                        else continue;

                }
                else continue;
            foreach (Student st in students)
            {
                st.NameInfo();
                st.PoitsInfo();
            }

            //ex.7 Scholarship
            students[0].Scholarship = 700;
            students[1].Scholarship = 800;
            students[2].Scholarship = 900;
            students[3].Scholarship = 750;
            students[4].Scholarship = 750;
            students[5].Scholarship = 750;
            students[6].Scholarship = 760;
            students[7].Scholarship = 770;
            students[8].Scholarship = 780;
            students[9].Scholarship = 900;

            //ex.8 Max Scholarship
            Console.WriteLine("\nExercise 8 - Max Scholarship");
            int maxScholarship = 0;
            foreach (Student st in students)
                if (st.Scholarship > maxScholarship)
                    maxScholarship = st.Scholarship;
            foreach (Student st in students)
                if (st.Scholarship == maxScholarship)
                {
                    st.NameInfo();
                    Console.WriteLine($"Scholarship: {st.Scholarship}");
                }



        }
    }
}
