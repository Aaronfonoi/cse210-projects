using System;
using System.Transactions;


public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;

    }

    public void ListComment(Comment comment)
    {
        _comments.Add(comment);

    }
    public int NumberComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Video title: {_title} Author: {_author}  Video length: {_length} seconds");
        Console.WriteLine();
        int commentQty = NumberComments();
        Console.WriteLine($"The number of comments is: {commentQty}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }
    }

}