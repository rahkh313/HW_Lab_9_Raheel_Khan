using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab_9_HW_Raheel_Khan
{
    class Program
    {

        
        static void Main(string[] args)
        {
            List<StudentInfo> students = new List<StudentInfo>()
            {
                new StudentInfo("Jacob","Merrillville","Cookies", "Yellow"),
                new StudentInfo("Drew", "Detroit", "Ice Cream", "Red"),
                new StudentInfo("Peter", "Chicago", "Thai", "Blue"),
                new StudentInfo("Raheel","Indiana", "Pizza", "Teal" ),
                new StudentInfo("Joseph", "Cincinnati", "Burgers", "White"),
                new StudentInfo("Michael", "Florida","Shawrma", "Black")
        };

            bool repeatMain = true;
            while (repeatMain)
            {
                bool repeatOne = true, repeatTwo = true; ;
                Console.WriteLine("\nWelcome to the Main Menu!");

                for (int index = 0; index < students.Count; index++)
                {
                    Console.WriteLine($"{index + 1}: {students[index].Name}");
                }

                Console.WriteLine("Please select a student by typing a number!");
                int studentNumber = Validator(students);

                string studentSelected = students[studentNumber].Name;

                while (repeatOne)
                {
                    GetInfo(studentNumber, students);
                    repeatOne = Repeator($"more about {studentSelected}");
                }
                while (repeatTwo)
                {
                    repeatTwo = Repeator("add another student");
                    if (repeatTwo)
                    {
                        AddStudent(students);
                    }
                }

                repeatMain = Repeator("select another student");

            }
            Console.WriteLine("GoodBye!");
            return;
        }
        public static int Validator(List<StudentInfo> userInput)
        {
            bool repeat = true;
            int studentNum = 0;
            while (repeat)
            {
                try
                {
                    string input = Console.ReadLine();
                    studentNum = int.Parse(input) - 1;
                    object testIndex = userInput[studentNum];
                    repeat = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Im sorry thats not a number between 1-{userInput.Count}!\n");
                    repeat = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Im sorry thats not a number between 1-{userInput.Count}!\n");
                    repeat = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Im sorry thats not a number between 1-{userInput.Count}!\n");
                    repeat = true;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("That was not a valid response try again\n");
                    repeat = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("That was not a valid response try again\n");
                    repeat = true;
                }

            }
            return studentNum;
        }
        public static string Validator()
        {
            bool repeat = true;
            string input = "";
            Regex validate = new Regex(@"^([A-Z]{0,1}'*[a-z]{0,10},* *)+$");
            while (repeat)
            {
                try
                {
                    input = Console.ReadLine();
                    if (validate.IsMatch(input))
                    {
                        repeat = false;
                        return input;
                    }
                    else if (input == String.Empty)
                    {
                        Console.WriteLine("Im sorry thats not a valid input try again.\n");
                    }
                    else
                    {
                        Console.WriteLine("Im sorry thats not a valid input try again.\n");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Im sorry thats not a valid input try again.\n");
                }
            }
            return input;
        }
        public static void GetInfo(int studentNum, List<StudentInfo> students)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine($"What would you like to know about {students[studentNum].Name}?\nYou can choose: Hometown, Food, Color.");
                string whatInfo;
                try
                {
                    whatInfo = Console.ReadLine().ToLower();


                    if (string.IsNullOrEmpty(whatInfo))
                    {
                        Console.WriteLine("That is not a valid selection.\n");
                        repeat = true;
                    }
                    else if (whatInfo == "hometown")
                    {
                        Console.WriteLine($"{students[studentNum].Name}'s hometown is {students[studentNum].HomeTown}\n");
                        repeat = false;
                    }
                    else if (whatInfo == "food")
                    {
                        Console.WriteLine($"{students[studentNum].Name}'s FavoriteFood is {students[studentNum].Food}\n");
                        repeat = false;
                    }                 
                    else if (whatInfo == "color")
                    {
                        Console.WriteLine($"{students[studentNum].Name}'s favorite color is {students[studentNum].Color}\n");
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid selection.\n");
                        repeat = true;
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("That is not a valid selection.\n");
                    repeat = true;
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("That is not a valid selection.\n");
                    repeat = true;
                }
            }

        }

        public static bool Repeator(string input)
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine($"Would you like to {input}?");
                try
                {
                    string yorn = Console.ReadLine().ToLower();
                    if (yorn == "y" || yorn == "yes")
                    {
                        repeat = false;
                    }
                    else if (yorn == "n" || yorn == "no")
                    {
                        repeat = false;
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("\nIm sorry thats not a valid input.\n");
                        repeat = true;
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("\nIm sorry thats not valid input!\n");
                    repeat = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nIm sorry thats not valid input!\n");
                    repeat = true;
                }
            }
            return true;

        }

        public static void AddStudent(List<StudentInfo> students)
        {
            bool addYorn = true;
            while (addYorn)
            {
                Console.WriteLine("Enter the students name:");
                string name = Validator();

                Console.WriteLine($"\nEnter {name}'s Hometown:");
                string hometown = Validator();

                Console.WriteLine($"\nEnter {name}'s FavoriteFood:");
                string favoritefood = Validator();

                Console.WriteLine($"\nEnter {name}'s favorite color:");
                string color = Validator();

                students.Add(new StudentInfo(name, hometown, favoritefood, color));
                students.Sort((a, b) => a.Name.CompareTo(b.Name));

                Console.WriteLine($"\n{name}'s info and name has been added to the database.\n");
                addYorn = false;
            }
          

        }
    }
}

