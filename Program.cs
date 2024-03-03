
using System.Security;

namespace TicTacToe_ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        bool player1Turn = true;

        while (true)
        {
            if (player1Turn)
                System.Console.WriteLine("Player 1 Turn");
            else System.Console.WriteLine("Player 2 Turn");

            string choice = Console.ReadLine();



            printGrid();
        }

    }

    bool checkWinner(string[] grid)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (grid[i * 3 + j] == grid[(i * 3 + j) + 1] && grid[(i * 3 + j) + 1] == grid[(i * 3 + j) + 2])
                    return true;
            }

        }

        return false;

    }

    public static void printGrid()
    {
        string[] grid = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
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
