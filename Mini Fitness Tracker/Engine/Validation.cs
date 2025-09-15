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
        public static int ValidataInput(string input, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            int value;
            string title = "Invalid input ,try again plese enter valid input";
            while (true)
            {
                // التحقق من أن الإدخال هو رقم صحيح
                if (!int.TryParse(input, out value))
                {
                    Space(title, xaxis1, yaxis1);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    WriteSlow(title, 20, xaxis1, yaxis1);
                    Space(input, xaxis, yaxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xaxis, yaxis);
                    input = Console.ReadLine();
                }
                else
                {
                    Space(title, xaxis1, yaxis1);
                    return value;
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
                    if (age <= 13 && age >= 100)
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
