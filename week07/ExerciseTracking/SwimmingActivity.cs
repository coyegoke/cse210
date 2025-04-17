public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int minutes, int laps, bool useMetric)
        : base(date, minutes, useMetric)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distanceKm = (_laps * 50) / 1000.0;
        return UseMetric() ? distanceKm : distanceKm * 0.62;
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