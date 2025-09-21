using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Fitness_Tracker.Models
{


    public class WorkoutPlan
    {
        private static List<WorkoutPlan> workoutPlans = new List<WorkoutPlan>();
        private static List<Exercise> _exercises = new List<Exercise>();
        Exercise exercise;
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

        public static List<WorkoutPlan> WorkoutPlans
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

        public static List<Exercise> exercises
        {
            get
            {
                return exercises;
            }
            set
            {
                value = exercises;
            }
        }






    }
}
