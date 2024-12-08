using System;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company="Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        Job job2 = new Job();
        job2._company="SGB Innovations";
        job2._jobTitle="Owner";
        job2._startYear=2022;
        job2._endYear=0;        
        Resume resume = new Resume();
        resume._fullName="Shay Brown";
        resume._jobList.Add(job1);
        resume._jobList.Add(job2);
        resume.DisplayResume();
    }
}
