// Creativity
public class Log
{
    private List<string> activities = new List<string>();

    public void AddActivity(string activity)
    {
        activities.Add(activity);
    }

    public void ViewLog()
    {
        Console.WriteLine("Activity Log:");
        foreach (string activity in activities)
        {
            Console.WriteLine(activity);
        }
    }
    public void SaveLog()
    {
        using (StreamWriter writer = new StreamWriter("log.txt"))
        {
            foreach (string activity in activities)
            {
                writer.WriteLine(activity);
            }
        }
        Console.WriteLine("Log saved to log.txt");
    }

    public void LoadLog()
    {
        if (File.Exists("log.txt"))
        {
            activities = File.ReadAllLines("log.txt").ToList();
        }
    }
}
