public class Cycling : Activity
{
    private double _speed; // mph

    public Cycling(string date, int lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double hours = GetLengthMinutes() / 60.0;
        return _speed * hours;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return GetDate() + " Cycling (" + GetLengthMinutes() + " min) - " +
               "Distance: " + GetDistance().ToString("0.0") + " miles, " +
               "Speed: " + GetSpeed().ToString("0.0") + " mph, " +
               "Pace: " + GetPace().ToString("0.0") + " min per mile";
    }
}
