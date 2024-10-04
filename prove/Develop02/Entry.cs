public class Entry
{
public DateTime _date;
public string _prompt;

public string _userEntry;

public void Display()
{
    Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nEntry: {_userEntry}");
}


}