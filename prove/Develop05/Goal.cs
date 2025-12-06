using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    // Mark an event as completed and return the points gained
    public abstract int RecordEvent();

    // Whether this goal is fully complete (for Simple + Checklist)
    public abstract bool IsComplete();

    // Used in the list display: "[X]" or "[ ]"
    public abstract string GetStatus();

    // Used by Program.SaveGoals()
    public abstract string SaveFormat();
}
