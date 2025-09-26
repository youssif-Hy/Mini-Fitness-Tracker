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
        private static int TotalDurationOfDay; // in minutes
        private static int TotalDurationOfDays;
        private static int TotalCaloriesBurnedOfDay;
        private static int TotalCaloriesBurnedOfDays;

        public void UpdatedayProgress(int totalDurationOfDay, int totalCaloriesBurnedOfDay)
        {
            TotalDurationOfDay = totalDurationOfDay;
            TotalCaloriesBurnedOfDay = totalCaloriesBurnedOfDay;
        }
        public void UpdateweekProgress(int totalDurationOfDays, int totalCaloriesBurnedOfDays, string exerciseStats)
        {
            TotalDurationOfDays = totalDurationOfDays;
            TotalCaloriesBurnedOfDays = totalCaloriesBurnedOfDays;
        }
        public static void DisplaydailyProgress()
        {
            Console.SetCursorPosition(30, 3);
            Console.WriteLine(TotalDurationOfDay);
            Console.SetCursorPosition(30, 4);
            Console.WriteLine(TotalCaloriesBurnedOfDay);
        }
        public static void DisplayweeklyProgress()
        {
            Console.SetCursorPosition(30, 3);
            Console.WriteLine(TotalDurationOfDays);
            Console.SetCursorPosition(30, 5);
            Console.WriteLine(TotalCaloriesBurnedOfDays / 7);
            Console.SetCursorPosition(30, 6);
            Console.WriteLine(TotalCaloriesBurnedOfDays);
        }
       
    }
}
