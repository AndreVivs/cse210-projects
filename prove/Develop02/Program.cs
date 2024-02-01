using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static List<Entry> _entries = new List<Entry>();

    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        int userOption = PromptUserOption();

        while (userOption >= 1 && userOption <= 5)
        {
            if (userOption == 1)
            {
                Journal.AddEntry();
            }
            else if (userOption == 2)
            {
                Journal.DisplayAll();
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