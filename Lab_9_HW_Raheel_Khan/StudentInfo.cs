using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9_HW_Raheel_Khan
{
    class StudentInfo
    {
        public string Name;
        public string HomeTown;
        public string Food;
        public string Color;

        //default constructor
        public StudentInfo()
        {

        }

        public StudentInfo(string Name, string HomeTown, string Food, string Color)
        {
            this.Name = Name;
            this.HomeTown = HomeTown;
            this.Food = Food;
            this.Color = Color;
            
        }

    }
}
