using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities;
        activities = new List<Activity>();
        RunningActivity act1 = new(30, 2);
        activities.Add(act1);
        BikeActivity act2 = new(45,15); 
        activities.Add(act2);
        SwimActivity act3 = new(30,30);
        activities.Add(act3);

        for (int i = 0; i<3; i++)
        {
            Console.WriteLine(activities[i].GetSummary());
        }

    }
}