using System;
public class NegativeGoal : SimpleGoal
{
    public NegativeGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points, isComplete)
    {
    }

}