public  class PromptGenerator
{
    // public List<string> _prompts = new List<string>("A","B","C");
    public List<string> _prompts = 
    [
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "Did I learn anything new today?",
    "What was the hardest thing I did today?",
    "Did I do an act of service today, and if so what was it?",
    "What's a goal I can make to be better tomorrow?",
    "What was different about today?"
    ];
         
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}

