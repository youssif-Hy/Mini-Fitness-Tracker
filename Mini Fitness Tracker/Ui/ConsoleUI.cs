using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mini_Fitness_Tracker;
using Mini_Fitness_Tracker.Engine;

namespace Mini_Fitness_Tracker.Ui
{
    public class ConsoleUI
    {
        public static void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Program.CenterText("███╗░░░███╗██╗███╗░░██╗██╗  ███████╗██╗████████╗███╗░░██╗███████╗░██████╗░██████╗"));
            Console.WriteLine(Program.CenterText("████╗░████║██║████╗░██║██║  ██╔════╝██║╚══██╔══╝████╗░██║██╔════╝██╔════╝██╔════╝"));
            Console.WriteLine(Program.CenterText("██╔████╔██║██║██╔██╗██║██║  █████╗░░██║░░░██║░░░██╔██╗██║█████╗░░╚█████╗░╚█████╗░"));
            Console.WriteLine(Program.CenterText("██║╚██╔╝██║██║██║╚████║██║  ██╔══╝░░██║░░░██║░░░██║╚████║██╔══╝░░░╚═══██╗░╚═══██╗"));
            Console.WriteLine(Program.CenterText("██║░╚═╝░██║██║██║░╚███║██║  ██║░░░░░██║░░░██║░░░██║░╚███║███████╗██████╔╝██████╔╝"));
            Console.WriteLine(Program.CenterText("╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝╚═╝  ╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚══╝╚══════╝╚═════╝░╚═════╝░"));
            Console.WriteLine(Program.CenterText("████████╗██████╗░░█████╗░░█████╗░██╗░░██╗███████╗██████╗░"));
            Console.WriteLine(Program.CenterText("╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██║░██╔╝██╔════╝██╔══██╗"));
            Console.WriteLine(Program.CenterText("░░░██║░░░██████╔╝███████║██║░░╚═╝█████═╝░█████╗░░██████╔╝"));
            Console.WriteLine(Program.CenterText("░░░██║░░░██╔══██╗██╔══██║██║░░██╗██╔═██╗░██╔══╝░░██╔══██╗"));
            Console.WriteLine(Program.CenterText("░░░██║░░░██║░░██║██║░░██║╚█████╔╝██║░╚██╗███████╗██║░░██║"));
            Console.WriteLine(Program.CenterText("░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝"));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Program.CenterText("Welcome to the Mini Fitness Tracker🏋️!"));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(Program.CenterText("Press any key to continue..."));
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static int DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Program.CenterText("Welcome to the Mini Fitness Tracker🏋️!"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Log In");
            Console.WriteLine("2. Register");
            Console.WriteLine("0. Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice (0-2):");
            Console.ForegroundColor = ConsoleColor.White;
            int option = Validation.ValidataInputOption( 0, 2, 24, 4, 0, 5);

            return option;
        }
        // دالة LogIn تقوم بعرض واجهة تسجيل الدخول للمستخدم
        public static void LogIn()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            // ASCII Art لعرض عنوان تسجيل الدخول 
            Console.WriteLine(Program.CenterText("╔══════════════════════════════════════════════════════╗"));
            Console.WriteLine(Program.CenterText("║                       LOG IN                         ║"));
            Console.WriteLine(Program.CenterText("║               --------------------------             ║"));
            Console.WriteLine(Program.CenterText("║                                                      ║"));
            Console.WriteLine(Program.CenterText("║   ➤ Enter Your Username :                            ║"));
            Console.WriteLine(Program.CenterText("║   ➤ Enter Your Password :                            ║"));
            Console.WriteLine(Program.CenterText("║                                                      ║"));
            Console.WriteLine(Program.CenterText("║               [ Press ENTER to Submit ]              ║"));
            Console.WriteLine(Program.CenterText("╚══════════════════════════════════════════════════════╝"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(59, 4); // اعادة تعيين موضع المؤشر لاسم المستخدم
            string user_name = Console.ReadLine();
            Console.SetCursorPosition(59, 5); // اعادة تعيين موضع المؤشر لكلمة المرور
            string password = Console.ReadLine();
            //*************************************************************************************
            // Ahmed mo (Engine)
            // bool isValidUser = FitnessAppEngine.Login(user_name, password);
            //*************************************************************************************
            // if (isValidUser)
            // {
            //    Console.WriteLine(Program.CenterText("Login successful!"));
            //    Console.WriteLine(Program.CenterText("Press any key to continue..."));
            //    Console.ReadKey();
            //    console.Clear();
            // }
            // else
            // {
            //    Console.WriteLine(Program.CenterText("Invalid username or password. Please try again."));
            //    Console.WriteLine(Program.CenterText("Press any key to continue..."));
            //    Console.ReadKey();
            //    console.Clear();
            // }
            // return isValidUser;
        }
        // دالة Register تقوم بعرض واجهة تسجيل مستخدم جديد
        public static void Register()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            // عرض واجهة المستخدم لتسجيل حساب جديد
            Console.WriteLine(Program.CenterText("+================================================================================+"));
            Console.WriteLine(Program.CenterText("|                                 Register                                       |"));
            Console.WriteLine(Program.CenterText("+================================================================================+"));
            Console.WriteLine(Program.CenterText("| ➤ Username          :                                                          |"));
            Console.WriteLine(Program.CenterText("| ➤ Password          :                                                          |"));
            Console.WriteLine(Program.CenterText("| ➤ Name              :                                                          |"));
            Console.WriteLine(Program.CenterText("| ➤ Age               :                                                          |"));
            Console.WriteLine(Program.CenterText("| ➤ Height            :                                                          |"));
            Console.WriteLine(Program.CenterText("| ➤ Weight            :                                                          |"));
            Console.WriteLine(Program.CenterText("+================================================================================+"));
            Console.WriteLine(Program.CenterText("|          [ Please enter the required information above ]                       |"));
            Console.WriteLine(Program.CenterText("|          [ Press ENTER after each input to continue ]                          |"));
            Console.WriteLine(Program.CenterText("+================================================================================+"));
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

            //******************************************************************************
            // Ahmed mo (Engine)
            // يا احمد عايزك نعمل دالة في محرك التطبيق اسمها ValidataHeight بنفس الطريقة اللي عملتها في باقي ميثودز التحقق
            // string Height = Vaidation.ValidataHeight(Console.ReadLine(), 42, 7, 0, 14);
            //******************************************************************************

            Console.SetCursorPosition(42, 8);
            //******************************************************************************
            // Ahmed mo (Engine)
            // يا احمد عايزك نعمل دالة في محرك التطبيق اسمها ValidataWeight بنفس الطريقة اللي عملتها في باقي ميثودز التحقق
            // string Weight = Vaidation.ValidataWeight(Console.ReadLine(), 42, 8, 0, 14);
            //******************************************************************************

            //***********************************************************************************************************************
            // هو انا مش عارف هي الميثود دي المفروض مين اللي بيعملها المهم اللي هيعمبها يبقى يعملها ويشيل الكومنتات
            // هنا عازك نعمل ميثود في محرك التطبيق اسمها Register بتاخد البراميترز دي عشان تسجل المستخدم
            // FitnessAppEngine.Register(username, password, name, int.Parse(Age) , double.Parse(Height), double.Parse(Weight));
            //***********************************************************************************************************************
            Console.WriteLine(Program.CenterText("Registration successful!"));
            Console.WriteLine(Program.CenterText("Press any key to continue..."));
            Console.ReadKey();
            Console.Clear();
        }
        public static int mainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Program.CenterText("Main Menu"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Profile");
            Console.WriteLine("2. Exercises");
            Console.WriteLine("3. Workout Plan");
            Console.WriteLine("4. Progress");
            Console.WriteLine("0. Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice (0-4):");
            Console.ForegroundColor = ConsoleColor.White;
            int option = Validation.ValidataInputOption(0, 4, 24, 6, 0, 7);

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
        public static void CalculateExercisesCalories(int exerciseOption)
        {
            Console.Clear();
            Console.WriteLine("Enter exercise name:");
            Console.WriteLine("Enter duration (minutes):");
            Console.SetCursorPosition(30, 0);
            string exerciseName = Validation.ValiDataExerciseName(Console.ReadLine(), exerciseOption, 30, 0, 0, 2);
            Console.SetCursorPosition(30, 1);
            int duration = Validation.ValidataInputOption(1, 300, 30, 1, 0, 2);
            //******************************************************************************
            //double caloriesBurned = CalculateExercisesCalories(exerciseOption, duration);
            //Console.WriteLine($"Calories ti be Burned:{caloriesBurned}");
            //******************************************************************************



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
            //loop تلف حول طول الإدخال وتقوم بإزالة الكتابة في المكان المحدد
            for (int i = 0; i < input.Length; i++)
            {
                int positionX = xaise + i;
                // التحقق من أن الموضع لا يتجاوز حدود الشاشة
                // console.BufferWidth و Console.BufferHeight تعطيان عرض وارتفاع الشاشة
                if (positionX < Console.BufferWidth && yaise < Console.BufferHeight)
                {
                    Console.SetCursorPosition(positionX, yaise);
                    Console.Write(" ");
                }
            }
        }
    }
}
