using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        // Creativity Initialize log
            Log log = new Log();
            log.LoadLog();

        while (true)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("------------------");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Log");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                log.AddActivity("Breathing");
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                log.AddActivity("Reflection");
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                log.AddActivity("Listing");
            }
            else if (choice == "4")
            {
                log.ViewLog();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }

            else if (choice == "5")
            {
                log.SaveLog();
                Console.WriteLine("Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please Select a choice from the menu.");
            }

            Console.WriteLine();
        }
    }
}