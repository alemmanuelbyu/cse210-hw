using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        // Creativity To help people with different memorization strength
        Console.WriteLine("Choose difficulty level: Easy, Medium, or Hard");
        Console.Write("Enter difficulty: ");
        string difficulty = Console.ReadLine().ToLower();
        
        int wordsToHide = 3;
        
        if (difficulty == "easy")
            wordsToHide = 2;
        else if (difficulty == "medium")
            wordsToHide = 4;
        else if (difficulty == "hard")
            wordsToHide = 6;
        else
        {
            Console.WriteLine("Unknown difficulty. Defaulting to Medium.");
            wordsToHide = 4;
        }

        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life";
        Scripture scripture = new Scripture(reference, text);
        Console.WriteLine(scripture.GetDisplayText());

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords(wordsToHide);

        }
        // creativity
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are now hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}