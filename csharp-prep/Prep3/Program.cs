using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.WriteLine("please guess an integer from 1 to 100.");

        while (response != number)
        {
            response= int.Parse(Console.ReadLine());

            if (response<number)
        {
            Console.WriteLine("higher");
        }
        else if (response>number)
        {
            Console.WriteLine("lower");
        }
        else
        {
            Console.WriteLine("correct");
        }
        }
    }
}