public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the guidiance of the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready to list as many items as you can...");
        ShowCountDown(5);

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        List<string> items = GetListFromUser();

        Console.WriteLine($"You listed {items.Count} items.");

        DisplayEndingMessage();
        ShowSpinner(5);
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(0, _prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }

        return items;
    }
}
