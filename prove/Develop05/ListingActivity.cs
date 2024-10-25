public class ListingActivity : Activity
{
    private int _count = 0;

    private List<string> _prompts =     ["--- Who are people that you appreciate? ---",
                                        "--- What are personal strengths of yours? ---",
                                        "--- Who are people that you have helped this week? ---",
                                        "--- When have you felt the Holy Ghost this month? ---",
                                        "--- Who are some of your personal heroes? ---"];

    public ListingActivity(string name, string description) : base(name, description)
{}

  public void Run()
    {
        Console.Write("\nGet Ready . . . ");
        ShowSpinner(3);

        Console.WriteLine("\nList as many responses as you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Write("\n");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now <endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count += 1;
        }
        Console.WriteLine($"You listed {_count} times!");


    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

}