using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor for NEW goals (not yet complete)
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Constructor for LOADED goals (includes completed flag)
    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }

        // If already complete, you could return 0 or still points.
        // Most students return 0 so you don't double-score.
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStatus()
    {
        if (_isComplete)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

    public override string SaveFormat()
    {
        // Format expected by Program.LoadGoals()
        // SimpleGoal|name|description|points|isComplete
        return "SimpleGoal|" + _name + "|" + _description + "|" + _points + "|" + _isComplete;
    }
}
