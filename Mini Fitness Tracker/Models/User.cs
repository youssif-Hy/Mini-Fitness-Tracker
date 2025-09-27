using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Fitness_Tracker.Models
{

    public  class User
    {
        //class attributes
        private static string name;
        private static int age; 
        private static double weight;
        private static double height;
        private static string username;
        private static string password;

        //getters and setters

        public static string Name
        {
            get { return name; }
            set { name = value; }
        }
        public static int Age
        {
            get { return age; }
            set { age = value; }
        }


        public static double Weight
        {
            get { return weight; }
            set { weight = value; }

        }

        public static double Height
        {
            get { return height; }
            set { height = value; }
        }

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }



        //main constructor
        public User(string username , string password,string name, int age, double height, double weight)
        {
            Username = username;
            Password = password;
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }          
    }
}
