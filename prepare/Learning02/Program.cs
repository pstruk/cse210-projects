using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //Step 4-Job Test: Console.WriteLine($"{job1._company}");
        //Step 5-call Display Method: job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Apple";
        job2._startYear = 2016;
        job2._endYear = 2019;

        //Step 4-Job Test: Console.WriteLine($"{job2._company}");
        //Step 5-call Display Method: job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._name = "Timothy Smith";
        
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        //Step 7-Resume Test: Console.WriteLine($"{resume._jobs[0]._jobTitle}");
        resume.DisplayResume();
    }
}