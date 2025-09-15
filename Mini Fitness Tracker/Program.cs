using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Fitness_Tracker.Ui;

namespace Mini_Fitness_Tracker
{
    internal class Program
    {
        static void Main()
        {
            ConsoleUI.DisplayWelcomeMessage();
            int userOption = ConsoleUI.DisplayMenu();
            switch(userOption)
            {
                case 1:
                    ConsoleUI.LogIn();
                    break;
                case 2:
                    ConsoleUI.Register();
                    break;
                case 3:
                    // threed Massege 
                    break;
                default:
                    //
                    break;


            }
        }
        // دالة CenterText تقوم بجعل النص في وسط الشاشة
        public static string CenterText(string text)
        {
            int padding = (Console.WindowWidth - text.Length) / 2;
            return new string(' ', Math.Max(padding, 0)) + text;
        }
    }
}
