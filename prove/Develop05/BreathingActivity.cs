    public class BreathingActivity : Activity
{


public BreathingActivity(string name, string description) : base(name, description)
{}
    public void Run()
    {
        Console.Write("\nGet Ready . . . ");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now <endTime)
        {
            Console.Write("\n\nBreath In . . . ");
            ShowCountDown(4);
            Console.Write("\nBreath Out . . . ");
            ShowCountDown(6);

        }

    }
}