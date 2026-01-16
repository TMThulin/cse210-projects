using System;

class Program
{
    static void DisplayWlcome()
    {
        Console.WriteLine("Welcome to the Program.");
    }

    static void PromptUserName(out string userName)
    {
        Console.Write("Please enter a user name. ");
        userName = Console.ReadLine();
    }

    static void PromptUserNumber(out int userNum)
    {
        Console.Write("Please enter a number to be squared. ");
        userNum = int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birth year. ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static void SquareNumber(ref int userNum, out int squareNum)
    {
        squareNum = (int)Math.Pow(userNum, 2);
    }

    static void DisplayResult(ref string userName, ref int squareNum, ref int birthYear)
    {
        Console.WriteLine($"{userName}, your number squared is {squareNum}, and you will turn {2026-birthYear} this year if you haven't already.");
    }

    static void Main(string[] args)
    {
        string userName;
        int userNum;
        int birthYear;
        int squareNum;

        DisplayWlcome();
        PromptUserName(out userName);
        PromptUserNumber(out userNum);
        PromptUserBirthYear(out birthYear);
        SquareNumber(ref userNum, out squareNum);
        DisplayResult(ref userName, ref squareNum, ref birthYear);
    }
}