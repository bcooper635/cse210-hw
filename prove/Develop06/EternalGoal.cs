public class EternalGoal: Goal
{

    private bool _isComplete;
    public EternalGoal(string name, string description, int points) : base(name, description, points){}

        public override void RecordEvent()
    {
        _isComplete = true;   
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "Eternal Goal: "+GetName()+","+GetDescription()+","+GetPoints();

    }
    public override int GetBonus()
    {
        return 0;
    }

        public override string SaveData()
{
    return "EternalGoal>"+GetName()+">"+GetDescription()+">"+GetPoints();
}

    public override void ScoreCollected()
    {
        _isComplete = false;
    }
}