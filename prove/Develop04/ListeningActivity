using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ListingActivity : Activity
{
    private readonly List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private static readonly Random _random = new Random();

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many as you can in a certain area.")
    {
    }

    // Helper to read a line with timeout (returns null if timed out)
    private string ReadLineWithTimeout(int millisecondsTimeout)
    {
        var task = Task.Run(() => Console.ReadLine());
        bool completed = task.Wait(millisecondsTimeout);
        if (completed)
        {
            return task.Result;
        }
        else
        {
            return null;
        }
    }

    public override void StartActivity()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("You will have a short moment to think, then begin listing items. Press Enter after each item.");
        ShowCountDown(3);
        Console.WriteLine();

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int remainingMilliseconds;
        while (DateTime.Now < endTime)
        {
            remainingMilliseconds = (int)(endTime - DateTime.Now).TotalMilliseconds;
            if (remainingMilliseconds <= 0) break;

            // Readline with timeout to avoid blocking past the activity duration
            string line = ReadLineWithTimeout(remainingMilliseconds);
            if (line == null)
            {
                // timed out
                break;
            }
            line = line.Trim();
            if (!string.IsNullOrEmpty(line))
            {
                items.Add(line);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} item(s).");
        DisplayEndingMessage();
    }
}
