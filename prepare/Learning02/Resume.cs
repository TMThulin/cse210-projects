using System;

public class Resume
{
    public string _fullName = "";
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_fullName}");
        Console.WriteLine($"Job:");

        foreach(Job i in _jobs)
        {
            i.Display();
        }
    }
}