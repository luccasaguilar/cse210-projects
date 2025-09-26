using System;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>();

        var v1 = new Video("Plates of Brass: A Record Preserved", "Nephi", 602);
        v1.AddComment(new Comment("Lehi", "Essential for our posterity."));
        v1.AddComment(new Comment("Sariah", "I am relieved and grateful."));
        v1.AddComment(new Comment("Sam", "Nephi’s faith strengthens us all."));
        v1.AddComment(new Comment("Zoram", "I never thought I’d join this journey, but I’m glad I did."));
        videos.Add(v1);

        var v2 = new Video("Waters of Mormon: Covenant and Community", "Alma the Elder", 485);
        v2.AddComment(new Comment("Mosiah", "A blessed day for the people."));
        v2.AddComment(new Comment("Abinadi", "The word has taken root."));
        v2.AddComment(new Comment("Helam", "Baptism brought peace to my soul."));
        videos.Add(v2);

        var v3 = new Video("Brother of Jared: The Finger of the Lord", "Mahonri Moriancumer", 730);
        v3.AddComment(new Comment("Ether", "A miracle recorded for future faith."));
        v3.AddComment(new Comment("Moroni", "This testimony strengthens my own."));
        v3.AddComment(new Comment("Jared", "My brother’s trust in the Lord was unwavering."));
        v3.AddComment(new Comment("Shule", "Remarkable light from small stones."));
        videos.Add(v3);

        var v4 = new Video("Title of Liberty: A Cause for Freedom", "Captain Moroni", 815);
        v4.AddComment(new Comment("Pahoran", "The people rallied with great strength."));
        v4.AddComment(new Comment("Helaman", "My young warriors fought with faith."));
        v4.AddComment(new Comment("Teancum", "We will defend our families and our God."));
        v4.AddComment(new Comment("Amalickiah", "They will never overcome us!"));
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