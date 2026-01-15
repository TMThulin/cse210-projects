using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();

        float response = -1;
        float largestNum = -2147483648;
        float average = 0;
        float total = 0;

        while (response != 0)
        {
            Console.WriteLine("Please enter a number. Enter 0 to finish.");
            response = float.Parse(Console.ReadLine());

            if (response != 0)
            {
                numbers.Add(response);
            }
        }

        total = numbers.Sum();
        average = total / numbers.Count;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > largestNum)
            {
                largestNum = numbers[i];
            }
        }        
        Console.WriteLine($"The list total is {total}. The list's average is {average}. The highest number in the list is {largestNum}");
    }
}