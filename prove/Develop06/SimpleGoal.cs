using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points){}

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public void SetComplete(bool complete)
    {
        if (complete)
            {_isComplete = true;}
        else
            {_isComplete = false;}
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "Simple Goal: "+GetName()+","+GetDescription()+","+GetPoints()+","+_isComplete;
    }

       public override int GetBonus()
    {
        return 0;
    }

    public override string SaveData()
{
    return "SimpleGoal>"+GetName()+">"+GetDescription()+">"+GetPoints()+">"+IsComplete();
}

}