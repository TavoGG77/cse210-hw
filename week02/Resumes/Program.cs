using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Telus";
        job1._jobTitle = "Supervisor";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Programmer";
        job2._startYear = 2019;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Gustavo Guerra";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        

    }
}