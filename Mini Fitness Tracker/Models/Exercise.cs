using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//دي كلاس لكل تمرين
namespace Mini_Fitness_Tracker.Models
{
   public class Exercise
    {
        private string name; // e.g., Runningwithgroup, Swimming22/2023
        private string type; // e.g., Cardio, Strength, Yoga
        private int duration; // duration in minutes 
        private double caloriesBurnedPermin; // calories burned per minute
        private double totalBurnedPermin; // total calories burned in a full workout

        // Constructor to initialize an exercise
        public Exercise(string name, string type, double caloriesBurnedPerMin, double TotalCaloriesBurned, int Duration)
        {
            this.name = name;
            this.type = type;
            caloriesBurnedPermin = caloriesBurnedPerMin;
            totalBurnedPermin = TotalCaloriesBurned;
            duration = Duration;
        }

        public int Duration
        {
            // getter and setter for duration
            get
            {
                return duration; 
            }
            set
            {  
                duration = value; 
            }
        }
        public double TotalCaloriesBurned
        {
            get 
            {
                return totalBurnedPermin;
            }
            set 
            {
                totalBurnedPermin = value;
            }
        }

        public string Name
        {
            get 
            { 
                return name;
            }
            set 
            {
                name = value; 
            }
        }

        public string Type
        {
            get
            { 
                return type;
            }
            set 
            { 
                type = value;
            }
        }

        public double CaloriesBurnedPerMin
        {
            get 
            { 
                return caloriesBurnedPermin; 
            }
            set 
            { 
                caloriesBurnedPermin = value;
            }
        }
    }
}
    