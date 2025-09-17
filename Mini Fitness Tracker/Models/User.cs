using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Fitness_Tracker.Models
{
    public class User
    {
        private string name;
        private int age;
        private double weight;
        private double height;
        private double bmi;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }

        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double CalculateBmi()
        {
            return weight / (height * height);
        }



        public User(string name, int age, double weight, double height)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
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
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
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
