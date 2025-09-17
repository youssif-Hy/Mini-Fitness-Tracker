using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Fitness_Tracker.Models
{


    public class WorkoutPlan
    {

        private List<(Exercise Exercise, int Duration)> workoutItems;

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


        public WorkoutPlan(DateTime date)
        {
            this.date = date;
            workoutItems = new List<(Exercise, int)>
        {
            // sample data as for format (Exercise(name,type,calories that we burn in a min idk wht the unit of measuring ngl ), duration in minutes)
            (new Exercise("Running", "Cardio", 10.0), 45),
            (new Exercise("Push-ups", "Strength", 8.0), 15),
            (new Exercise("Stretching", "Flexibility", 3.0), 10),
            (new Exercise("Cycling", "Cardio", 9.0), 30),
            (new Exercise("Yoga", "Flexibility", 4.0), 20),
            (new Exercise("Swimming", "Cardio", 11.0), 40),
            (new Exercise("Plank", "Strength", 5.0), 5),
            (new Exercise("Jump Rope", "Cardio", 12.0), 20)

        };
        }




        //key methids


        public void ShowWorkoutPlan()
        {
            Console.WriteLine("Workout Plan for Date: " + date.ToShortDateString());
            foreach (var item in workoutItems)
            {
                double caloriesBurned = item.Exercise.CalculateCalories(item.Duration);
                Console.WriteLine($"Exercise: {item.Exercise.Name}, Type: {item.Exercise.Type}, Duration: {item.Duration} minutes, Calories Burned: {caloriesBurned}");
            }
        }



    }
}
