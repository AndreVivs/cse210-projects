using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int i = 1;
        int guess = -1;
        //int play = 1;
        
        //while (play != 0)
        //{
        while (guess != magicNumber)
        {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
            i++;
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
            i++;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine($"You guessed it in {i} tries, congrats!");
        }
        }

        //Console.Write("Enter a number (0 to finish the game): ");
        //string userResponse = Console.ReadLine();
        //play = int.Parse(userResponse);

        //}                    
    }
}