public abstract class Activity
{
    private string _date;
    private int _minutes;
    private bool _useMetric;

    public Activity(string date, int minutes, bool useMetric)
    {
        _date = date;
        _minutes = minutes;
        _useMetric = useMetric;
    }

    public string GetDate() => _date;
    public int GetMinutes() => _minutes;
    public bool UseMetric() => _useMetric;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string unit = _useMetric ? "km" : "miles";
        string speedUnit = _useMetric ? "kph" : "mph";
        string paceUnit = _useMetric ? "min per km" : "min per mile";

        return string.Format("{0} {1} ({2} min) - Distance: {3:0.0} {4}, Speed: {5:0.0} {6}, Pace: {7:0.0} {8}",
            _date, this.GetType().Name.Replace("Activity", ""), _minutes,
            GetDistance(), unit, GetSpeed(), speedUnit, GetPace(), paceUnit);
    }
}