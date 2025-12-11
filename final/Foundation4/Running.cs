public class Running : Activity
{
    private double _distance; // miles

    public Running(string date, int lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override string GetSummary()
    {
        return GetDate() + " Running (" + GetLengthMinutes() + " min) - " +
               "Distance: " + GetDistance().ToString("0.0") + " miles, " +
               "Speed: " + GetSpeed().ToString("0.0") + " mph, " +
               "Pace: " + GetPace().ToString("0.0") + " min per mile";
    }
}
