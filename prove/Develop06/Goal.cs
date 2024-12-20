using System.Reflection;

public abstract class Goal
{
 private string _shortName;
 private string _description;
 private int _points;

 public Goal(string name, string description, int points)
 {
    _shortName = name;
    _description = description;
    _points = points;
 }

public abstract int GetBonus();
public abstract void RecordEvent();

public abstract bool IsComplete();


public virtual string GetDetailsString()
{
    if (IsComplete() == true)
        return "[X] "+_shortName+" ("+_description+")";
    else
        return "[ ] "+_shortName+" ("+_description+")";
}


public abstract string GetStringRepresentation();


public abstract string SaveData();

public string GetName()
{
    return _shortName;
}

public string GetDescription()
{
    return _description;
}

public int GetPoints()
{
    return _points;
}

public virtual void ScoreCollected(){}


}