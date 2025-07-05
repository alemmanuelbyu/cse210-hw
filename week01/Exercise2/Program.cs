using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percent: ");
        string grade = Console.ReadLine();

        int percent = int.Parse(grade);
        string letter = "";

        if ( percent >= 90)
        {
            letter ="A";
        }
        else if ( percent >= 80)
        {
            letter ="B";
        }
        else if ( percent >= 70)
        {
            letter ="c";
        }
        else if ( percent >= 60)
        {
            letter ="D";
        }
        else
        {
            letter ="F";
        }
        Console.WriteLine($"Your grade is {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed");
        }
        else
        {
            Console.WriteLine("You can do better next time");
        }
    }
}