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
        private static int totalWorkoutTimeperday; // in minutes
        private static int weeklycalories;
        private static string exercisestats = "not started";

        public void UpdateProgress(int workoutTime, int caloriesBurned, string exerciseStats)
        {
            totalWorkoutTimeperday += workoutTime;
            weeklycalories += caloriesBurned;
            exercisestats = exerciseStats;
        }






        public static void DisplayweeklyProgress()
        {
            Console.SetCursorPosition(30, 3);
            Console.WriteLine(totalWorkoutTimeperday);
            Console.SetCursorPosition(30, 4);
            Console.WriteLine(weeklycalories);
            Console.SetCursorPosition(30, 5);
            Console.WriteLine(weeklycalories / 7);
            Console.SetCursorPosition(30, 6);
            Console.WriteLine(exercisestats);
        }

        public static void DisplaydailyProgress()
        {
            Console.SetCursorPosition(30, 3);
            Console.WriteLine(totalWorkoutTimeperday);
            Console.SetCursorPosition(30, 4);
            Console.WriteLine( weeklycalories);
            Console.SetCursorPosition(30, 5);
            Console.WriteLine(exercisestats);
        }




    }
}
