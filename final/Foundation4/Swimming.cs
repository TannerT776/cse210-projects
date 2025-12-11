public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // 50 meters per lap → meters → km → miles
        double meters = _laps * 50;
        double kilometers = meters / 1000.0;
        double miles = kilometers * 0.621371;
        return miles;
    }

    public override string GetSummary()
    {
        return GetDate() + " Swimming (" + GetLengthMinutes() + " min) - " +
               "Laps: " + _laps +
               ", Distance: " + GetDistance().ToString("0.0") + " miles, " +
               "Speed: " + GetSpeed().ToString("0.0") + " mph, " +
               "Pace: " + GetPace().ToString("0.0") + " min per mile";
    }
}
