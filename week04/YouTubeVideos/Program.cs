using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Method to create videos and add comments
        Video video1 = new Video("C# Programming Tutorial", "Oyegoke Cornelius", 900);
        video1.Comments.Add(new Comment("Oluwatobiloba", "Great tutorial!"));
        video1.Comments.Add(new Comment("Samuel", "The tutorial video is very helpful, thanks!"));
        video1.Comments.Add(new Comment("Maestro007", "I'm seems not to understand the concept of Loop, could you explain loops in more detail? Thank you"));

        Video video2 = new Video("Introduction To Python Programming", "Oyegoke Cornelius", 1080);
        video2.Comments.Add(new Comment("Ewaoluwa", "I'm new to programming, this really help."));
        video2.Comments.Add(new Comment("Wuraola_2025", "Awesome tutorial! Thanks"));
        video2.Comments.Add(new Comment("Enitan_kitchen", "Can you record an elaborate video on this?"));
        video2.Comments.Add(new Comment("Oluwapelumi", "You are doing well, brother"));

        Video video3 = new Video("Your First Website", "Oyegoke Cornelius", 1200);
        video3.Comments.Add(new Comment("Joshua", "Thanks for the practical/hands-on approach. It really helped."));
        video3.Comments.Add(new Comment("Mordecai", "I'm new here!!"));
        video3.Comments.Add(new Comment("olatundegloria", "Kindly do the full tutorial using HTML, CSS, and JavaScript?"));

        Video video4 = new Video("Structuring contents with HTML", "Oyegoke Cornelius", 650);
        video4.Comments.Add(new Comment("Oluwanifemi", "Thank you!!"));
        video4.Comments.Add(new Comment("Mia", "This really helped. Thanks"));
        video4.Comments.Add(new Comment("Olorundare@gmail.com", "This is so apt!"));
        video4.Comments.Add(new Comment("AnnyPaul", "Very informative video!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Method to iterate through the videos and display information (foreach)
        foreach (Video video in videos)
        {
            Console.WriteLine(video);
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  - {comment}");
            }
            Console.WriteLine();
        }
    }
}