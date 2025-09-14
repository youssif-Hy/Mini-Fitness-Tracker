using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Fitness_Tracker
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Mini Fitness Tracker!");
        }
        // دالة CenterText تقوم بجعل النص في وسط الشاشة
        public static string CenterText(string text)
        {
            int padding = (Console.WindowWidth - text.Length) / 2;
            return new string(' ', Math.Max(padding, 0)) + text;
        }
    }
}
