using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new gameBoard(3);
            Player[] p = new Player[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Player {i+1}, what is your name? ");
                string name = Console.ReadLine();
                Console.Write("And what do you want your symbol to be? ");
                string symbol = Console.ReadLine();
                p[i] = new Player();
                p[i].name = name;
                p[i].symbol = symbol;
            }
            gameBoard thisGame = new gameBoard(3);
            populateBoard(thisGame);
        }
    }
}
