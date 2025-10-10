using System;
//I created a new menu item that allows you to list only the goal names.
//I created the option to create negative goals, which subtract points instead of adding them.
class Program
{
    static void Main(string[] args)
    {
        var gm = new GoalManager();
        gm.Start();
    }
}