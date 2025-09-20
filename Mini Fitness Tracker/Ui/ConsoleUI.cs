using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mini_Fitness_Tracker;
using Mini_Fitness_Tracker.Engine;
using Mini_Fitness_Tracker.Models;
using Mini_Fitness_Tracker.Utils;

namespace Mini_Fitness_Tracker.Ui
{
    public class ConsoleUI
    {
        public static void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(FitnessAppEngine.CenterText("███╗░░░███╗██╗███╗░░██╗██╗  ███████╗██╗████████╗███╗░░██╗███████╗░██████╗░██████╗"));
            Console.WriteLine(FitnessAppEngine.CenterText("████╗░████║██║████╗░██║██║  ██╔════╝██║╚══██╔══╝████╗░██║██╔════╝██╔════╝██╔════╝"));
            Console.WriteLine(FitnessAppEngine.CenterText("██╔████╔██║██║██╔██╗██║██║  █████╗░░██║░░░██║░░░██╔██╗██║█████╗░░╚█████╗░╚█████╗░"));
            Console.WriteLine(FitnessAppEngine.CenterText("██║╚██╔╝██║██║██║╚████║██║  ██╔══╝░░██║░░░██║░░░██║╚████║██╔══╝░░░╚═══██╗░╚═══██╗"));
            Console.WriteLine(FitnessAppEngine.CenterText("██║░╚═╝░██║██║██║░╚███║██║  ██║░░░░░██║░░░██║░░░██║░╚███║███████╗██████╔╝██████╔╝"));
            Console.WriteLine(FitnessAppEngine.CenterText("╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝╚═╝  ╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚══╝╚══════╝╚═════╝░╚═════╝░"));
            Console.WriteLine(FitnessAppEngine.CenterText("████████╗██████╗░░█████╗░░█████╗░██╗░░██╗███████╗██████╗░"));
            Console.WriteLine(FitnessAppEngine.CenterText("╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██║░██╔╝██╔════╝██╔══██╗"));
            Console.WriteLine(FitnessAppEngine.CenterText("░░░██║░░░██████╔╝███████║██║░░╚═╝█████═╝░█████╗░░██████╔╝"));
            Console.WriteLine(FitnessAppEngine.CenterText("░░░██║░░░██╔══██╗██╔══██║██║░░██╗██╔═██╗░██╔══╝░░██╔══██╗"));
            Console.WriteLine(FitnessAppEngine.CenterText("░░░██║░░░██║░░██║██║░░██║╚█████╔╝██║░╚██╗███████╗██║░░██║"));
            Console.WriteLine(FitnessAppEngine.CenterText("░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝"));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(FitnessAppEngine.CenterText("Welcome to the Mini Fitness Tracker🏋️!"));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(FitnessAppEngine.CenterText("Press any key to continue..."));
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static int DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(FitnessAppEngine.CenterText("Welcome to the Mini Fitness Tracker🏋️!"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Log In");
            Console.WriteLine("2. Register");
            Console.WriteLine("0. Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice (0-2):");
            Console.ForegroundColor = ConsoleColor.White;
            int option = Validation.ValidataInputOption(0, 2, 24, 4, 0, 5);

            return option;
        }
        // دالة LogIn تقوم بعرض واجهة تسجيل الدخول للمستخدم
        public static bool LogIn()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            // ASCII Art لعرض عنوان تسجيل الدخول 
            Console.WriteLine(FitnessAppEngine.CenterText("╔══════════════════════════════════════════════════════╗"));
            Console.WriteLine(FitnessAppEngine.CenterText("║                       LOG IN                         ║"));
            Console.WriteLine(FitnessAppEngine.CenterText("║               --------------------------             ║"));
            Console.WriteLine(FitnessAppEngine.CenterText("║                                                      ║"));
            Console.WriteLine(FitnessAppEngine.CenterText("║   ➤ Enter Your Username :                            ║"));
            Console.WriteLine(FitnessAppEngine.CenterText("║   ➤ Enter Your Password :                            ║"));
            Console.WriteLine(FitnessAppEngine.CenterText("║                                                      ║"));
            Console.WriteLine(FitnessAppEngine.CenterText("║               [ Press ENTER to Submit ]              ║"));
            Console.WriteLine(FitnessAppEngine.CenterText("╚══════════════════════════════════════════════════════╝"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(59, 4); // اعادة تعيين موضع المؤشر لاسم المستخدم
            string user_name = Console.ReadLine();
            Console.SetCursorPosition(59, 5); // اعادة تعيين موضع المؤشر لكلمة المرور
            string password = Console.ReadLine();
            bool isValidUser = DataHandler.CheckLogin(user_name, password);
            if (isValidUser)
            {
                Console.SetCursorPosition(0, 9);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(FitnessAppEngine.CenterText("Login successful!"));
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(FitnessAppEngine.CenterText("Press any key to continue..."));
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.SetCursorPosition(0, 9);
                Console.WriteLine(FitnessAppEngine.CenterText("Invalid username or password. Please try again."));
                Console.Write(FitnessAppEngine.CenterText("Press any key to continue..."));
                Console.ReadKey();
                Console.Clear();
            }
            return isValidUser;
        }
        // دالة Register تقوم بعرض واجهة تسجيل مستخدم جديد
        public static void Register()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            // عرض واجهة المستخدم لتسجيل حساب جديد
            Console.WriteLine(FitnessAppEngine.CenterText("+================================================================================+"));
            Console.WriteLine(FitnessAppEngine.CenterText("|                                 Register                                       |"));
            Console.WriteLine(FitnessAppEngine.CenterText("+================================================================================+"));
            Console.WriteLine(FitnessAppEngine.CenterText("| ➤ Username          :                                                          |"));
            Console.WriteLine(FitnessAppEngine.CenterText("| ➤ Password          :                                                          |"));
            Console.WriteLine(FitnessAppEngine.CenterText("| ➤ Name              :                                                          |"));
            Console.WriteLine(FitnessAppEngine.CenterText("| ➤ Age               :                                                          |"));
            Console.WriteLine(FitnessAppEngine.CenterText("| ➤ Height            :                                                          |"));
            Console.WriteLine(FitnessAppEngine.CenterText("| ➤ Weight            :                                                          |"));
            Console.WriteLine(FitnessAppEngine.CenterText("+================================================================================+"));
            Console.WriteLine(FitnessAppEngine.CenterText("|          [ Please enter the required information above ]                       |"));
            Console.WriteLine(FitnessAppEngine.CenterText("|          [ Press ENTER after each input to continue ]                          |"));
            Console.WriteLine(FitnessAppEngine.CenterText("+================================================================================+"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(42, 3);
            string username = Validation.ValidataUsername(Console.ReadLine(), 42, 3, 0, 14);
            Console.SetCursorPosition(42, 4);
            string password = Validation.ValidataPassword(Console.ReadLine(), 42, 4, 0, 14);
            Console.SetCursorPosition(42, 5);
            string name = Validation.ValiDataName(Console.ReadLine(), 42, 5, 0, 14);
            Console.SetCursorPosition(42, 6);
            string Age = Validation.ValiDataAge(Console.ReadLine(), 42, 6, 0, 14);
            Console.SetCursorPosition(42, 7);
            string Height = Validation.ValidataHeight(Console.ReadLine(), 42, 7, 0, 14);
            Console.SetCursorPosition(42, 8);
            string Weight = Validation.ValidataWeight(Console.ReadLine(), 42, 8, 0, 14);
            DataHandler.Register(username, password, name, int.Parse(Age), double.Parse(Height), double.Parse(Weight));
            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(FitnessAppEngine.CenterText("Registration successful!"));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(FitnessAppEngine.CenterText("Press any key to continue..."));
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public static int mainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(FitnessAppEngine.CenterText("Main Menu"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Profile");
            Console.WriteLine("2. Exercises");
            Console.WriteLine("3. Workout Plan");
            Console.WriteLine("4. Progress");
            Console.WriteLine("5. LogOut");
            Console.WriteLine("0. Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice (0-5):");
            Console.ForegroundColor = ConsoleColor.White;
            int option = Validation.ValidataInputOption(0, 5, 24, 7, 0, 8);

            return option;
        }
        public static int ProfileOptionMenu()
        {
            Console.Clear();
            Console.WriteLine("1. View Profile");
            Console.WriteLine("2. Edit Profile");
            Console.WriteLine("3. Back to Main Menu");
            Console.WriteLine("0. Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice (0-3):");
            Console.ForegroundColor = ConsoleColor.White;
            int option = Validation.ValidataInputOption(0, 3, 24, 4, 0, 5);
            return option;
        }
        public static int ExercisesOptionMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Cardio (e.g., Running, Jump Rope)");
            Console.WriteLine("2. Strength (e.g., Squats, Push-ups)");
            Console.WriteLine("3. Yoga (Flexibility/Balance)");
            Console.WriteLine("4. Back to Main Menu");
            Console.WriteLine("0. Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Enter your choice (0-4):");
            Console.ForegroundColor = ConsoleColor.White;
            int option = Validation.ValidataInputOption(0, 4, 24, 5, 0, 6);
            return option;
        }
        public static void ViewProfile()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------+"));
            Console.WriteLine(FitnessAppEngine.CenterText(" |                 🪪Your Profile🪪               |"));
            Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------+"));
            Console.WriteLine(FitnessAppEngine.CenterText(" | Name    :                                      |"));
            Console.WriteLine(FitnessAppEngine.CenterText(" | Age     :                                      |"));
            Console.WriteLine(FitnessAppEngine.CenterText(" | Height  :                                      |"));
            Console.WriteLine(FitnessAppEngine.CenterText(" | Weight  :                                      |"));
            Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------+"));
            Console.WriteLine(FitnessAppEngine.CenterText("|     Press any key to Back to profile menu 📄   |"));
            Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------+"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(46, 3);
            Console.Write($"{User.Name}");
            Console.SetCursorPosition(46, 4);
            Console.Write($"{User.Age}");
            Console.SetCursorPosition(46, 5);
            Console.Write($"{User.Height} CM");
            Console.SetCursorPosition(46, 6);
            Console.Write($"{User.Weight} kg");
            Console.ReadKey();
            Console.Clear();
            FitnessAppEngine.SwitchProfile();
        }
        public static int EditProfile()
        {
            Console.Clear();
            Console.WriteLine("1. Edit Name");
            Console.WriteLine("2. Edit Age");
            Console.WriteLine("3. Edit Height");
            Console.WriteLine("4. Edit Weight");
            Console.WriteLine("5. Back to Profile Menu");
            Console.WriteLine("0. Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice (0-5):");
            Console.ForegroundColor = ConsoleColor.White;
            int option = Validation.ValidataInputOption(0, 5, 24, 6, 0, 7);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------+"));
            Console.WriteLine(FitnessAppEngine.CenterText(" |             🪪Edit your profile🪪              |"));
            Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------+"));
            switch (option)
            {
                case 1:
                    Console.WriteLine(FitnessAppEngine.CenterText(" | Enter new name   :                             |"));
                    Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------+"));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(55, 3);
                    string newName = Validation.ValiDataName(Console.ReadLine(), 55, 3, 0, 5);
                    User.Name = newName;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine(FitnessAppEngine.CenterText("Profile updated successfully!"));
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(FitnessAppEngine.CenterText("Press any key to continue..."));
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    return option;
                case 2:
                    Console.WriteLine(FitnessAppEngine.CenterText(" | Enter new age    :                             |"));
                    Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------+"));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(55, 3);
                    string newAge = Validation.ValiDataAge(Console.ReadLine(), 55, 3, 0, 5);
                    User.Age = int.Parse(newAge);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine(FitnessAppEngine.CenterText("Profile updated successfully!"));
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(FitnessAppEngine.CenterText("Press any key to continue..."));
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    return option;
                case 3:
                    Console.WriteLine(FitnessAppEngine.CenterText(" | Enter new height (CM):                         |"));
                    Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------+"));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(59, 3);
                    string newHeight = Validation.ValidataHeight(Console.ReadLine(), 59, 3, 0, 5);
                    User.Height = double.Parse(newHeight);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine(FitnessAppEngine.CenterText("Profile updated successfully!"));
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(FitnessAppEngine.CenterText("Press any key to continue..."));
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    return option;
                case 4:
                    Console.WriteLine(FitnessAppEngine.CenterText(" | Enter new weight (Kg):                         |"));
                    Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------+"));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(59, 3);
                    string newWeight = Validation.ValidataWeight(Console.ReadLine(), 59, 3, 0, 5);
                    User.Weight = double.Parse(newWeight);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine(FitnessAppEngine.CenterText("Profile updated successfully!"));
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(FitnessAppEngine.CenterText("Press any key to continue..."));
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    return option;
                case 5:
                    Console.ResetColor();
                    FitnessAppEngine.SwitchProfile();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
            return 0;

        }
        public static void CalculateExercisesCalories(int exerciseOption)
        {
            Console.Clear();
            Console.WriteLine("Enter exercise name:");
            Console.WriteLine("Enter duration (minutes):");
            Console.SetCursorPosition(20, 0);
            string exerciseName = Validation.ValiDataExerciseName(Console.ReadLine(), exerciseOption, 20, 0, 0, 2);
            Console.SetCursorPosition(25, 1);
            int duration = Validation.ValidataInputOption(1, 300, 25, 1, 0, 2);
            double caloriesBurned = FitnessAppEngine.CalculateExercisesCalories(exerciseName, exerciseOption, duration);
            Console.SetCursorPosition(0, 2);
            Console.Write($"Calories to be Burned:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(caloriesBurned + " C/M");
            Console.ResetColor();
            Console.WriteLine("\n********************************************************************");
            Console.WriteLine("1. Add to your Workout Plan");
            Console.WriteLine("2. Back to Exercises Menu");
            Console.WriteLine("0. Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice (0-2):");
            Console.ForegroundColor = ConsoleColor.White;
            int option = Validation.ValidataInputOption(0, 2, 24, 7, 0, 8);
            switch (option)
            {
                case 1:
                    FitnessAppEngine.AddExerciseToWorkoutPlan(exerciseName, exerciseOption, caloriesBurned, duration);
                    break;
                case 2:
                    FitnessAppEngine.SwitchExerciseOption();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        public static int WorkoutPlanOptionMenu()
        {
            Console.Clear();
            Console.WriteLine("1. View Today's Workout Plan");
            Console.WriteLine("2. Back to Main Menu");
            Console.WriteLine("0. Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice (0-2):");
            Console.ForegroundColor = ConsoleColor.White;
            int option = Validation.ValidataInputOption(0, 2, 24, 4, 0, 5);
            return option;
        }
        public static void ViewWorkoutPlan()
        {
            Console.Clear();
            // عايز هنا مايثود بترجع اذا كان في تمارين مضافه لليوم ده او لا 
            //if()
            //{ 
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine(FitnessAppEngine.CenterText("+==============================================================================+"));
            //Console.WriteLine(FitnessAppEngine.CenterText("|                         📋TODAY'S WORKOUT PLAN📋                            |"));
            //Console.WriteLine(FitnessAppEngine.CenterText("+==============================================================================+"));
            //Console.WriteLine(FitnessAppEngine.CenterText("| # | Exercise         | Type         | Cal/min | Duration (min) | Total kcal  |"));
            //Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------------------------------------+"));
            //int YAxis = 5;
            //foreach (var item in WorkoutPlan.workoutItems)
            //{
            //    Console.ForegroundColor = ConsoleColor.Magenta;
            //    Console.WriteLine(FitnessAppEngine.CenterText("|   |                  |              |         |                |             |"));
            //    Console.SetCursorPosition(2, YAxis);
            //    Console.Write($"{WorkoutPlan.workoutItems.IndexOf(item) + 1}");
            //    Console.SetCursorPosition(6, YAxis);
            //    Console.Write($"{item.Exercise.Name}");
            //    Console.SetCursorPosition(22, YAxis);
            //    Console.Write($"{item.Exercise.Type}");
            //    Console.SetCursorPosition(36, YAxis);
            //    Console.Write($"{item.Exercise.CaloriesPerMinute} C/M");
            //    Console.SetCursorPosition(46, YAxis);
            //    Console.Write($"{item.Duration} Min");
            //    Console.SetCursorPosition(62, YAxis);
            //    Console.Write($"{item.Exercise.CalculateCalories(item.Duration)} C");
            //    YAxis++;
            //}
            //Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------------------------------------+"));
            //Console.WriteLine(FitnessAppEngine.CenterText("| Total sessions: Total kcal:        |                                          "));
            //Console.WriteLine(FitnessAppEngine.CenterText("+------------------------------------------------------------------------------+"));
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.SetCursorPosition(18, YAxis);
            //Console.ForegroundColor = ConsoleColor.DarkGray;
            //Console.WriteLine(FitnessAppEngine.CenterText("Press any key to Back to Workout Plan menu 📄"));
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.ReadKey();
            //Console.Clear();
            //}
            //else
            //{
            //    Console.WriteLine("No exercises added to today's workout plan.");
            //    Console.WriteLine("Press any key to Back to Workout Plan menu 📄");
            //    Console.ReadKey();
            //    Console.Clear();
            //}
        }































        //دالة WriteSlow تقوم بكتابة النص ببطء على الشاشة
        public static void WriteSlow(string word, int delay, int xaxis, int yaxis)
        {
            //loop تلف حول طول الكلمة وتقوم بكتابتها ببطء في المكان المحدد
            for (int i = 0; i < word.Length; i++)
            {
                // تعيين موضع الكتابة على الشاشة
                Console.SetCursorPosition(xaxis + i, yaxis);
                // كتابة الحرف الحالي من الكلمة
                Console.Write(word[i]);
                // الانتظار لمدة معينة قبل كتابة الحرف التالي
                Thread.Sleep(delay);
            }
        }
        //دالة space تقوم بإزالة الكتابة في مكان معين في الشاشة
        public static void Space(string input, int xaise, int yaise)
        {
            int positionX = xaise;
            int i = 0;
            int LengthOfInput = input.Length;
            //loop تلف حول طول الإدخال وتقوم بإزالة الكتابة في المكان المحدد

            while (i < LengthOfInput)
            {
                positionX = xaise + i;
                if (positionX == Console.BufferWidth)
                {
                    LengthOfInput -= i;
                    i = 0;
                    yaise++;
                    positionX = xaise;
                }
                // التحقق من أن الموضع لا يتجاوز حدود الشاشة
                // console.BufferWidth و Console.BufferHeight تعطيان عرض وارتفاع الشاشة
                if (positionX < Console.BufferWidth && yaise < Console.BufferHeight)
                {
                    Console.SetCursorPosition(positionX, yaise);
                    Console.Write(" ");
                }
                i++;
            }
        }

    }
}
