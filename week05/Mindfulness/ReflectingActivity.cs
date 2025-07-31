public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you showed great resilience."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new Random();

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready to reflect on a meaningful experience...");
        ShowCountDown(5);

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
        ShowSpinner(5);
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(0, _prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_random.Next(0, _questions.Count)];
    }
}
