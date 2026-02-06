using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> menue = new List<string>{"end", "load", "entry", "display", "save"};
        float i = 1;
        Journal journal = new();

        while (i != 0)
        {
            Console.WriteLine("Enter 1 to load a journal, 2 for a new entry, 3 to display the journal, or 4 to save the journal. Enter 0 to exit.");
            i = float.Parse(Console.ReadLine());

            if (i == 0)
            {
                Console.WriteLine("Please remember to write in your journal daily.");
            }
            else if (i == 1)
            {
                journal = new Journal();
                journal.loadFile();
            }
            else if (i == 2)
            {
                journal.nJEntries();
            }
            else if (i == 3)
            {
                journal.displayJournal();
            }
            else if (i == 4)
            {
                journal.saveJournal();
            }
            else
            {
                Console.WriteLine("Invalid input, please enter an integer 0-4");
            }
        }
    }
}