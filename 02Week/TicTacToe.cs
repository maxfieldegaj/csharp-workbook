using System;

public class Program
{
    public static string playerTurn = "X";
    public static string[][] board = new string[][]
    {
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "}
     };

    public static void Main()
    {
        // Your code here
        // while (!CheckForWin)
        //  {
        do
        {
            DrawBoard();
            GetInput();
        } while (!CheckForWin() || !CheckForTie()); // true -- loop will keep going
                    // false -- loop is going to end  

        // Won -- Check for win() true when there is a winner, false when not
        // Tie -- new method CheckForTie() true when there is a tie, false when not



      //  }
        Console.ReadLine();

    }


    public static void GetInput()
    {
        Console.WriteLine("Player " + playerTurn);
        Console.WriteLine("Enter Row:");
        int row = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Column:");
        int column = Int32.Parse(Console.ReadLine());

        PlaceMark(row, column);

           return;
    }

    public static void PlaceMark(int row, int column)
    {
        board[row][column] = playerTurn;
        return;
    }

    public static bool CheckForWin()
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

    public static bool CheckForTie()
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
            verticalWin= true;
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

    public static void DrawBoard()
    {
        Console.WriteLine("  0 1 2");
        Console.WriteLine("0 " + String.Join("|", board[0]));
        Console.WriteLine("  -----");
        Console.WriteLine("1 " + String.Join("|", board[1]));
        Console.WriteLine("  -----");
        Console.WriteLine("2 " + String.Join("|", board[2]));
        return;
    }
}
