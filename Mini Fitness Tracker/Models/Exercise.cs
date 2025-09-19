using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//دي كلاس لكل تمرين
namespace Mini_Fitness_Tracker.Models
{
    class Exercise
    {
        private string name; // e.g., Runningwithgroup, Swimming22/2023
        private string type; // e.g., Cardio, Strength, Yoga
        private double caloriesBurnedPermin; // calories burned per minute








        public Exercise(string name, string type, double caloriesBurnedPerMin)
        {
            this.name = name;
            this.type = type;
            caloriesBurnedPermin = caloriesBurnedPerMin;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double CaloriesBurnedPerMin
        {
            get { return caloriesBurnedPermin; }
            set { caloriesBurnedPermin = value; }
        }







        public double CalculateCalories(double durationInMinutes)
        {
            return caloriesBurnedPermin * durationInMinutes;
        }












        public void ShowExercise()
        {
            Console.WriteLine("Exercise Name: " + name);
            Console.WriteLine("Exercise Type: " + type);
            Console.WriteLine("Calories Burned Per Minute: " + caloriesBurnedPermin);
        }




    }
}
    