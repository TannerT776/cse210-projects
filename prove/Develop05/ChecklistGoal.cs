using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonusPoints;
    private int _currentCount;

    // Constructor for NEW checklist goals
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    // Constructor for LOADED checklist goals (includes currentCount)
    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetCount,
        int bonusPoints,
        int currentCount)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        _currentCount += 1;
        int totalPoints = _points;

        if (_currentCount >= _targetCount)
        {
            // Add bonus when you hit the target
            totalPoints += _bonusPoints;
        }

        return totalPoints;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStatus()
    {
        if (IsComplete())
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

    public string ProgressString()
    {
        // Used in Program.ListGoals() like "3/5"
        return _currentCount.ToString() + "/" + _targetCount.ToString();
    }

    public override string SaveFormat()
    {
        // ChecklistGoal|name|description|points|target|bonus|current
        return "ChecklistGoal|" + _name + "|" + _description + "|" + _points + "|" +
               _targetCount + "|" + _bonusPoints + "|" + _currentCount;
    }
}
