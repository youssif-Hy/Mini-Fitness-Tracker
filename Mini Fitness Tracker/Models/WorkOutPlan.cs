using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Fitness_Tracker.Models
{


    public class WorkoutPlan
    {
        private static List<Exercise> workoutPlans = new List<Exercise>();
        private static DateTime date;
        private static double durationPerExercise;

        public static DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public static double DurationPerExercise
        {
            get
            {
                return durationPerExercise;
            }
            set
            {
                value = durationPerExercise;
            }
        }

        public static List<Exercise> WorkoutPlans
        {
            get
            {
                return workoutPlans;
            }
            set
            {
                value = workoutPlans;
            }
        }

        






    }
}
