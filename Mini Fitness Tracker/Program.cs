using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Fitness_Tracker.Ui;
using Mini_Fitness_Tracker.Engine;
using Mini_Fitness_Tracker.Models;


namespace Mini_Fitness_Tracker
{
    internal class Program
    {
        static void Main()
        {           
            while (true)
            {
                
                FitnessAppEngine.Run();
            }

        }
    }
}
