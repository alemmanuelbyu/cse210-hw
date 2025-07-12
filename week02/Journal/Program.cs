using System;
using System.Collections.Generic;
using System.IO;

// Added Random Motivational quotes to inspire the Journal User

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Motivational Quotes");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                journal.AddEntry(new Entry(DateTime.Now.ToShortDateString(), prompt, response));
            }
            else if (option == "2")
            {
                journal.DisplayAll();
            }
            else if (option == "3")
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (option == "4")
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            // Creativity
            else if (option == "5")
            {
                Console.WriteLine(promptGenerator.GetRandomQuote());

            }
            else if (option == "6")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose again.");
            }
        }
    }
}
