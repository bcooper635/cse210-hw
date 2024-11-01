public class ChecklistGoal : Goal
{
    int _amountCompleted = 0;
    int _target;
    int _bonus;

    private bool _isComplete;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

        public override void RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {
            _isComplete = true;
        }
    }
    public void SetAmount(int amount)
    {
        _amountCompleted = amount;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "Checklist Goal: "+GetName()+","+GetDescription()+","+GetPoints()+","+_bonus+","+_target+","+_amountCompleted;

    }

    public override string GetDetailsString()
    {
    if (IsComplete() == true)
        return "[X] "+GetName()+" ("+GetDescription()+") -- Currently Completed: "+_amountCompleted+"/"+_target;
    else
        return "[ ] "+GetName()+" ("+GetDescription()+") -- Currently Completed: "+_amountCompleted+"/"+_target;
    }
    
    public override int GetBonus()
    {
        if (_amountCompleted > _target)
        {
            return 0;
        }
        else
        {
            return _bonus;
        }
    }

    public override string SaveData()
    {
        return "ChecklistGoal>"+GetName()+">"+GetDescription()+">"+GetPoints()+">"+_bonus+">"+_target+">"+_amountCompleted;
    }
}