using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Basics Tutorial", "Tanner", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Game Dev Log #1", "DevGuy", 450);
        video2.AddComment(new Comment("Sam", "This is inspiring!"));
        video2.AddComment(new Comment("Kelly", "Can’t wait for the next video."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Funny Cat Compilation", "CatsOnline", 300);
        video3.AddComment(new Comment("Tom", "Hilarious!"));
        video3.AddComment(new Comment("Jane", "I laughed so hard."));
        video3.AddComment(new Comment("Lily", "I watched this 5 times already."));
        videos.Add(video3);

        // Display videos
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLengthInSeconds()} seconds");
