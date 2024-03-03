
using System.Linq;
using System.Security;

namespace TicTacToe_ConsoleApp;

class Program
{
    static string[] grid = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
    static void Main(string[] args)
    {
        bool player1Turn = true;

        while (!checkWinner())
        {
            printGrid(grid);
            if (player1Turn)
                System.Console.WriteLine("Player 1 Turn");
            else System.Console.WriteLine("Player 2 Turn");

            string choice = Console.ReadLine();
            int choiceIndex = int.Parse(choice) - 1;
            System.Console.WriteLine(grid.Contains(choice));

            if(grid.Contains(choice) && choice != "X" && choice != "O"){
                if(player1Turn)  grid[choiceIndex] = "X";
                else grid[choiceIndex] = "O";
                player1Turn = !player1Turn;
            }

            if(checkWinner()) System.Console.WriteLine("You win");

        }

    }

   static bool checkWinner()
    {
        bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
        bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
        bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
        bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
        bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
        bool col3 = grid[2] == grid[5] && grid[5] == grid[8];
        bool diag1 = grid[0] == grid[4] && grid[4] == grid[8];
        bool diag2 = grid[2] == grid[4] && grid[4] == grid[6];
        return row1 || row2 || row3 || col1 || col2 || col3 || diag1 || diag2;

    }

    public static void printGrid(string[] grid)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(grid[i * 3 + j] + " | ");
            }
            System.Console.WriteLine();
            Console.WriteLine("-----------");
        }
    }
}
