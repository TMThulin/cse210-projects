using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._yearStart = 2000;
        job1._yearEnd = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Programer";
        job2._company = "Macrohard";
        job2._yearStart = 2026;
        job2._yearEnd = 2052;

        Resume resume1 = new Resume();
        resume1._fullName = "Bob Cratchett";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}