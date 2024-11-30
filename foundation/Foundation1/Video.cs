using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Display()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length of Video: {_length} seconds");
        Console.WriteLine($"Comments: ({GetNumberOfComments()})");
        
        foreach(Comment text in _comments)
        {
            text.Display();
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    private int GetNumberOfComments()
    {
        return _comments.Count;
    }
}
