using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using Mini_Fitness_Tracker.Models;
using Mini_Fitness_Tracker.Ui;

namespace Mini_Fitness_Tracker.Utils
{
    public static class DataHandler
    {
        private static string UserDataFile = "users.txt"; // ملف لتخزين بيانات المستخدمين
        
        // تسجيل مستخدم جديد
        public static void Register(string username, string password, string name, int age, double height, double weight)
        {
            string lines = $"{username},{password},{name},{age},{height},{weight}";

            string[] parts = lines.Split(',');
            
            //save user data in user object
            User user = new User(parts[0], parts[1], parts[2], int.Parse(parts[3]), double.Parse(parts[4]), double.Parse(parts[5]));

            //if file exists append the new user data, else create the file and write the user data
            if (File.Exists(UserDataFile))
            {
                File.AppendAllText(UserDataFile, Environment.NewLine +lines);
            }
            else
            {
                File.WriteAllText(UserDataFile, lines);
            }
        }
        // التحقق من تسجيل الدخول
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
        //
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
            List<string> updatedLines = lines.ToList();

            for (int i = 0; i < updatedLines.Count; i++)
            {
                string[] parts = updatedLines[i].Split(',');

                if (parts[0] == User.Username) // لو ده المستخدم اللي عايز اعدل بياناته
                {
                    parts[2] = newname;        // عدّل العمود اللي فيه الاسم
                    User.Name = newname;       // حدّث الكائن كمان

                    // خزّن السطر المعدّل في نفس المكان (overwrite مش Add)
                    updatedLines[i] = string.Join(",", parts);
                }
            }

            // اكتب كل السطور المعدلة مرة واحدة
            File.WriteAllLines(UserDataFile, updatedLines);
            deleteNullLines();
        }

        public static void EditAge(int newAge)
        {
            string[] lines = File.ReadAllLines(UserDataFile);
            List<string> updatedLines = lines.ToList();

            for (int i = 0; i < updatedLines.Count; i++)
            {
                string[] parts = updatedLines[i].Split(',');

                if (parts[0] == User.Username) // لو ده المستخدم اللي عايز اعدل بياناته
                {
                    parts[3] = newAge.ToString();        // عدّل العمود اللي فيه الاسم
                    User.Age = newAge;       // حدّث الكائن كمان

                    // خزّن السطر المعدّل في نفس المكان (overwrite مش Add)
                    updatedLines[i] = string.Join(",", parts);
                }
            }

            // اكتب كل السطور المعدلة مرة واحدة
            File.WriteAllLines(UserDataFile, updatedLines);
            deleteNullLines();
        }
        public static void EditHeight(double newHeight)
        {
            string[] lines = File.ReadAllLines(UserDataFile);
            List<string> updatedLines = lines.ToList();

            for (int i = 0; i < updatedLines.Count; i++)
            {
                string[] parts = updatedLines[i].Split(',');

                if (parts[0] == User.Username) // لو ده المستخدم اللي عايز اعدل بياناته
                {
                    parts[4] = newHeight.ToString();        // عدّل العمود اللي فيه الاسم
                    User.Height = newHeight;       // حدّث الكائن كمان

                    // خزّن السطر المعدّل في نفس المكان (overwrite مش Add)
                    updatedLines[i] = string.Join(",", parts);
                }
            }

            // اكتب كل السطور المعدلة مرة واحدة
            File.WriteAllLines(UserDataFile, updatedLines);
            deleteNullLines();
        }
        public static void EditWeight(double newWeight)
        {
            string[] lines = File.ReadAllLines(UserDataFile);
            List<string> updatedLines = lines.ToList();

            for (int i = 0; i < updatedLines.Count; i++)
            {
                string[] parts = updatedLines[i].Split(',');

                if (parts[0] == User.Username) // لو ده المستخدم اللي عايز اعدل بياناته
                {
                    parts[5] = newWeight.ToString();        // عدّل العمود اللي فيه الاسم
                    User.Weight = newWeight;       // حدّث الكائن كمان

                    // خزّن السطر المعدّل في نفس المكان (overwrite مش Add)
                    updatedLines[i] = string.Join(",", parts);
                }
            }

            // اكتب كل السطور المعدلة مرة واحدة
            File.WriteAllLines(UserDataFile, updatedLines);
            deleteNullLines();
        }
        
        // إضافة خطة تمرين جديدة
        public static void AddWorkOutPlan(string exerciseName, double caloriesBurned, int duration)
        {
            string workoutplanfile = $"{User.Username}_workoutplans.txt"; //name of file depends on username

            string lines = $"{DateTime.Today.ToString("d")},{exerciseName},{caloriesBurned},{duration}";

            if (File.Exists(workoutplanfile))
            {
                File.AppendAllText(workoutplanfile, Environment.NewLine + lines);
            }
            else
            {
                File.WriteAllText(workoutplanfile, lines);
            }
        }

        // حذف خطة تمرين
        public static void deleteExerciseWorkOutPlan(int index)
        {
            string workoutplanfile = $"{User.Username}_workoutplans.txt";
            string[] lines = File.ReadAllLines(workoutplanfile);

            if (File.Exists(workoutplanfile))
            {
                List<string> strings = lines.ToList(); // تحويل المصفوفة إلى قائمة لتسهيل الحذف

                int i = 0;
                foreach (var part in lines)
                {
                    string[] parts = part.Split(',');

                    if (parts[0] == DateTime.Today.ToString("d"))
                    {  
                        strings.RemoveAt(index+i);
                        WorkoutPlan.WorkoutPlans.RemoveAt(index);
                        break;
                    }
                    i++;
                }
                File.WriteAllLines(workoutplanfile, strings);
                deleteNullLines();
            }
        }

