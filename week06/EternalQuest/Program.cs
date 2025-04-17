using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        manager.CreateGoal(new SimpleGoal("Run a Marathon", "Complete a full marathon", 1000));
        manager.CreateGoal(new EternalGoal("Read Scriptures", "Daily scripture reading", 100));
        manager.CreateGoal(new ChecklistGoal("Temple Visits", "Attend temple 15 times", 50, 10, 500));

        manager.DisplayScore();
        manager.DisplayGoals();

        manager.RecordEvent(1);
        manager.RecordEvent(2);
        manager.RecordEvent(2);
        manager.RecordEvent(2);
        manager.RecordEvent(0);

        manager.DisplayGoals();
        manager.DisplayScore();

        manager.SaveGoals("goals.txt");

        manager.LoadGoals("goals.txt");
        manager.DisplayGoals();
    }
}


// This program goes beyond the base functional requirements by adding the following advanced features:

// 1. LEVELING SYSTEM
// Users "level up" as they accumulate points from completing goals. 
// This motivates consistent effort.

// 2. ACHIEVEMENTS AND BADGES
// As users reach specific point milestones, they unlock achievement badges.
// These badges are displayed in the program to visually recognize the user's efforts and create a fun reward system.

// 3. GOAL PERSISTENCE (SAVE/LOAD TO A FILE)
// The program allows all goals and progress to be saved to and loaded from a file.
// This ensures that the user's data is persistent between sessions.

