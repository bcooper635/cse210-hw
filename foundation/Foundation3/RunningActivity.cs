using System.Diagnostics;

public class RunningActivity: Activity
{
    private double _distance;

    public RunningActivity(double duration, double distance) : base(duration)
    {
        _distance = distance;
    }
    public override string GetSummary()
    {
        return GetDate()+" Running ("+GetDuration()+" min)- Distance "+_distance+" miles, Speed "+(_distance/GetDuration()*60)+" mph, Pace: "+(GetDuration()/_distance)+" min per mile";
    }
}