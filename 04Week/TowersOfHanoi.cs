using System;
using System.Collections.Generic;

public class Program
{
    public static Dictionary<string, List<int>> stacks = new Dictionary<string, List<int>>()
    {
        { "a", new List<int>() {4, 3, 2, 1} },
        { "b", new List<int>() {} },
        { "c", new List<int>() {} }
    };

    public static void Main()
    {
        // lopp true the methods using do {...}while()
        // think when the loop will end
        // think of what method calls go inside the code block
        do
        {
            printStacks();
            // Ask for start input - Console.WriteLine("...");
            Console.WriteLine("Where would you to move a stack from?");

            // capture that input using Console.ReadLine();
            string start = Console.ReadLine().ToLower();

            // Ask for finish input - Console.WriteLine();
            Console.WriteLine("Where you like to place the stack?");

            // capture input using Console.ReadLine();
            string finish = Console.ReadLine().ToLower();

            //check if the move is legal
            if (IsLegal(start, finish))
            {
                MovePiece(start, finish);
            }
            else
            {

            }
            Console.WriteLine("Invalid Move");
            // we only make a move if the move was legal

        } while (!GameOver());

        Console.ReadLine();


    }

    public static bool GameOver()
    {
        if (stacks["a"].Count == 0 && stacks["b"].Count == 0)
            return true;
        // Your code here;
        return false;
    }

    public static void MovePiece(string start, string finish)
    {
        // Move a piece
        int lastElement = stacks[start].Last();

        //add lastElement into the finish pillar
        stacks[finish].Add(lastElement);

        // Remove it from start pillar
        stacks[start].Remove(lastElement);
    }

    public static bool IsLegal(string start, string finish)
    {
        // Is it a legal Move?
        //check for empty pillar - finish (last)
        if (stacks[finish].Count == 0)
            return true;

        int lastNumberFromStart = stacks[start].Last();
        int lastNumberFromFinish = stacks[finish].Last();

        if (lastNumberFromStart < lastNumberFromFinish)
            return true;

        return false;
    }

    public static void printStacks()
    {
        string[] letters = new string[] { "a", "b", "c" };
        for (var i = 0; i < letters.Length; i++)
        {
            List<string> blocks = new List<string>();
            for (var j = 0; j < stacks[letters[i]].Count; j++)
            {
                blocks.Add(stacks[letters[i]][j].ToString());
            }
            Console.WriteLine(letters[i] + ": " + String.Join("|", blocks));
        }
    }
}
