using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Fitness_Tracker.Models;
using Mini_Fitness_Tracker.Ui;

namespace Mini_Fitness_Tracker.Engine
{
    public class FitnessAppEngine
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                int userOption = ConsoleUI.DisplayMenu();

                switch (userOption)
                {
                    case 1: // Login
                        //if username exists or invalid username or password will repeat the program
                        if (!ConsoleUI.LogIn())
                        {
                            Run();
                        }
                        break;

                    case 2: // Register
                        ConsoleUI.Register();
                        break;

                    case 0: // Exit
                        Console.Clear();
                        Console.WriteLine(CenterText("Thank you for using Mini Fitness Tracker"));
                        Console.WriteLine(CenterText("Press any key to exit..."));
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine(CenterText("Invalid option selected."));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }


            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(CenterText($"An error occurred: {ex.Message}"));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(CenterText("Press any key to continue..."));
                Console.ReadKey();
                Console.Clear();
            }
        
            SwitchMenu();
        }
        // Center text in console window
        public static string CenterText(string text)
        {
            int padding = (Console.WindowWidth - text.Length) / 2;
            return new string(' ', Math.Max(padding, 0)) + text;
        }
        public static string switchExerciseType(int option)
        {
            switch (option)
            {
                case 1:
                    return "Cardio";
                case 2:
                    return "Strength";
                case 3:
                    return "Yoga";
                default:
                    return "";
            }
        }
        public static void SwitchMenu()
        {
            Console.Clear();
            int mainMenuChoice = ConsoleUI.mainMenu();
            switch (mainMenuChoice)
            {
                case 1: // Profile    \/
                    SwitchProfile();
                    break;
                case 2:
                    SwitchExerciseOption();
                    break;
                case 3: // Workout Plan
                    SwitchWorkOutPlan();
                    break;
                case 4: // Progress
                        // Handle progress tracking
                    break;
                case 5:
                    Run();
                    break;
                case 0: // Exit
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(CenterText("Invalid option Please try again"));
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            SwitchMenu();
        }
        public static void SwitchExerciseOption()
        {
            int option = ConsoleUI.ExercisesOptionMenu();
            switch (option)
            {
                case 1:
                case 2:
                case 3:
                    ConsoleUI.CalculateExercisesCalories(option);
                    break;
                case 4:
                    SwitchMenu();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
            SwitchExerciseOption();
        }
        public static void SwitchWorkOutPlan()
        {
            int option = ConsoleUI.WorkoutPlanOptionMenu();
            switch (option)
            {
                case 1:
                    ConsoleUI.ViewWorkoutPlan();
                    break;
                case 2:
                    SwitchMenu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
            SwitchWorkOutPlan();
        }




        public static void SwitchProfile()
        {

            int ProfileOption = ConsoleUI.ProfileOptionMenu();
            switch (ProfileOption)
            {
                case 1:
                    ConsoleUI.ViewProfile();
                    break;
                case 2:
                    ConsoleUI.EditProfile();
                    break;
                case 3:
                    SwitchMenu();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(CenterText("Invalid option Please try again"));
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            SwitchProfile();

        }

        public static double CalculateExercisesCalories(string exerciseName, int exerciseOption, double duration)
        {
            double METs =0;
            double weight = User.Weight;
            switch (exerciseOption)
            {
                case 1:

                    METs = switchOptionCardio(exerciseName);
                    break;
                case 2:
                    METs = switchOptionStrength(exerciseName);
                    break;
                case 3:
                    METs = switchOptionYoga(exerciseName);
                    break;
            }
            
            double caloriesBurnedPerMin = (METs * 3.5 * weight) / 200.0;
            return caloriesBurnedPerMin * duration;

        }
        public static double switchOptionCardio(string exerciseName)
        {
            switch(exerciseName.ToLower())
            {
                case "jump rope":
                case "running":
                    return 10;
                case "stair climbing":
                case "cycling":
                case "swimming":
                case "basketball":
                    return 8;
                case "walking":
                    return 3.5;
                case "dancing":
                case "rowing":
                case "tennis":
                    return 7;
                case "boxing":
                    return 9;                   
            }
            return 0;
        }
        public static double switchOptionStrength(string exerciseName)
        {
            switch (exerciseName.ToLower())
            {
                case "shoulder press":
                case "squats":
                    return 5;
                case "lunges":
                    return 4.5;
                case "push-ups":
                    return 4;
                case "pull-ups":
                case "bench press":
                    return 5.5;
                case "deadlifts":
                case "kettlebell training":
                    return 6;
                case "plank":
                case "bicep curls":
                    return 3.5;
            }
            return 0;
        }
        public static double switchOptionYoga(string exerciseName)
        {
            switch (exerciseName.ToLower())
            {
                case "tai chi":
                case "yoga":
                    return 4;
                case "pilates":
                case "mobility exercises":
                    return 3.5;
                case "stretching":
                    return 2.5;
                case "dance-based exercises":
                    return 7;
                case "balance exercises":
                    return 3;
                case "foam rolling":
                    return 2;
            }
            return 0;
        }


    }
}
