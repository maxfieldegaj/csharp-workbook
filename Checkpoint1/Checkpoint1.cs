using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //Part One:
        //Write a program to count how many numbers between 1 and 100
        //are divisible by 3 with no remainder. Display the count on the console.
        /* int b = 0;
         for (int i = 1; i < 100; i++)
         {
             if (i % 3 == 0)
             {
                 b++;
             }
         }
         Console.WriteLine("Pt. 1: There are " + b + " numbers between 1 and 100 divisible by 3 with no remainder.");
         Console.ReadLine();
         */
        //Part Two:
        //Write a program and continuously ask the user to enter a number or "ok" to exit.
        //Calculate the sum of all the previously entered numbers and display
        //it on the console.
        /*
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
                continueAsking = false;
            }
            
            //Check if it's a number
        //Check if it says ok, if it says ok set !continueASking, which will break loop
       
    };
    {
        Console.WriteLine("Moving On...");
        Console.ReadLine();
    }
    */
        //Part Three
        //Write a program and ask the user to enter a number.
        //Compute the factorial of the number and print it on the console.
        //For example, if the user enters 5, the program should calculate
        //5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

        /*
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
        */

        //Part Four
        //Write a program that picks a random number between 1 and 10.
        //Give the user 4 chances to guess the number.
        //If the user guesses the number, display “You won";
        //otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
        /*
        Random rnd = new Random();
            int winningNumber = rnd.Next(1, 11);
            int guess = 0;
            Console.WriteLine("Pt.4");
            //Console.WriteLine(winningNumber);
            bool hasWon = false;
            int tries = 0;

            while (!hasWon && tries <4)
            {
                //for (int d = 0; d < 4; d++)
                //{
                    Console.WriteLine("Guess a number 1-10.");
                    guess = int.Parse(Console.ReadLine());

                    if (guess == winningNumber)
                    {
                        hasWon = true;
                    }
                tries++;
                // }
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
            */
        //Part 5:
        //Write a program and ask the user to enter a series of numbers separated by comma.
        //Find the maximum of the numbers and display it on the console.
        //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
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
