using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 97)
        {
            letter = "A";
        }
        else if (percent >= 90)
        {
            letter = "A-";
        }
        else if (percent >= 87)
        {
            letter = "B+";
        }
        else if (percent >= 84)
        {
            letter = "B";
        }
        else if (percent >= 80)
        {
            letter = "B-";
        }
        else if (percent >= 77)
        {
            letter = "C+";
        }
        else if (percent >= 74 )
        {
            letter = "C";
        }
        else if (percent >= 70 )
        {
            letter = "C-";
        }
        else if (percent >= 67)
        {
            letter = "D+";
        }
        else if (percent >= 64)
        {
            letter = "D";
        }
        else if (percent >= 60 )
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your final grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Yay, you passed!");
        }
        else
        {
            Console.WriteLine("Upsis, try again the next semester!");
        }
    }
}