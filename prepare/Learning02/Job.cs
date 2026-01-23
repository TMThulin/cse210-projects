using System;

public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public int _yearStart;
    public int _yearEnd;


    public void Display()
    {
        Console.WriteLine($"{_company}, {_jobTitle}, {_yearStart}-{_yearEnd}");
    }
}