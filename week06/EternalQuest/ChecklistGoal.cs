using System;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (IsComplete()) return 0;

        _amountCompleted++;
        if (_amountCompleted >= _target)
            return Points() + _bonus;

        return Points();
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString(bool isComplete)
    {
        string box = IsComplete() ? "[X]" : "[ ]";
        return $"{box} {Name()} ({Description()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist|{Name()}|{Description()}|{Points()}|{_target}|{_bonus}|{_amountCompleted}";
    }
}