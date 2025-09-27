using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Fitness_Tracker.Models
{

    //class to create a workout plan
    // A workout plan consists of a list of exercises, a date, and a duration per exercise
    

    public class WorkoutPlan
    {
        //class attributes
        private static List<Exercise> workoutPlans = new List<Exercise>();
        private static DateTime date;
        private static double durationPerExercise;


        public static DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


        //property for duration per exercise
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



        //property for workout plans
        //returns a list of exercises to be done in the workout plan
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
