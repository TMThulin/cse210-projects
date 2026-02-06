using System.IO;

public class Entry
{
    List<string> prompts = new List<string>
    {
        "What challenge did you overcome today?",
        "What stood out in your scripture study today?",
        "In what way do you want to improve tommorow",
        "What did you need to hear today? Did anyone say it?",
        "What did you learn today?"
    };

    Random randomGenerator = new Random();
    int i;
    public string EntryPrompt;
    public string UserEntry;
    public string DateText;
    public string FileName;

    public Entry(string fileName)
    {
        FileName = fileName;
        i = randomGenerator.Next(0, prompts.Count);
        Console.WriteLine(prompts[i]);

        using (StreamWriter outputFile = new StreamWriter(FileName, append: true))
        {
            EntryPrompt = prompts[i];
            outputFile.WriteLine(prompts[i]);
    
            UserEntry = Console.ReadLine();
            outputFile.WriteLine(UserEntry);

            DateText = DateTime.Now.ToShortDateString();
            outputFile.WriteLine(DateText);
        }
    }

    public Entry(string fileName, string entryPrompt, string userEntry, string dateText)
    {
        FileName = fileName;
        EntryPrompt = entryPrompt;
        UserEntry = userEntry;
        DateText = dateText;
    }
}