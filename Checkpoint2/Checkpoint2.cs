using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Class1
{
	public static void Main()
	{
        Console.OutputEncoding = Encoding.UTF8;
        Game game = new Game();
        Console.ReadLine();
    }
}

public class Grid
{
    public static string playerTurn = "X";

    public static string[][] board = new string[][]
    {
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "}
     };

    public void DrawBoard()
    {
        Console.WriteLine("  0 1 2");
        Console.WriteLine("0 " + String.Join("|", board[0]));
        Console.WriteLine("  -----");
        Console.WriteLine("1 " + String.Join("|", board[1]));
        Console.WriteLine("  -----");
        Console.WriteLine("2 " + String.Join("|", board[2]));
        return;
    }

    public void GetInput()
    {
        Console.WriteLine("Player " + playerTurn);
        Console.WriteLine("Enter Row:");
        int row = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Column:");
        int column = Int32.Parse(Console.ReadLine());

        PlaceMark(row, column);
        return;
    }

    public void PlaceMark(int row, int column)
    {
        board[row][column] = playerTurn;
        return;
    }

    public bool CheckForWin()
    {
        bool hasPlayerWon = HorizontalWin() || VerticalWin() || DiagonalWin();

        if (hasPlayerWon)
        {
            Console.WriteLine("Player " + playerTurn + " Won!");
        }
        else
        {
            playerTurn = playerTurn == "X" ? "O" : "X";
        }

        return hasPlayerWon;
    }

    public bool CheckForTie()
    {
        bool havePlayersTied = false;

        if (board[0][0] != " " && board[0][1] != " " && board[0][2] != " " && board[1][0] != " "
             && board[1][1] != " " && board[1][2] != " " && board[2][0] != " " && board[2][1] != " "
              && board[2][2] != " ")
        {
            havePlayersTied = true;
        }

        return !havePlayersTied;
    }

    public static bool HorizontalWin()
    {
        // Your code here
        bool horizontalWin = false;

        if (board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn)
        {
            horizontalWin = true;
        }
        if (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn)
        {
            horizontalWin = true;
        }
        if (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn)
        {
            horizontalWin = true;
        }

        return horizontalWin;
    }

    public static bool VerticalWin()
    {
        bool verticalWin = false;

        if (board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn)
        {
            verticalWin = true;
        }
        if (board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn)
        {
            verticalWin = true;
        }
        if (board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn)
        {
            verticalWin = true;
        }

        return verticalWin;
    }

    public static bool DiagonalWin()
    {
        bool diagonalWin = false;

        if (board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn)
        {
            diagonalWin = true;
        }
        if (board[2][0] == playerTurn && board[1][1] == playerTurn && board[0][2] == playerTurn)
        {
            diagonalWin = true;
        }

        return diagonalWin;
    }
}

public class Game
{
    public Game()
    {
        Grid grid = new Grid();
        do
        {
            grid.DrawBoard();
            grid.GetInput();
        } while (!grid.CheckForWin() || !grid.CheckForTie());


        
    }
}
