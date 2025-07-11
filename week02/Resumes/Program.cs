using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Full-Stack Developer Intern";
        job1._company = "RODO";
        job1._startYear = 2022;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myresume = new Resume();
        myresume._name = "Emmanuel Olusola Irebami";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.Display();
    }
    
}