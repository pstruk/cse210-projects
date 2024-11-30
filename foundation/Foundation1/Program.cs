using System;
using System.Collections.Generic;

class Program
{
    static List<Video> _videos = new List<Video>();

    static void Main(string[] args)
    {
        BuildVideo();
        DisplayVideo();
    }

    static void BuildVideo()
    {
        Video video1 = new Video("The Greatest Gift", "Mat and Savanna Shaw", 250);
        Video video2 = new Video("Overcoming Life's Storms With Faith in Christ", "The Church of Jesus Christ of Latter-day Saints", 124);
        Video video3 = new Video("Christmas Tags-Week 1-Pocket Card Tags", "Janice Gilhooley", 1541);
        Video video4 = new Video("Give God Your Best-Ezra Taft Benson", "BYU Speeches", 190);

        video1.AddComment(new Comment("@just_some_internet_guy", "Your music is what this world needs, especially now."));
        video1.AddComment(new Comment("@melbeard7784", "I come on youtube every day just to listen to your beautiful family sing xxxxxx."));
        video1.AddComment(new Comment("@mostguitarswins", "Peace on Earth to Men of Good Will."));
        video1.AddComment(new Comment("@lilal3753", "My granddaughter will love this video. She loves Pennie!!"));

        video2.AddComment(new Comment("@Anonymous_Monkey", "What a wonderful message of hope and assurance from a humble servant of God. Thank you, Pres. Eyring!")); 
        video2.AddComment(new Comment("@JessiBarcarsy", "Wonderful messages."));
        video2.AddComment(new Comment("@nadsonribeiro9263", "I really feel peace and love in his voice and words!"));
        video2.AddComment(new Comment("@hpagalla", "We thank God for the living Prophets today, we hear our Saviour's voice through His Prophets."));

        video3.AddComment(new Comment("@rondaladuke6106", "Love them! They turned out so cute!"));
        video3.AddComment(new Comment("@Dscreativecorner", "Wow! They are stunning! Thank you for the tutorial!"));
        video3.AddComment(new Comment("@Katistamps", "Adorable tags!!"));

        video4.AddComment(new Comment("@nathanbanks2935", "Great Message! I hope to be able to always give God my best."));
        video4.AddComment(new Comment("@bradman1984", "Love this and needed to hear this."));
        video4.AddComment(new Comment("@aloverofstories", "So inspiring. Thank you for sharing this."));

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);
    }

    static void DisplayVideo()
    {
        foreach(Video item in _videos )
        {
            item.Display();
        }
        Console.WriteLine();
    }

}