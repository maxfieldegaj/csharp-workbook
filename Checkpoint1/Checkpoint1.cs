using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Parts parts = new Parts();
        parts.PartOne();
        parts.PartTwo();
        parts.PartThree();
        parts.PartFour();
        parts.PartFive();
    }
}

public class Parts
{
    public void PartOne()
    {
        int b = 0;
        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                b++;
            }
        }
        Console.WriteLine("Pt. 1: There are " + b + " numbers between 1 and 100 divisible by 3 with no remainder.");
        Console.ReadLine();
        return;
    }

    public void PartTwo()
    {
        int displayNumber = 0;
        bool continueAsking = true;
        Console.WriteLine("Pt. 2");
        while (continueAsking)
        {
            Console.WriteLine("Enter a number please");
            Console.WriteLine($"Current sum is {displayNumber}");
            string StringInput = Console.ReadLine();
            int Result = 0;
            bool IsParsed = int.TryParse(StringInput, out Result);
            if (IsParsed)
            {
                displayNumber = (displayNumber + Result);
            }
            else
            {
                if (StringInput == "ok")
                {
                    continueAsking = false;
                }
                else
                {
                    continueAsking = true;
                    Console.WriteLine("Error in the input.");
                }
            }
        };
        {
            Console.WriteLine("Moving On...");
            Console.ReadLine();
        }
    }

    public void PartThree()
    {
        int input;
        Console.WriteLine("Pt. 3: Please enter a number for a factorial");
        input = int.Parse(Console.ReadLine());
        int output = input;
        for (int q = input - 1; q >= 1; q--)
        {
            output = output * q;
        }
        Console.WriteLine(input + "! =" + output);
        Console.ReadLine();
    }

    public void PartFour()
    {
        Random rnd = new Random();
        int winningNumber = rnd.Next(1, 11);
        int guess = 0;
        Console.WriteLine("Pt.4");
        bool hasWon = false;
        int tries = 0;

        while (!hasWon && tries < 4)
        {
            Console.WriteLine("Guess a number 1-10.");
            guess = int.Parse(Console.ReadLine());

            if (guess == winningNumber)
            {
                hasWon = true;
            }
            tries++;
        }
        if (hasWon)
        {
            Console.WriteLine("You won!");

        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
        Console.ReadLine();
    }

    public void PartFive()
    {
        Console.WriteLine("Pt. 5: Please enter a series of numbers seperated by commas.");
        string input = Console.ReadLine();

        int maxNumber = 0;

        string[] inputSplit = input.Split(',');

        foreach (var s in inputSplit)
        {
            int valueFromArray = int.Parse(s.Trim());

            if (valueFromArray > maxNumber)
            {
                maxNumber = valueFromArray;
            }
        }

        Console.WriteLine($"The max number is {maxNumber}");
        Console.ReadLine();
    }
}
  
