using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter = "";
        string returnString = "";
        string goodJob = "Congadulations, keep up the good work!";
        string badJob = "Work hard and stay consistant, you can do this!";

        Console.Write("What is your grade? ");
        string gradeString = Console.ReadLine();

        int grade = int.Parse(gradeString);

        if (grade>90)
        {
            gradeLetter = "A";
        }
        else if (grade>80)
        {
            gradeLetter = "B";
        }
        else if (grade>70)
        {
            gradeLetter = "C";
        }
        else if (grade>60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        if (grade>70)
        {
            returnString = goodJob;
        }
        else
        {
            returnString = badJob;
        }

        Console.WriteLine($"Your grade is {gradeLetter}. {returnString}");
    }
}