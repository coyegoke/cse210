using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();
        int seconds = GetDuration();
        int interval = 4;

        while (seconds > 0)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(interval);
            seconds -= interval;

            if (seconds <= 0) break;

            Console.Write("Breathe out... ");
            ShowCountdown(interval);
            seconds -= interval;
        }

        DisplayEndingMessage();
    }
}
