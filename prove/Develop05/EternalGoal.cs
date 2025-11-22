using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {}

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete() => false; // never complete

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string SaveFormat()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}
