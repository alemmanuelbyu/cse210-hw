public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
    }

    List<string> animationStrings = new List<string>();

    public void ShowSpinner(int seconds)
    {
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }


    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public abstract void Run();
}
