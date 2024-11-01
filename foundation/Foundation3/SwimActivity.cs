public class SwimActivity : Activity
{
    private double _laps;
    private double _distance;
    public SwimActivity(double duration, double laps) : base(duration)
    {
        _laps = laps;
        _distance = _laps*50/1000*0.62;
    }

    public override string GetSummary()
    {
        return GetDate()+" Swimming ("+GetDuration()+" min)- Distance "+_distance.ToString("F2")+" miles, Speed "+(_distance/GetDuration()*60).ToString("F2")+ " mph, Pace: "+(GetDuration()/_distance).ToString("F2")+" min per mile";

    }
}