        // قراءة خطة التمرين من الملف وإضافتها إلى القائمة
        public static void AddWorkOutPlanInList()
        {
            WorkoutPlan.WorkoutPlans.Clear();
            string workoutplanfile = $"{User.Username}_workoutplans.txt";
            if (File.Exists(workoutplanfile)) // التحقق من وجود ملف بيانات المستخدمين
            {
                string type = "";
                string[] lines = File.ReadAllLines(workoutplanfile);// قراءة جميع الأسطر من الملف
                foreach (string line in lines)
                {
                    // تقسيم السطر إلى أجزاء باستخدام الفاصلة كفاصل
                    string[] parts = line.Split(',');
                    // التحقق من تطابق اسم المستخدم وكلمة المرور

                    if (parts[0] == DateTime.Today.ToString("d"))
                    {
                        if (parts[1].Equals("running") || parts[1].Equals("cycling") || parts[1].Equals("swimming") || parts[1].Equals("walking") || parts[1].Equals("jump rope") || parts[1].Equals("stair climbing") || parts[1].Equals("dancing") || parts[1].Equals("boxing") || parts[1].Equals("rowing") || parts[1].Equals("basketball") || parts[1].Equals("tennis"))
                        {
                            type = "Cardio";
                        }
                        else if (parts[1].Equals("squats") || parts[1].Equals("lunges") || parts[1].Equals("push-ups") || parts[1].Equals("pull-ups") || parts[1].Equals("deadlifts") || parts[1].Equals("bench press") || parts[1].Equals("plank") || parts[1].Equals("shoulder press") || parts[1].Equals("bicep curls") || parts[1].Equals("kettlebell training"))
                        {
                            type = "Strength";
                        }
                        else
                        {
                            type = "Yoga";
                        }
                        //create exercise object and add it to the list
                        Exercise ex = new Exercise(parts[1], type, (double.Parse(parts[2]) / int.Parse(parts[3])), double.Parse(parts[2]), int.Parse(parts[3]));
                        
                        WorkoutPlan.WorkoutPlans.Add(ex);
                    }
                }
            }
        }

        public static bool CheckWorkOutPlanToday()
        {
            string workoutplanfile = $"{User.Username}_workoutplans.txt";
            if (File.Exists(workoutplanfile)) // التحقق من وجود ملف بيانات المستخدمين
            {
                string[] lines = File.ReadAllLines(workoutplanfile);// قراءة جميع الأسطر من الملف
                foreach (string line in lines)
                {
                    // تقسيم السطر الى جزاء باتخدام الفاصلة كفاصل
                    string[] parts = line.Split(',');
                    if (parts[0] == DateTime.Today.ToString("d"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void ProgressToday()
        {
            int totalDuration = 0;
            double totalCalories = 0;

            string workoutplanfile = $"{User.Username}_workoutplans.txt";
            if (File.Exists(workoutplanfile)) // التحقق من وجود ملف بيانات المستخدمين
            {
                Progresstracker prgrs = new Progresstracker();
                string[] lines = File.ReadAllLines(workoutplanfile);// قراءة جميع الأسطر من الملف
                foreach (string line in lines)
                {
                    // تقسيم السطر الى جزاء باتخدام الفاصلة كفاصل
                    string[] parts = line.Split(',');
                    if (parts[0] == DateTime.Today.ToString("d"))
                    {
                        totalDuration += int.Parse(parts[3]);
                        totalCalories += double.Parse(parts[2]);
                    }
                }
                prgrs.UpdatedayProgress(totalDuration,totalCalories);
                ConsoleUI.ViewDailyProgress();
            }
        }

        public static void ProgressWeek()
        {
            string workoutplanfile = $"{User.Username}_workoutplans.txt";

            if (File.Exists(workoutplanfile)) // التحقق من وجود ملف بيانات المستخدمين
            {
                Progresstracker prgrs = new Progresstracker();
                string[] lines = File.ReadAllLines(workoutplanfile);// قراءة جميع الأسطر من الملف
               
                DateTime latestDate = DateTime.Parse(lines[lines.Length-1].Split(',')[0]);
                DateTime minDate = latestDate.AddDays(-6);


                int totalDuration = 0;
                double totalCalories = 0;

                for (int i=lines.Length-1;i>=0;i--)
                {

                    string[] parts = lines[i].Split(',');
                    DateTime date = DateTime.Parse(parts[0]);
                    if (date < minDate)
                    {
                        break;
                    }


                    int duration = int.Parse(parts[3]);
                    double calories = double.Parse(parts[2]);


                    totalCalories += calories;
                    totalDuration += duration;
                }
                prgrs.UpdateweekProgress(totalDuration, totalCalories);
                ConsoleUI.ViewWeeklyProgress();
            }
            
        }
        public static void deleteNullLines()
        {
            List<string> newlines = new List<string>();
            string workoutplanfile = $"{User.Username}_workoutplans.txt";
            if (File.Exists(workoutplanfile))
            {
                string[] lines = File.ReadAllLines(workoutplanfile);
                foreach (string line in lines)
                {
                    if(line != null)
                    {
                        newlines.Add(line);
                    }
                }
                File.WriteAllLines(workoutplanfile, newlines);
            }
        }

    }
}
