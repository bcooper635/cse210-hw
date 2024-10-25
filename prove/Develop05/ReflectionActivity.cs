public class ReflectionActivity : Activity
{
    private List<string> _prompts =     ["Think of a time when you stood up for someone else.",
                                        "Think of a time when you did something really difficult.",
                                        "Think of a time when you helped someone in need.",
                                        "Think of a time when you did something truly selfless."];
    private List<string> _questions =   [">Why was this experience meaningful to you?",
                                        ">Have you ever done anything like this before?",
                                        ">How did you get started?",
                                        ">How did you feel when it was complete?",
                                        ">What made this time different than other times when you were not as successful?",
                                        ">What is your favorite thing about this experience?",
                                        ">What could you learn from this experience that applies to other situations?",
                                        ">What did you learn about yourself through this experience?",
                                        ">How can you keep this experience in mind in the future?"]; 
    
    private List<int> _usedValues = new List<int>();
    private Random _random = new Random();

public ReflectionActivity(string name, string description) : base(name, description)
{}

 public void Run()
    {
        Console.Write("\nGet Ready . . . ");
        ShowSpinner(3);

        Console.WriteLine("\nConsider the following prompt: ");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they related to this experience. You may begin in: ");
        ShowCountDown(8);
        Console.Write("\n");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now <endTime)
        {
            DisplayQuestion();
            ShowSpinner(8);
        }
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\n--- "+GetRandomPrompt()+" ---\n");
    }

    public void DisplayQuestion()
    {
        Console.Write("\n"+GetRandomQuestion()+" ");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        //this part of my code is more complicated
        //checks to see if every index in the random question has been used. if so, then the used value list is reset
        if (_usedValues.Count == _questions.Count)
        {
            _usedValues.Clear();
        }

        int index;

        //keeps getting a new random index until it finds one that hasn't been used
        do
        {
            index = _random.Next(_questions.Count);
        } while (_usedValues.Contains(index));

        //add the index i just got to the useValues list
        _usedValues.Add(index);

        //returns the random question
        return _questions[index];
    }

}