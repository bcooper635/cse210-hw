using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Intel";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2021;
        job1._endYear = 2024;
        
        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Manufacturing Manager";
        job2._startYear = 2018;
        job2._endYear = 2021;
        
        Resume myResume = new Resume();
        myResume._name = "Blake Cooper";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2); 
        
        myResume.DisplayResume();

    }
}