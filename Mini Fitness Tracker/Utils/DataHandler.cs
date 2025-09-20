using Mini_Fitness_Tracker.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Mini_Fitness_Tracker.Ui;

namespace Mini_Fitness_Tracker.Utils
{
    public static class DataHandler
    {
        private static string UserDataFile = "users.txt";
        public static void Register(string username, string password, string name, int age, double height, double weight)
        {
            string lines = $"{username},{password},{name},{age},{height},{weight}";
            if (File.Exists(UserDataFile))
            {
                File.AppendAllText(UserDataFile, Environment.NewLine + lines);
            }
            else
            {
                File.WriteAllText(UserDataFile, lines);
            }
        }
        public static bool CheckLogin(string username, string password)
        {
            if (File.Exists(UserDataFile)) // التحقق من وجود ملف بيانات المستخدمين
            {
                string[] lines = File.ReadAllLines(UserDataFile);// قراءة جميع الأسطر من الملف
                foreach (string line in lines)
                {
                    // تقسيم السطر إلى أجزاء باستخدام الفاصلة كفاصل
                    string[] parts = line.Split(',');
                    // التحقق من تطابق اسم المستخدم وكلمة المرور

                    if (parts[0] == username && parts[1] == password)
                    {
                        User user = new User(parts[0], parts[1], parts[2], int.Parse(parts[3]), double.Parse(parts[4]), double.Parse(parts[5]));
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CheckIfUsernameExists(string username)
        {
            if (File.Exists(UserDataFile)) // التحقق من وجود ملف بيانات المستخدمين
            {
                string[] lines = File.ReadAllLines(UserDataFile);// قراءة جميع الأسطر من الملف
                foreach (string line in lines)
                {
                    // تقسيم السطر إلى أجزاء باستخدام الفاصلة كفاصل
                    string[] parts = line.Split(',');
                    // التحقق من تطابق اسم المستخدم وكلمة المرور

                    if (parts[0] == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void EditName(string newname)
        {

            string[] lines = File.ReadAllLines(UserDataFile);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts[0] == User.Username)
                {
                    parts[2] = newname;
                    User.Name = newname;
                }
            }
            File.WriteAllLines(UserDataFile, lines); // كتابة التغييرات إلى الملف
        }
        public static void EditAge(int newage)
        {
            string[] lines = File.ReadAllLines(UserDataFile);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts[0] == User.Username)
                {
                    parts[3] = newage.ToString();
                    User.Age = newage;
                }
            }
            File.WriteAllLines(UserDataFile, lines);
        }
        public static void EditWeight(double newweight)
        {
            string[] lines = File.ReadAllLines(UserDataFile);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts[0] == User.Username)
                {
                    parts[4] = newweight.ToString();
                    User.Weight = newweight;
                }
            }
            File.WriteAllLines(UserDataFile, lines);
        }
        public static void EditHeight(double newheight)
        {
            string[] lines = File.ReadAllLines(UserDataFile);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts[0] == User.Username)
                {
                    parts[5] = newheight.ToString();
                    User.Height = newheight;
                }
            }
            File.WriteAllLines(UserDataFile, lines);
        }

       public static void addworkoutplan(string exerciseName, double caloriesBurned,int duration)
        {
            string workoutplanfile = $"{User.Username}_workoutplans.txt";
            string lines = $"{exerciseName},{caloriesBurned},{duration}";
            if (File.Exists(workoutplanfile))
            {
                File.AppendAllText(workoutplanfile, Environment.NewLine + lines);
            }
            else
            {
                File.WriteAllText(workoutplanfile, lines);
            }
        }
    public static bool viewworkoutplans()
        {
            string workoutplanfile = $"{User.Username}_workoutplans.txt";
            if (File.Exists(workoutplanfile)) // التحقق من وجود ملف بيانات المستخدمين
            {
                string[] lines = File.ReadAllLines(workoutplanfile);// قراءة جميع الأسطر من الملف
                foreach (string line in lines)
                {
                    // تقسيم السطر الى جزاء باتخدام الفاصلة كفاصل
                    string[] parts = line.Split(',');
                    Console.WriteLine($"Exercise Name: {parts[0]}, Calories Burned: {parts[1]}, Duration: {parts[2]} minutes");
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
