using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private List<Achievement> _achievements = new List<Achievement>();
    private int _score;
    private int _level;

    public GoalManager()
    {
        _score = 0;
        _level = 1;
        LoadDefaultAchievements();
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();
            if (pointsEarned > 0)
            {
                _score += pointsEarned;
                Console.WriteLine($"+{pointsEarned} points! Total: {_score}");
                CheckLevelUp();
                CheckAchievements();
            }
            else
            {
                Console.WriteLine("Yippy! Goal already completed.");
            }
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void DisplayScore() => Console.WriteLine($"Current Score: {_score} | Level: {_level}");

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_level);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        if (File.Exists(filename))
        {
            var lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _level = int.Parse(lines[1]);
            for (int i = 2; i < lines.Length; i++)
            {
                var parts = lines[i].Split('|');
                switch (parts[0])
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                        break;
                }
            }
        }
    }

    private void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"🎉 Congratulations! You've leveled up to Level {_level}!");
        }
    }

    private void LoadDefaultAchievements()
    {
        _achievements.Add(new Achievement("Goal Getter", "Earn 500 points", 500));
        _achievements.Add(new Achievement("Checklist Champ", "Earn 1000 points", 1000));
        _achievements.Add(new Achievement("Quest Master", "Earn 1500 points", 1500));
    }

    private void CheckAchievements()
    {
        foreach (var achievement in _achievements)
        {
            if (achievement.IsUnlocked(_score))
            {
                Console.WriteLine($"🎖️ New Achievement Unlocked: {achievement}");
            }
        }
    }
}