public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int minutes, double speed, bool useMetric)
        : base(date, minutes, useMetric)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
