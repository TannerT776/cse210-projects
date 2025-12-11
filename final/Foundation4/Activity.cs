using System;

public abstract class Activity
{
    protected string _date;
    protected int _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    // Distance in miles (for all derived classes)
    public abstract double GetDistance();

    // Speed in miles per hour
    public virtual double GetSpeed()
    {
        double hours = _lengthMinutes / 60.0;
        if (hours == 0)
        {
            return 0;
        }

        return GetDistance() / hours;
    }

    // Pace in minutes per mile
    public virtual double GetPace()
    {
        double distance = GetDistance();
        if (distance == 0)
        {
            return 0;
        }

        return _lengthMinutes / distance;
    }

    public virtual string GetSummary()
    {
        return _date + " Activity (" + _lengthMinutes + " min) - " +
               "Distance: " + GetDistance().ToString("0.0") + " miles, " +
               "Speed: " + GetSpeed().ToString("0.0") + " mph, " +
               "Pace: " + GetPace().ToString("0.0") + " min per mile";
    }
}
