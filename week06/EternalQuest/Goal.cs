using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string Name() => _shortName;
    public string Description() => _description;
    public int Points() => _points;

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString(bool isComplete)
    {
        string box = isComplete ? "[X]" : "[ ]";
        return $"{box} {Name()} ({Description()})";
    }
    public abstract string GetStringRepresentation();
}