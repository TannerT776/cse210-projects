using System;

public class BreathingActivity: Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    public override void StartActivity()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        // Use a simple 4-second inhale, 6-second exhale cycle (adjust if needed)
        int inhale = 4;
        int exhale = 6;

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(inhale);
            Console.WriteLine();

            // If time is up, break
            if (DateTime.Now >= endTime) break;

            Console.Write("Breathe out... ");
            ShowCountDown(exhale);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
