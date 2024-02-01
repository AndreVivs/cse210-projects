using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public static List<Entry> _entries = new List<Entry>();

    public static void AddEntry()
    {
      Entry entry1 = new Entry();
      entry1._date = DateTime.Now.ToString("MM/dd/yyyy");
      entry1._promptText = PromptGenerator.GetRandomPrompt();
      Console.WriteLine(entry1._promptText);
      entry1._entryText = Console.ReadLine();

      _entries.Add(entry1);
    }

    public static void DisplayAll()
    {
        Console.WriteLine("YOUR JOURNAL");
        Console.WriteLine("");

        foreach (Entry e in _entries)
        {
            e.Display();
        }

        Console.WriteLine("");
    }

    public static void SaveToFile(string fileToSave)
    {
      //Console.WriteLine($"Estos son los datos {_entries}, {fileToSave}");
        if (fileToSave != null)
        {
            using (StreamWriter outputFile = new StreamWriter(fileToSave))
            {
                foreach (Entry entry in _entries)
                {
                    string line = $"{entry._date},{entry._promptText},{entry._entryText}";
                    outputFile.WriteLine(line);

                    //Console.WriteLine(outputFile);
                    
                    Console.WriteLine("File saved");

                }
            }
        }
    }

    public static void LoadFromFile(string fileToLoad)
    {
        string[] lines = System.IO.File.ReadAllLines(fileToLoad);
        if (lines != null)
        {
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 3)
                {
                    string _date = parts[0];
                    string _promptText = parts[1];
                    string _entryText = parts[2];

                    Console.WriteLine($"{_date}, {_promptText}, {_entryText}");
                }
            }
        }
    }

}
