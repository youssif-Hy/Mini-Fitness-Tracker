using Mini_Fitness_Tracker.Ui;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mini_Fitness_Tracker.Ui.ConsoleUI;

namespace Mini_Fitness_Tracker.Engine
{
    public class Validation
    {
        //دالة ValidateInput تقوم بالتحقق من صحة الإدخال المدخل من قبل المستخدم
        public static int ValidataInput(string input, int xAxis, int yAxis, int xAxis1, int yAxis1)
        {
            int value;
            string title = "Invalid input ,try again plese enter valid input";
            while (true)
            {
                // التحقق من أن الإدخال هو رقم صحيح
                if (!int.TryParse(input, out value))
                {
                    Space(title, xAxis1, yAxis1);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    WriteSlow(title, 20, xAxis1, yAxis1);
                    Space(input, xAxis, yAxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xAxis, yAxis);
                    input = Console.ReadLine();
                }
                else
                {
                    Space(title, xAxis1, yAxis1);
                    return value;
                }
            }
        }
        public static int ValidataInputOption(int minOption,int maxOption, int xAxis, int yAxis, int xAxis1, int yAxis1)
        {
            int option;
            //loop للتأكد من إدخال المستخدم خيار صحيح
            while (true)
            {
                // رسالة خطأ في حالة إدخال غير صحيح
                string errorMessage = $"Invalid input, please enter a number between {minOption} and {maxOption}.";
                // تعيين موضع المؤشر في الشاشة
                Console.SetCursorPosition(xAxis, yAxis);
                // قراءة إدخال المستخدم والتحقق من صحته
                option = Validation.ValidataInput(Console.ReadLine(), xAxis, yAxis, xAxis1, yAxis1);
                // إذا كان الخيار غير صحيح، عرض رسالة الخطأ
                if (option >= minOption && option <= maxOption)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Space(errorMessage, xAxis1, yAxis1);
                    break;

                }
                // إذا كان الإدخال صحيحًا، الخروج من الحلقة
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    WriteSlow(errorMessage, 20, xAxis1, yAxis1);
                    Console.ForegroundColor = ConsoleColor.White;
                    Space(option.ToString(),xAxis, yAxis);
                }
            }
            return option;
        }
        // دالة ValiDataExerciseNameForCardio تقوم بالتحقق من صحة اسم التمرين المدخل
        public static string ValiDataExerciseName(string exerciseName, int exerciseOption, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            string title;
            List<string> validExerciseNames;
            if (exerciseOption == 1)
            {
                title = "Invalid Exercise Name, Please enter a valid Exercise Name (ex. Running, Cycling, Swimming, Walking, Jump Rope, Stair Climbing, Dancing, Boxing, Rowing, Basketball, Tennis), try again. ";
                validExerciseNames = new List<string>
                {
                "running", "cycling", "swimming", "walking", "jump rope", "stair climbing", "dancing", "boxing", "rowing", "basketball", "tennis"
                };
            }
            else if(exerciseOption == 2)
            {
                title = "Invalid Exercise Name, Please enter a valid Exercise Name (ex. Squats, Lunges, Push-ups, Pull-ups, Deadlifts, Bench Press, plank, Shoulder Press, Bicep Curls, Kettlebell Training), try again. ";
                validExerciseNames = new List<string>
                {
                "squats", "lunges", "push-ups", "pull-ups", "deadlifts", "bench press", "plank", "shoulder press", "bicep curls", "kettlebell training"
                };
            }
            else
            {
                title = "Invalid Exercise Name, Please enter a valid Exercise Name (ex. Yoga, Pilates, Stretching, Tai Chi, Dance-based Exercises, Balance Exercises, Mobility Exercises, Foam Rolling), try again. ";
                validExerciseNames = new List<string>
                {
                 "yoga", "pilates", "stretching", "tai chi", "dance-based exercises", "balance exercises", "mobility exercises", "foam rolling"
                };
            }
            while (true)
            {
                if (validExerciseNames.Contains(exerciseName.ToLower()))
                {
                    Space(title, xaxis1, yaxis1);
                    return exerciseName;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(xaxis1, yaxis1);
                    Console.Write(title);
                    Space(exerciseName, xaxis, yaxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xaxis, yaxis);
                    exerciseName = Console.ReadLine();
                }
            }
        }
        // دالة ValidateUsername تقوم بالتحقق من صحة اسم المستخدم المدخل
        public static string ValidataUsername(string username, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            string title = "Invalid username, Please enter a valid username (at least 5 characters), try again. ";

            while (true)
            {
                if (username.Length >= 5 && !username.Contains(" ") && !username.All(char.IsDigit) && !username.All(char.IsLetter))
                {
                    Space(title, xaxis1, yaxis1);
                    string title1 = "Username already exists, Please enter a different username, try again. ";
                    // التحقق من وجود اسم المستخدم في بيانات المستخدمين
                    //*********************************************************************************************************************************************
                    // هنا عايزك تبقى تغير الكود ده وتخليه يشيك على اسم المستخدم في الداتا ويشوفه لو موجود يرجعلي اسم مستخدم تاني لو مش موجود يرجعلي اسم المستخدم
                    if (username != username/* UserName from data */ )
                    {
                        return username;
                    }
                    //*********************************************************************************************************************************************
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(xaxis1, yaxis1);
                        Console.Write(title1);
                        Space(username, xaxis, yaxis);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(xaxis, yaxis);
                        username = Console.ReadLine();
                    }
                }
                // إذا كان اسم المستخدم غير صالح، يطلب من المستخدم إدخال اسم مستخدم آخر
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(xaxis1, yaxis1);
                    Console.Write(title);
                    Space(username, xaxis, yaxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xaxis, yaxis);
                    username = Console.ReadLine();
                }
            }
        }
        // دالة ValiDataName تقوم بالتحقق من صحة الاسم المدخل
        public static string ValiDataName(string name, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            string title = "invalid name, Please enter a valid name (at least 8 characters,first and last name must be more than 3 characters) ,try again. ";
            while (true)
            {
                // التحقق من طول الاسم ووجود مسافة بين الاسم الأول والاسم الأخير
                if (name.Length > 7 && name.Contains(' '))
                {
                    // تقسيم الاسم إلى أجزاء باستخدام المسافة كفاصل
                    string[] nameParts = name.Split(' ');
                    // التحقق من أن الاسم الأول والاسم الأخير يتكونان من أحرف فقط وطولهما أكبر من 3 أحرف
                    if (nameParts[0].Length > 3 && nameParts[0].All(char.IsLetter) && nameParts[1].Length > 3 && nameParts[1].All(char.IsLetter))
                    {
                        Space(title, xaxis1, yaxis1);
                        return name;
                    }
                    // إذا لم يكن الاسم صالحًا، يطلب من المستخدم إدخال اسم آخر
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(xaxis1, yaxis1);
                        Console.Write(title);
                        Space(name, xaxis, yaxis);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(xaxis, yaxis);
                        name = Console.ReadLine();
                    }
                }
                // إذا لم يكن الاسم صالحًا، يطلب من المستخدم إدخال اسم آخر
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(xaxis1, yaxis1);
                    Console.Write(title);
                    Space(name, xaxis, yaxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xaxis, yaxis);
                    name = Console.ReadLine();
                }
            }
        }
        //دالة ValidatePassword تقوم بالتحقق من صحة كلمة المرور المدخلة
        public static string ValidataPassword(string password, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            string title = "Invalid password, Please enter a valid password (8 to 18 characters), try again. ";
            while (true)
            {
                if (password.Length >= 8 && password.Length <= 18)
                {
                    Space(title, xaxis1, yaxis1);
                    return password;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(xaxis1, yaxis1);
                    Console.Write(title);
                    Space(password, xaxis, yaxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xaxis, yaxis);
                    password = Console.ReadLine();
                }
            }
        }
        public static string ValiDataAge(string Age, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            while (true)
            {
                string title = "Invalid Age, Please enter a valid Age (13 to 100), try again. ";
                int age;
                // محاولة تحليل التاريخ المدخل إلى كائن DateTime
                if (int.TryParse(Age, out age))
                {

                    // التحقق من أن تاريخ الميلاد لا يكون في المستقبل
                    if (age >= 13 && age <= 100)
                    {
                        Space(title, xaxis1, yaxis1);
                        return Age;
                    }
                    // إذا كان تاريخ الميلاد في المستقبل، يطلب من المستخدم إدخال تاريخ آخر
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(xaxis1, yaxis1);
                        Console.Write(title);
                        Space(Age, xaxis, yaxis);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(xaxis, yaxis);
                        Age = Console.ReadLine();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(xaxis1, yaxis1);
                    Console.Write(title);
                    Space(Age, xaxis, yaxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xaxis, yaxis);
                    Age = Console.ReadLine();
                }
            }
        }
    }
}
