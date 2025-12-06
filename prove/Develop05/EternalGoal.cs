using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        // Eternal goals never complete, just give points each time
        return _points;
    }

    public override bool IsComplete()
    {
        // Eternal goal is never "done"
        return false;
    }

    public override string GetStatus()
    {
        // Always looks incomplete so you keep working on it
        return "[ ]";
    }

    public override string SaveFormat()
    {
        // EternalGoal|name|description|points
        return "EternalGoal|" + _name + "|" + _description + "|" + _points;
    }
}
