using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Fitness_Tracker.Models
{
    //diplay stats of the user progress of the week and day
    class Progresstracker
    {
        private int totalWorkoutTimeperday; // in minutes
        private int weeklycalories;
        private string exercisestats = "not started";

        public void UpdateProgress(int workoutTime, int caloriesBurned, string exerciseStats)
        {
            totalWorkoutTimeperday += workoutTime;
            weeklycalories += caloriesBurned;
            exercisestats = exerciseStats;
        }






        public void ShowProgress()
        {
            Console.WriteLine("total Workout time (minutes): " + totalWorkoutTimeperday);
            Console.WriteLine("total calories burnedperweek: " + weeklycalories);
            Console.WriteLine("total calories burnedperday: " + weeklycalories / 7);
            Console.WriteLine("Exercise Stats: " + exercisestats);
        }

        public void DisplaydailyProgress()
        {
            Console.WriteLine("Daily Progress:");
            Console.WriteLine("Workout Time (minutes): " + totalWorkoutTimeperday);
            Console.WriteLine("Calories Burned: " + weeklycalories);
            Console.WriteLine("Exercise Stats: " + exercisestats);
        }




    }
}
