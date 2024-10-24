using System.Reflection;

public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private int _count;
    public List<Comment> Comments;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;   

        Comments = new List<Comment>();
    }

    public void AddComment(string name, string comment)
    {
        Comment comment1 = new(name, comment);
        Comments.Add(comment1);
    }

    public void CalculateComments()
    {
        
        foreach(var comment in Comments)
        {
         _count += 1;   
        }
    }
    public void DisplayVideo()
    {
        CalculateComments();
        Console.WriteLine("\nTitle: "+_title+"\nAuthor: "+_author+"\nLength: "+_length+" [Seconds] "+"\nComments: "+_count );
        foreach(var comment in Comments)
        {
            comment.DisplayComment();
        }
    }

}