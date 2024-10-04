using System.IO;


public class Journal
{

public List<Entry> _entries = new List<Entry>();

public void AddEntry(Entry newEntry)
{
    _entries.Add(newEntry);
 
}

public  void DisplayAll()
{
    foreach (Entry entry in _entries)
    {
        entry.Display();
    }
    if (_entries.Count == 0)
    {
        Console.WriteLine("No entries currently stored in your journal.");
    }
}

public void SaveToFile(string journFile)
{
using (StreamWriter outputFile = new StreamWriter(journFile))
{
    foreach (Entry entry in _entries)
    {
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._userEntry}");
    }
    
}
}

public void LoadFromFile(string journFile)
{
    string[] lines = System.IO.File.ReadAllLines(journFile);
    _entries.Clear();

    foreach (string line in lines)
{
    string[] parts = line.Split(",");

         if (parts.Length == 3)
        {
            Entry loadedEntry = new Entry();
            loadedEntry._date = DateTime.Parse(parts[0]);  
            loadedEntry._prompt = parts[1];
            loadedEntry._userEntry = parts[2];

            _entries.Add(loadedEntry);  
        }
   
}
DisplayAll();
}




}