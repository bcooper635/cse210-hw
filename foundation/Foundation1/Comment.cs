public class Comment
{
    private string _name;
    private string _comment;

    public void DisplayComment()
    {
        Console.WriteLine(">"+_name+"\n-"+_comment);
    }
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }
    



}