using System;

public class Program
{
	public static void Main()
	{
        
        //Write a C# program that takes two numbers as input,
        //adds them together, and displays the result of that operation

        //Ask for first number
        Console.WriteLine("What's the first number?");

        //Save that number
        // int firstNumber = int.Parse(Console.ReadLine());
        int firstNumber;

        var didItParse = int.TryParse(Console.ReadLine(), out firstNumber);

        if (!didItParse)
        {
            firstNumber = 0;
        }


        //Ask for second number
        Console.WriteLine("What's the second number?");

        //Save second number
        int secondNumber;

        didItParse = int.TryParse(Console.ReadLine(), out secondNumber);

        if (!didItParse)
        {
            secondNumber = 0;
        }


        //Add
        int result = firstNumber + secondNumber;

        //Show the result
        Console.WriteLine("The result is: " + result);
        Console.ReadLine();
        

        
        //2. Write a C# program that coverts yards to inches

        // Ask user for input of yards
        Console.WriteLine("How many yards do you wish to convert?");

        //Process User input
        var yards = int.Parse(Console.ReadLine());

        //Set ratio of yards to inches
        var inches = yards * 36;

        //Print Result to Console
        Console.WriteLine(yards + " yards is " + inches + " inches.");
        Console.ReadLine();
        

        //3. Create and define the variable people as true
        bool people = true;

        //4. Create and define the variable f as false.
        bool f = false;

        //5. Create and define the variable num to be a decimal.
        decimal num = 2.33M;
        Console.WriteLine("Num is: " + num);
        Console.ReadLine();

        //6. Display the product of num multiplied by itself.
        decimal num2 = num * num;
        Console.WriteLine("Num squared is: " + num2);
        Console.ReadLine();

        //7. Create the following variables with your personal information: first name, lastName, age, job, favoriteBand
        // favoriteSportsTeam
        var firstName = "Max";
        var lastName = "Gaj";
        var age = 24;
        var job = "Bartender";
        var favoriteBand = "Alt-J";
        var favoriteSportsTeam = "Patriots";
            


    }
}
