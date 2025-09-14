using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    private string _userFileName;

    public Journal()
    {

    }

  

    public void DisplayAll()
    {
        Console.WriteLine(" >>>> Your Entries <<<<");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}; {entry._promptText}; {entry._entryText}");

            }
        }



    }
    public void CreateFile()
    {
        Console.Write("Please enter a flie name.");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".text";

        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"file {_userFileName} has been saved.");
            SaveToFile(_userFileName);
            
            CreateJSON(userInput);
        }

        else
        {
            Console.WriteLine($"The file name {_userFileName} is already in use.");
            Console.WriteLine("The entry has been added.");
            AppendFile(_userFileName);
        }
    }
    public void AppendFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}; {entry._promptText}; {entry._entryText}");
            }
        }
    }
    public void LoadFromFile()
    {
        Console.Write("Please input file name.");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                Entry entry = new Entry();

                entry._date = entries[1];
                entry._promptText = entries[2];
                entry._entryText = entries[3];

                _entries.Add(entry);
            }
        }
    }
    public void CreateJSON(string userInput)
    {
        string fileName = userInput + ".json";
        List<TextItem> _data = new List<TextItem>();

        foreach (Entry entry in _entries)
        {
            _data.Add(new TextItem()
            {
                Date = entry._date,
                Prompt = entry._promptText,
                Entry = entry._entryText


            });
        }
        string json = JsonSerializer.Serialize(_data);
        File.WriteAllText(fileName, json);

    }

    internal void SaveToFile()
    {
        throw new NotImplementedException();
    }
}