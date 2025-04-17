public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int minutes, double distance, bool useMetric)
        : base(date, minutes, useMetric)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return UseMetric() ? _distance * 1.60934 : _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}