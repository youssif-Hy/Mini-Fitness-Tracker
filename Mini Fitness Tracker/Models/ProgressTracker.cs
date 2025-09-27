using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Fitness_Tracker.Models
{
    //diplay stats of the user progress of the week and day
    public class Progresstracker
    {
        private static int TotalDurationOfDay; // in minutes
        private static int TotalDurationOfDays;
        private static double TotalCaloriesBurnedOfDay;
        private static double TotalCaloriesBurnedOfDays;

        public void UpdatedayProgress(int totalDurationOfDay, double totalCaloriesBurnedOfDay)
        {
            TotalDurationOfDay = totalDurationOfDay;
            TotalCaloriesBurnedOfDay = totalCaloriesBurnedOfDay;
        }
        public void UpdateweekProgress(int totalDurationOfDays, double totalCaloriesBurnedOfDays)
        {
            TotalDurationOfDays = totalDurationOfDays;
            TotalCaloriesBurnedOfDays = totalCaloriesBurnedOfDays;
        }
        public static void DisplaydailyProgress()
        {
            Console.SetCursorPosition(60, 3);
            Console.WriteLine(TotalDurationOfDay);
            Console.SetCursorPosition(60, 4);
            Console.WriteLine(TotalCaloriesBurnedOfDay);
        }
        public static void DisplayweeklyProgress()
        {
            Console.SetCursorPosition(70, 3);
            Console.WriteLine(TotalDurationOfDays);
            Console.SetCursorPosition(70, 4);
            Console.WriteLine(TotalCaloriesBurnedOfDays / 7);
            Console.SetCursorPosition(70, 5);
            Console.WriteLine(TotalCaloriesBurnedOfDays);
        }
       
    }
}
