using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; } // To diaplay the title of the video.
    public string Author { get; set; } // To display the name of the video creator(Author)
    public int LengthInSeconds { get; set; } // To display the video duration in seconds
    public List<Comment> Comments { get; set; } // To display the comments on each video

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Length: {LengthInSeconds} seconds, Comments: {GetNumberOfComments()}";
    }
}
