using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();

        Running running1 = new Running("03 Nov 2022", 30, 3.5);
        activityList.Add(running1);
        Running running2 = new Running("07 Nov 2022", 30, 3.0);
        activityList.Add(running2);
        
        StationaryBicycle biking1 = new StationaryBicycle("10 Nov 2022", 45, 11);
        activityList.Add(biking1);
        StationaryBicycle biking2 = new StationaryBicycle("14 Nov 2022", 50, 10);
        activityList.Add(biking2);

        Swimming swimming1 = new Swimming("17 Nov 2022", 60, 60);
        activityList.Add(swimming1);
        Swimming swimming2 = new Swimming("20 Nov 2022", 30, 32);
        activityList.Add(swimming2);

        Console.Clear();

        foreach(Activity item in activityList)
        {
            item.GetSummary();
            Console.WriteLine();
        }
    }
}