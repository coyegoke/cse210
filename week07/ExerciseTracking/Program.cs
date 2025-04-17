using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity("03 Nov 2022", 30, 3.0, false),  // miles
            new CyclingActivity("04 Nov 2022", 45, 20.0, true),   // kph
            new SwimmingActivity("05 Nov 2022", 60, 40, false)     // miles
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}