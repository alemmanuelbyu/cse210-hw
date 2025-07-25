using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("Video 1", "Author Emmanuel", 300);
        Video video2 = new Video("Video 2", "Author Olusola", 240);
        Video video3 = new Video("Video 3", "Author Irebami", 180);

        video1.AddComment(new Comment("John", "Great video!"));
        video1.AddComment(new Comment("Jane", "Nice one, I loved it!"));
        video1.AddComment(new Comment("Bob", "Amazing, Well done!"));

        video2.AddComment(new Comment("Alice", "Nice job!"));
        video2.AddComment(new Comment("Mike", "Good content, keep it up!"));
        video2.AddComment(new Comment("Emma", "This is good, Thumbs up!"));

        video3.AddComment(new Comment("David", "Excellent!"));
        video3.AddComment(new Comment("Sophia", "Informative!"));
        video3.AddComment(new Comment("Olivia", " Well explained!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.ToString());
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine(comment.ToString());
            }
            Console.WriteLine();
        }

    }
}