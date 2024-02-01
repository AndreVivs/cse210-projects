using System;
using System.Collections.Generic;


static class Program
{
    private static List<Entry> _entries = new List<Entry>();

    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        int userOption = PromptUserOption();

        while (userOption >= 1 && userOption <5)
        {
            if (userOption == 1)
            {
                Entry entry1 = new Entry();
                entry1._date = DateTime.Now.ToString("MM/dd/yyyy");
                entry1._promptText = PromptGenerator.GetRandomPrompt();
                Console.WriteLine(entry1._promptText);
                entry1._entryText = Console.ReadLine();

                _entries.Add(entry1);
            }
            else if (userOption == 2)
            {

                Console.WriteLine("YOUR JURNAL");
                Console.WriteLine("");

                foreach (Entry e in _entries)
                {
                    Console.WriteLine($"Date: {e._date} - Prompt: {e._promptText}");
                    Console.WriteLine($"{e._entryText}");
                }
                
                Console.WriteLine("");
            }
            else if (userOption == 3)
            {
                Console.WriteLine("What is the filename?");
                string fileToLoad = Console.ReadLine();
                Journal.LoadFromFile(fileToLoad);
            }
            else if (userOption == 4)
            {
                Console.WriteLine("What is the filename?");
                string fileToSave = Console.ReadLine();
                Journal.SaveToFile(fileToSave);
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }

            userOption = PromptUserOption();
        }
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }

    static int PromptUserOption()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
        int option = int.Parse(Console.ReadLine());

        return option;
    }

}