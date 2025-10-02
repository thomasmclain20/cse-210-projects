using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        var job1 = new Job("Software Developer", "Apple", new DateTime(2019, 3, 15), new DateTime(2022,6, 30), "Remote");
        job1.AddResponsibility("Developed web applications using C# and ASP.NET");
        job1.AddResponsibility("collaborated with cross-functional teams");

        var currentJob = new Job("Senior Developer", "Microsoft", new DateTime(2022, 7, 1), null, "SanFrancisco, CA");
        currentJob.AddResponsibility("Lead a team of 5 developers");
        currentJob.AddResponsibility("Architected microservices solutions");

        var myResume = new Resume("Bruce Wayne");
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(currentJob);

        Console.WriteLine($"Resume for: {myResume.Name}");
        foreach (var job in myResume.Jobs)
        {
            job.DisplayJobDetails();
        }


    }
}