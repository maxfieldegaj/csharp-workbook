using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Game game = new Game();
        Console.ReadLine();
        // Your code here
    }
}

public class Checker
{
    public string Symbol  { get; set; }
    public int[] Position  { get; set; }
    public string Color { get; set; }
    
    // Constructor
    public Checker(string color, int[] position)
    {
        Color = color;
        Position = position;

        //  Use unicode to represent the symbol'
        // when we print to the console
        Symbol = color == "white" ? "\u25cf": "\u25cb";
    }
}

public class Board
{
    public string[][] Grid { get; set; }
    public List<Checker> Checkers { get; set; }
    // variable

    // position of white checkers
    int[][] whitePosition = new int[][]
    {
        new int[] { 0, 1 },
        new int[] {0, 3 },
        new int[] {0, 5 },
        new int[] {0, 7 },
        new int[] {1, 0 },
        new int[] {1, 2 },
        new int[] {1, 4 },
        new int[] { 1, 6 },
        new int[] {2, 1 },
        new int[] {2, 3 },
        new int[] {2, 5 },
        new int[] {2, 7 },
    };

    // position of black checkers
    int[][] blackPosition = new int[][]
    {
       new int[] { 5, 0 },
       new int[] {5, 2 },
       new int[] {5, 4 },
       new int[] {5, 6 },
       new int[] {6, 1 },
       new int[] {6, 3},
       new int[] {6, 5},
       new int[] {6, 7},
       new int[] {7, 0},
       new int[] {7, 2},
       new int[] {7, 4},
       new int[] {7, 6}
    };

    public Board()
    {

        // Your code here
        return;
    }
    
    public void CreateBoard()
    {
        // Board is 8x8
        Grid = new string[][]
        {
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
        };
        return;
    }
    
    public void GenerateCheckers()
    {
        // 12 pieces per color - 24 all together
        // white position:
        Checkers = new List<Checker>();
        for (var i = 0; i < whitePosition.Length; i++)
        {
            Checker checker = new Checker("white", whitePosition[i]);
            Checkers.Add(checker);
        }
        // black position:
        for (var i = 0; i < blackPosition.Length; i++)
        {
            Checker checker = new Checker("black", blackPosition[i]);
            Checkers.Add(checker);

        }

        return;
    }
    
    public void PlaceCheckers()
    {
        // CHeckers List (property) contains all 24 pieces 
        foreach(var c in Checkers)
        {
            int[] position = c.Position; // ex: [0, 2]

            Grid[position[0]][position[1]] = c.Symbol;
        }
        return;
    }
    
    public void DrawBoard()
    {
        Console.WriteLine("   0  1  2  3  4  5  6  7");
        for(int i = 0; i < Grid.Length; i++) // row
        {
            string row = $"{i} ";

            for(int e = 0; e < Grid[i].Length; e++) // column
            {
                row += $" {Grid[i][e]} ";
            }
            Console.WriteLine(row);
        }

    }
    
    public Checker SelectChecker(int row, int column)
    {
        return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
    }
    
    public void RemoveChecker(int row, int column)
    {
        // Your code here
        return;
    }
    
    public bool CheckForWin()
    {
        return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
    }
}

class Game
{
    public Game()
    {
        Board board = new Board();
        board.GenerateCheckers();
        board.CreateBoard();
        board.PlaceCheckers();
       // board.DrawBoard();

        do
        {
            board.DrawBoard();

            Console.WriteLine("'move' or 'remove' checker?");
            string input = Console.ReadLine();

            Console.WriteLine("Enter pickup row:");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter pickup column:");
            int column = int.Parse(Console.ReadLine());

            Checker selectedChecker = board.SelectChecker(row, column);

            if (input == "remove")
            {
                board.Checkers.Remove(selectedChecker);
            }
            else
            {
                Console.WriteLine("Enter placement row:");
                row = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter placement column:");
                column = int.Parse(Console.ReadLine());

                selectedChecker.Position = new int[] { row, column };
            }

            board.CreateBoard();
            board.PlaceCheckers();

        } while (!board.CheckForWin());

        if (board.CheckForWin())
        {
            if (board.Checkers.All(x => x.Color == "white"))
            {
                Console.WriteLine("White has won!");
            }
            else
            {
                Console.WriteLine("Black has won!");
            }
        } 


    }
}
