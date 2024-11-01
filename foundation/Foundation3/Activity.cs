using System.Runtime.CompilerServices;

public abstract class Activity
{
    private string _date;
    private double _duration;

    public Activity(double duration)
    {
        _duration = duration;
    }

    public double GetDuration()
    {
        return _duration;
    }
    public string GetDate()
    {   
        _date = DateTime.Now.ToString("dd MMM yyyy");
        return _date;
        
    }
    public abstract string GetSummary();
}   