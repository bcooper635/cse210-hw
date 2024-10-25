public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n\nHow long, in seconds, would you like for your session?");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }

    public void DisplayEndingMessage()
    {
        Console.Write("\n\nWell done!! ");
        ShowSpinner(2);
        Console.Write($"\n\nYou have completed another {_duration} seconds of the {_name}. ");
        ShowSpinner(2);
        Console.WriteLine("\n");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while(DateTime.Now <endTime)
        {
        Console.Write("|");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(200);
        Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now <endTime)
        {
        for (int i = seconds; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        }
    }
}