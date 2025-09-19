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

       
        public static void Register(string username,string password,string name,int age , double height, double weight)
        {
            string lines = $"{username},{password},{name},{age},{height},{weight}";

            
           
            if(File.Exists(UserDataFile))
            {
                File.AppendAllText(UserDataFile, lines);
            }
            else
            {
                File.WriteAllText(UserDataFile, lines);
            }

                
        }

        
        public static bool CheckLogin(string username, string password)
        {
            var users = new List<User>();
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
                      return true;
                    }
                }
            }
            return false;
        }
    }
}
