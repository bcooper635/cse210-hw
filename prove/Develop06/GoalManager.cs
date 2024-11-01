using System.Runtime;
using System.IO;
using System.Diagnostics.CodeAnalysis;

public class GoalManager
{
public List<Goal> _goals;
private int _score;

public GoalManager()
{
    _score = 0;
    _goals = new List<Goal>();
}
    
    public void Start()
    {
        while(true)
        {
        DisplayPlayerInfo();
        Console.WriteLine("Menu Options: ");
        Console.Write("   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals \n   5. Record Event\n   6. Quit\nSelect a choice from the menu: ");
        string userChoice = Console.ReadLine();
        if(userChoice == "1")
            {
                CreateGoal();
            }
        else if(userChoice == "2")
            {
                ListGoalDetails();
            }
        else if(userChoice == "3")
            {
                SaveGoals();
            }
        else if(userChoice == "4")
            {
                LoadGoals();
            }
        else if(userChoice == "5")
            {
                RecordEvent();
            }
        else if (userChoice == "6")
         {
            Console.WriteLine("You Chose To Quit . . . ");
            break;
        }
        else
         {
            Console.WriteLine("Invalid Entry. Quitting . . .");
            break;
        }
        }
    }

    public void DisplayPlayerInfo()
    {
        if (_score < 100)
        {
        Console.WriteLine($"\nScore: {_score}\nRank: Novice Adventurer\n");
        }
        else if (_score < 200)
        {
            Console.WriteLine($"\nScore: {_score}\nRank: Apprentice Scribe\n");
        }
        else if (_score < 300)
        {
            Console.WriteLine($"\nScore: {_score}\nRank: Journeyman Tracker\n");
        }
        else if (_score < 400)
        {
            Console.WriteLine($"\nScore: {_score}\nRank: Skilled Chronicler\n");
        }
        else if (_score < 500)
        {
            Console.WriteLine($"\nScore: {_score}\nRank: Veteran Pathfinder\n");
        }
        else if (_score < 600)
        {
            Console.WriteLine($"\nScore: {_score}\nRank: Expert Historian\n");
        }
        else if (_score < 700)
        {
            Console.WriteLine($"\nScore: {_score}\nRank: Master Archivist\n");
        }
        else if (_score < 800)
        {
            Console.WriteLine($"\nScore: {_score}\nRank: Epic Lorekeeper\n");
        }
        else if (_score < 900)
        {
            Console.WriteLine($"\nScore: {_score}\nRank: Legendary Quest Recorder\n");
        }
        else if (_score < 1000)
        {
            Console.WriteLine($"\nScore: {_score}\nRank: Mythic Grandmaster\n");
        }
        else
        {
            Console.WriteLine($"\nScore: {_score}\nRank: Eternal Legend\n");
        }
    }

    public void ListGoalNames()
    {
        int size = _goals.Count;
        for (int i = 0; i<size; i++)
        {
            Console.WriteLine("\n   "+(i+1)+". "+_goals[i].GetName());
        }

    }

    public void ListGoalDetails()
    {
        int size = _goals.Count;
        for (int i = 0; i<size; i++)
        {

            Console.Write("\n   "+(i+1)+": "+_goals[i].GetDetailsString());
        }
        Console.WriteLine("\n");
    }

    public void CreateGoal()
    {
        Console.Write("\n   The types of Goals are: \n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\nWhich type of goal would you like to create? ");
        string userChoice2 = Console.ReadLine();
        Console.Write("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("\nWhat is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("\nWhat is the amount of points associated with it? ");
        string pointsS = Console.ReadLine();
        int points = int.Parse(pointsS);
        if (userChoice2 == "1")
        {
            SimpleGoal goal1 = new(name,description,points);
            _goals.Add(goal1);
        }
        else if (userChoice2 == "2")
        {
            EternalGoal goal1 = new(name,description,points);
            _goals.Add(goal1);
        }
        else
        {
            Console.Write("\nHow many times does this goal need to be accomplished for a bonus? ");
            string targetS = Console.ReadLine();
            int target = int.Parse(targetS);
            Console.Write("\nWhat is the bonus for accomplishing it that many times? ");
            string bonusS = Console.ReadLine();
            int bonus = int.Parse(bonusS);
            ChecklistGoal goal1 = new(name,description,points,target,bonus);
            _goals.Add(goal1);

        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nWhich goal did you complete? ");
        string userChoiceS = Console.ReadLine();
        int userChoice = int.Parse(userChoiceS); 
        _goals[userChoice-1].RecordEvent();
        _score += _goals[userChoice-1].GetPoints();
        int eventsum= 0;
        eventsum = _goals[userChoice-1].GetPoints();
        if (_goals[userChoice-1].IsComplete())
        {
            _score += _goals[userChoice-1].GetBonus();
            eventsum += _goals[userChoice-1].GetBonus();
        }
        Console.WriteLine("\n"+eventsum+" points added to your score!");
        _goals[userChoice-1].ScoreCollected();
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter (fileName))
        {

        int size = _goals.Count;
        for (int i = 0; i<size; i++)
        {
            outputFile.WriteLine(_goals[i].SaveData());
            
        }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(">");
            if (parts[0] == "SimpleGoal")
            {
                int part3 = int.Parse(parts[3]);
                bool part4 = bool.Parse(parts[4]);
                SimpleGoal goal2 = new(parts[1],parts[2],part3);
                goal2.SetComplete(part4);
                _goals.Add(goal2);
                _score += goal2.GetPoints();
                if (goal2.IsComplete())
                {
                    _score += goal2.GetBonus();
                }
            }
            else if (parts[0] == "EternalGoal")
            {
                int part3 = int.Parse(parts[3]);
                EternalGoal goal2 = new(parts[1],parts[2],part3);
                _goals.Add(goal2);
                _score += goal2.GetPoints();
                if (goal2.IsComplete())
                {
                    _score += goal2.GetBonus();
                }
            }
            else 
            {
                int part3 = int.Parse(parts[3]);
                int part4 = int.Parse(parts[4]);
                int part5 = int.Parse(parts[5]);
                int part6 = int.Parse(parts[6]);
                ChecklistGoal goal2 = new(parts[1],parts[2],part3, part5, part4);
                goal2.SetAmount(part6);
                _goals.Add(goal2);
                _score += goal2.GetPoints();
                if (goal2.IsComplete())
                {
                    _score += goal2.GetBonus();
                }
            }
        }
    }


}

