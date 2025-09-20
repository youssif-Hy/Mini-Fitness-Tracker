using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Fitness_Tracker.Models
{
    public  class User
    {
        private static string name;
        private static int age; 
        private static double weight;
        private static double height;
        private static double bmi;
        private static string username;
        private static string password;


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
        public static double CalculateBmi()
        {
            return weight / (height * height);
        }




        public User(string username , string password,string name, int age, double weight, double height)
        {
            Username = username;
            Password = password;
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }







        // BMI stands for
        //body mass index and its formula is weight in kg/ height in m^2 
        // to identify if a person is underweight, normal weight, overweight or obese
        // BMI < 18.5 = underweight
        // BMI 18.5 - 24.9 = normal weight
        // BMI 25 - 29.9 = overweight
        // BMI >= 30 = obese





        public string GetBmiCategory()
        {

            double bmi = CalculateBmi();

            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 25)
                return "Normal weight";
            else if (bmi < 30)
                return "Overweight";
            else
                return "Obese";


        }


        /// key Mehods

        public void UpdateProfile(string name, int age, double weight, double height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }


        public void ShowProfile()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("BMI: " + CalculateBmi().ToString("F2"));
            Console.WriteLine("BMI Category: " + GetBmiCategory());
        }






        public int workoutPlans;
    }
}
