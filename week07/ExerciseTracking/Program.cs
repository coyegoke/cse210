using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity("13 April, 2025", 30, 3.0, false),  // miles
            new CyclingActivity("15 April, 2025", 45, 20.0, true),   // kph
            new SwimmingActivity("17 April, 2025", 60, 40, false)     // miles
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}