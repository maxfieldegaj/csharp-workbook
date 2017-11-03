using System;

public class Program
{
    public static void Main()
    {
        //Part One:
        //Write a program to count how many numbers between 1 and 100
        //are divisible by 3 with no remainder. Display the count on the console.
        int b = 0;
        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                b++;
            }
        }
        Console.WriteLine("There are " + b + " numbers between 1 and 100 divisible by 3 with no remainder.");
        Console.ReadLine();

        //Part Two:
        //Write a program and continuously ask the user to enter a number or "ok" to exit.
        //Calculate the sum of all the previously entered numbers and display
        //it on the console.
    /*

        bool continueAsking = true;

    while (continueAsking)
    {
        Console.WriteLine("Enter a number please");
        string StringInput = Console.ReadLine();
        int Result = 0;
        bool IsParsed = int.TryParse(StringInput, out Result)
         //Check if it's a number
        //Check if it says ok, if it says ok set !continueASking, which will break loop
       
    }
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
    Console.WriteLine("Please enter a number for a factorial");
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

    Random rnd = new Random();
        int winningNumber = rnd.Next(1, 11);
        int guess = 0;
        Console.WriteLine(winningNumber);

        while (winningNumber != guess)
        {
            for (int d = 0; d < 4; d++)
            {
                Console.WriteLine("Guess a number 1-10.");
                guess = int.Parse(Console.ReadLine());

            }
        }
        if (winningNumber == guess)
            Console.WriteLine("You won!");







    }

}
