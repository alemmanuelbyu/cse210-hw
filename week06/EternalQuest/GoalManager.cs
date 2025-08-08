public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoals();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            // Creativity
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create: ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your Goal: ");
        string name = Console.ReadLine();
        Console.Write("Write a short description of it: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this Goal: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            SimpleGoal sg = new SimpleGoal(name, description, points);
            _goals.Add(sg);
        }
        else if (type == "2")
        {
            EternalGoal eg = new EternalGoal(name, description, points);
            _goals.Add(eg);
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal needs to be accomplished for a bonus: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many time: ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(cg);
        }
        // creativity
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("Your Goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earnedPoints = _goals[index].RecordEvent();
            _score += earnedPoints;
            Console.WriteLine($"You earned {earnedPoints} points!");
        }
        // creativity
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file: ");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }
        // creativity
        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        // creativity
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, desc, points);
                if (complete)
                {
                    goal.RecordEvent(); 
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal = new EternalGoal(name, desc, points);
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, desc, points, target, bonus);
                _goals.Add(goal);
            }
        }
        // creativity
        Console.WriteLine("Goals loaded.");
    }
}
