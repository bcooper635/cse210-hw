public class BikeActivity : Activity
{
    private double _speed;

    public BikeActivity(double duration, double speed) : base(duration)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        return GetDate()+" Biking ("+GetDuration()+" min)- Distance "+(_speed/60*GetDuration())+" miles, Speed "+_speed+" mph, Pace: "+(60/_speed)+" min per mile";

    }
}