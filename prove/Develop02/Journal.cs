using System.IO;
public class Journal
{
    List<Entry> journalEntries = new List<Entry>();

    string fileName = "";

    public void loadFile()
    {
        Console.WriteLine("Please enter the file name. ");
        fileName = Console.ReadLine()!.Trim();
    }

    public void nJEntries()
    {
        journalEntries.Append(new Entry(fileName));
    }

    public void displayJournal()
    {
        List<string> thisJournal = new List<string>();
        StreamReader sr = new StreamReader(fileName);
        string line = sr.ReadLine();
        while (line != null)
        {
            line = sr.ReadLine();
            Console.WriteLine(line);
        }
        Console.ReadLine();

        for (int i = 0; i < journalEntries.Count; i++)
        {
            Console.WriteLine($"{journalEntries[i]}");
        }
    }

    public void saveJournal()
    {
        if (string.IsNullOrWhiteSpace(fileName))
            throw new InvalidOperationException("No file name set. Call loadFile() first.");

        for (int i = 0; i < journalEntries.Count; i++)
        {
            Console.WriteLine($"{journalEntries[i]}");
        }
    }
}