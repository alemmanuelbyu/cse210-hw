public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    // Creativity 
    public List<string> _quotes = new List<string>()
    {
        "\"Believe you can and you're halfway there.\" - Theodore Roosevelt",
        "\"The future belongs to those who believe in the beauty of their dreams.\" - Eleanor Roosevelt",
        "\"Success is not final, failure is not fatal: It is the courage to continue that counts.\" - Winston Churchill"
    };
    
    public string GetRandomQuote()
    {
        return _quotes[_random.Next(_quotes.Count)];
    }

}
