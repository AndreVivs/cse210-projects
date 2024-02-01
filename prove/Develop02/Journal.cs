using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public static List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public static void DisplayAll()
    {
        Console.WriteLine("holaaaaaaa :)");

        //foreach (Entry e in _entries)
        //{
        //    Console.WriteLine($"Date: {e._date} - Prompt: {e._promptText}");
        //    Console.WriteLine($"{e._entryText}");
        //}
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
