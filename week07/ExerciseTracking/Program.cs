using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running running = new Running("12 Nov 2025", 30, 4.8);
        Cycling cycling = new Cycling("13 Nov 2025", 30, 15);
        Swimming swimming = new Swimming("14 Nov 2025", 30, 40);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}