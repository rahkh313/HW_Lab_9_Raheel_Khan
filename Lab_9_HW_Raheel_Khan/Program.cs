using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9_HW_Raheel_Khan
{
    class Program
    {

    



        static void Main(string[] args)
        {
            StudentInfo student = new StudentInfo("Drew", "Detroit", "Chicken", "blue");

            List<StudentInfo> studentList = new List<StudentInfo>();

            studentList.Add(student);

            Console.WriteLine("Add new Student");

            bool repeat = true;
            while (repeat)
            {

                Console.WriteLine("Give me a new students name");
                string name = Console.ReadLine();

                Console.WriteLine("Give me a new students homeTown");
                string homeTown = Console.ReadLine();

                Console.WriteLine("Give me a new students favoriteFood");
                string favoriteFood = Console.ReadLine();

                Console.WriteLine("Give me a new students favoriteColor");
                string favoriteColor = Console.ReadLine();

                StudentInfo newStudent = new StudentInfo(name, homeTown, favoriteFood, favoriteColor);

                studentList.Add(newStudent);

                Console.WriteLine("Continue");
                string input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    repeat = false;
                }
            }

            foreach (StudentInfo Student in studentList)
            {
                Console.WriteLine($"{Student.Name} {Student.HomeTown} {Student.FavoriteFood} {Student.FavoriteColor}");
            }

            Console.WriteLine();

        }
    }
}
