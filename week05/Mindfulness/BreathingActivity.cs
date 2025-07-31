public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowCountDown(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
        ShowSpinner(5);
    }
}
