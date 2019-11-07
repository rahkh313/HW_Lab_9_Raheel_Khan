using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9_HW_Raheel_Khan
{
    class StudentInfo
    {
        public string Name;
        public string HomeTown;
        public string FavoriteFood;
        public string FavoriteColor;

        //default constructor
        public StudentInfo()
        {

        }

        //overloaded constructor 
        public StudentInfo(string name)
        {
            Name = name;

        }

        public StudentInfo(string name, string homeTown)
        {
            Name = name;
            HomeTown = homeTown;


        }

        public StudentInfo(string name, string homeTown, string favoriteFood, string favoriteColor)
        {
            Name = name;
            HomeTown = homeTown;
            FavoriteFood = favoriteFood;
            FavoriteColor = favoriteColor;
        }

    }
}
