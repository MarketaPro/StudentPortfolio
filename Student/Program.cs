using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student3
{
    public class Student
    {
        // member variables
        private string name;
        private int age;

        private bool IsValidAge(int age)
        {
            return age <= 26 && age >= 20;
        }

        public Student(string name, int age)
        {
            this.name = name;
            if (IsValidAge(age))
            {
                this.age = age;
            }
            else
            {
                this.age = 20;
                Console.WriteLine("The age" + age + "is out of bounds");
            }
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            if (IsValidAge(age))
            {
                this.age = age;
            }
            else
            {
                this.age = 20;
                Console.WriteLine("The age" + age + "is out of bounds");
            }
        }

        public string NewbieStatus()
        {
            if (age == 20)
            {
                return "I am a newbie";
            }
            else if (age == 21)
            {
                return "I am still a newbie";
            }
            else
            {
                return "I am not a newbie anymore";
            }
        }

        public string YearStudyingStatusBar()
        {
            string statusbar = "";

            for (int i = 0; i < age - 19; i++)
            {
                statusbar = statusbar + "-";
            }

            for (int i = 0; i < 26 - age; i++)
            {
                statusbar = statusbar + "@";
            }

            return statusbar;


        }

        public static string GetPyramid(int baseLen)
        {
            string result = "";

            if (baseLen % 2 == 0)
            {
                throw new ArgumentException("BaseLen must be an odd number.");
            }
            
            else
            {

                for (int i = 0; i < baseLen / 2 + 1; i++)
                {
                    for (int j = 0; j < baseLen / 2 - i; j++)
                    {
                        result = result + " ";
                    }

                    for (int j = 1; j < 2 * (i + 1); j++)
                    {
                        result = result + "*";
                    }

                    for (int j = 0; j < baseLen / 2 - i; j++)
                    {
                        result = result + " ";
                    }

                    result = result + "\n";
                }
            }


            return result;
        }



        static void Main()
        {
            Student st1 = new Student("Charlotte Davies", 24);

            Console.WriteLine(st1.GetName());
            Console.WriteLine(st1.GetAge());
            Console.WriteLine(st1.NewbieStatus());
            Console.WriteLine(st1.YearStudyingStatusBar());


            Student st2 = new Student("Nathalia Feruggia", 28);

            Console.WriteLine(st2.GetName());
            Console.WriteLine(st2.GetAge());
            Console.WriteLine(st2.NewbieStatus());
            Console.WriteLine(st2.YearStudyingStatusBar());

            Student st3 = new Student("Lou Gitting", 21);

            Console.WriteLine(st3.GetName());
            Console.WriteLine(st3.GetAge());
            Console.WriteLine(st3.NewbieStatus());
            Console.WriteLine(st3.YearStudyingStatusBar());

            Student st4 = new Student("Henry Sartre-Clarke", 20);

            Console.WriteLine(st4.GetName());
            Console.WriteLine(st4.GetAge());
            Console.WriteLine(st4.NewbieStatus());
            Console.WriteLine(st4.YearStudyingStatusBar());

            string pyram1 = Student.GetPyramid(7);
            Console.Write(pyram1);

            try
            {
                string pyram2 = Student.GetPyramid(8);
            }


            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();

        }
    }
}

