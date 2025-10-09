using System;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. List Goals - only names");
            Console.WriteLine(" 4. Save Goals");
            Console.WriteLine(" 5. Load Goals");
            Console.WriteLine(" 6. Record Event");            
            Console.WriteLine(" 7. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine()?.Trim();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoalDetails();
            else if (choice == "3") ListGoalNames();
            else if (choice == "4") SaveGoals();
            else if (choice == "5") LoadGoals();
            else if (choice == "6") RecordEvent();
            else if (choice == "7") break;
            else { Console.WriteLine("Invalid option."); Pause(); }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0) { Console.WriteLine("No goals."); Pause(); return; }
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].Name()}");
        Pause();
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0) { Console.WriteLine("No goals."); Pause(); return; }
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString(_goals[i].IsComplete())}");
        Pause();
    }

    public void CreateGoal()
    {
        Console.WriteLine("Goal type: 1) Simple  2) Eternal  3) Checklist");
        Console.Write("Which type of goal would you like to create? ");
        string t = Console.ReadLine()?.Trim();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = ReadInt(10);

        if (t == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (t == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (t == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = ReadInt(5);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = ReadInt(100);
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid type.");
        }

        Pause();
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0) { Console.WriteLine("No goals."); Pause(); return; }
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString(_goals[i].IsComplete())}");
        Console.Write("\nWhich goal did you accomplish? ");
        int idx = ReadInt(1) - 1;
        if (idx < 0 || idx >= _goals.Count)
        {
            Console.WriteLine("Invalid index.");
            Pause();
            return;
        }

        int gained = _goals[idx].RecordEvent();
        _score += gained;
        Console.WriteLine($"Congratulations! You have earned {gained} points!");
        Console.WriteLine($"You now have {_score} points.");
        Pause();
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fn = Console.ReadLine();
        using var sw = new StreamWriter(fn);
        sw.WriteLine(_score);
        foreach (var g in _goals)
            sw.WriteLine(g.GetStringRepresentation());
        Console.WriteLine("Saved.");
        Pause();
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fn = Console.ReadLine();
        if (!File.Exists(fn)) { Console.WriteLine("File not found."); Pause(); return; }

        var lines = File.ReadAllLines(fn);
        _goals.Clear();
        _score = 0;

        if (lines.Length > 0) int.TryParse(lines[0], out _score);

        for (int i = 1; i < lines.Length; i++)
        {
            var p = lines[i].Split('|');
            if (p.Length < 4) continue;

            string type = p[0];
            string name = p[1];
            string desc = p[2];
            int points = int.Parse(p[3]);

            if (type == "Simple")
            {
                bool done = p.Length > 4 && bool.Parse(p[4]);
                _goals.Add(new SimpleGoal(name, desc, points, done));
            }
            else if (type == "Eternal")
            {
                _goals.Add(new EternalGoal(name, desc, points));
            }
            else if (type == "Checklist")
            {
                int target = int.Parse(p[4]);
                int bonus = int.Parse(p[5]);
                int amt = p.Length > 6 ? int.Parse(p[6]) : 0;
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus, amt));
            }
        }

        Console.WriteLine("Loaded.");
        Pause();
    }

    private int ReadInt(int fallback)
    {
        return int.TryParse(Console.ReadLine(), out int v) ? v : fallback;
    }

    private void Pause()
    {
        Console.WriteLine();
        Console.Write("Press Enter to continue...");
        Console.ReadLine();
    }
}