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
            Console.WriteLine("How big of a game board do you want to use?");
            Console.Write("Ex. [3]x3, [4]x4, [5]x5 etc: ");
            int boardSize = int.Parse(Console.ReadLine());
            gameBoard thisGame = new gameBoard(boardSize);
            Console.Write(thisGame.spaces);
            thisGame.populateBoard(boardSize);
            var Play = new PlayGame();
            Play.ChooseMove(p, thisGame, boardSize, 1);
        }
    }
}
