using System;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>();

        var v1 = new Video("Unboxing Pro Camera", "Alex Smith", 540);
        v1.AddComment(new Comment("Rita", "Great overview!"));
        v1.AddComment(new Comment("Jon", "Image quality looks amazing."));
        v1.AddComment(new Comment("Ken", "Please test low light next."));
        videos.Add(v1);

        var v2 = new Video("City Vlog with Action Cam", "Maya Lee", 410);
        v2.AddComment(new Comment("Luis", "Nice stabilization."));
        v2.AddComment(new Comment("Sara", "Love the transitions."));
        v2.AddComment(new Comment("Omar", "Which mic are you using?"));
        v2.AddComment(new Comment("Ivy", "Music fits the vibe."));
        videos.Add(v2);

        var v3 = new Video("Mountain Biking POV", "TrailWorks", 685);
        v3.AddComment(new Comment("Paul", "That descent was wild."));
        v3.AddComment(new Comment("Nina", "What lens is that?"));
        v3.AddComment(new Comment("Zed", "I want this bike now."));
        videos.Add(v3);

        var v4 = new Video("Studio Lighting Basics", "CamLab", 900);
        v4.AddComment(new Comment("Kim", "Clear explanations."));
        v4.AddComment(new Comment("Theo", "Saved me hours."));
        v4.AddComment(new Comment("Bea", "Can you cover softboxes next?"));
        videos.Add(v4);

        foreach (var video in videos)
        {
            Console.WriteLine($"{video.DisplayText()}s");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            foreach (var c in video.GetComments())
            {
                Console.WriteLine($"- {c.DisplayText()}");
            }
            Console.WriteLine();
        }
    }
}