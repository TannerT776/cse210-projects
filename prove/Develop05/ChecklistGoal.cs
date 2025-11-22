using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _progress;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int progress = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _progress = progress;
    }

    public override int RecordEvent()
    {
        _progress++;

        if (_progress == _target)
        {
            return GetPoints() + _bonus;
        }

        return GetPoints();
    }

    public override bool IsComplete() => _progress >= _target;

    public override string GetStatus()
    {
        return IsComplete() ? "[X]" : "[ ]";
    }

    public string ProgressString() => $"{_progress}/{_target}";

    public override string SaveFormat()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_progress}";
    }
}
