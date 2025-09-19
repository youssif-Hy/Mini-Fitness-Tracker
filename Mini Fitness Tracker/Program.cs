using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Fitness_Tracker.Ui;
using Mini_Fitness_Tracker.Engine;

namespace Mini_Fitness_Tracker
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                ConsoleUI.DisplayWelcomeMessage();
                int userOption = ConsoleUI.DisplayMenu();

                switch (userOption)
                {
                    case 1: // Login
                        ConsoleUI.LogIn();
                        if (/*!ConsoleUI.LogIn()*/)
                        {
                            ConsoleUI.DisplayMenu();
                        }
                        break;

                    case 2: // Register
                        ConsoleUI.Register();
                        break;

                    case 3: // Exit
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
            ConsoleUI.mainMenu();
            SwitchMenu();
        }

        // Center text in console window
        public static string CenterText(string text)
        {
            int padding = (Console.WindowWidth - text.Length) / 2;
            return new string(' ', Math.Max(padding, 0)) + text;
        }

        public static void SwitchMenu()
        {
            int mainMenuChoice = ConsoleUI.mainMenu();
            switch (mainMenuChoice)
            {
                case 1: // Profile
                    SwitchProfile();
                    break;
                case 2: // Exercises
                        // *****************************************************************************
                        // method Exercises
                        // *****************************************************************************
                    break;
                case 3: // Workout Plan
                        // Handle workout plan
                    break;
                case 4: // Progress
                        // Handle progress tracking
                    break;
                case 5: // Logout
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine(CenterText("Invalid option Please try again"));
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        public static void SwitchProfile()
        {
            //profile method
            switch ()
            {
                case 1:
                    // *****************************************************************************
                    //view
                    // *****************************************************************************
                    break;
                case 2:
                    // *****************************************************************************
                    //edit
                    // *****************************************************************************
                    break;
            }
        }

    }
}
