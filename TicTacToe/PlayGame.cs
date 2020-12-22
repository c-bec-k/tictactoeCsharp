using System;
namespace TicTacToe
{
    public class PlayGame
    {
        public PlayGame()
        {
        }
        public void ChooseMove(Player[] p, gameBoard thisGame, int boardSize, int currentPlayer)
        {
            int currentMove = 0;
            while(currentMove == 0)
            {
                Console.Write($"{p[currentPlayer-1].name}, choose a space: ");
                currentMove = int.Parse(Console.ReadLine());
                string errorMessage = "";
                var currentSpace = thisGame.spaces[currentMove - 1];
                if (currentMove < 0)
                { errorMessage = "Please enter a number value (ex: 5): "; }
                if (currentSpace == p[0].symbol || currentSpace == p[1].symbol)
                { errorMessage = "Please choose a space not used."; currentMove = 0; }
                Console.WriteLine(errorMessage);
            }
            thisGame.spaces[currentMove - 1] = p[currentPlayer - 1].symbol;
            thisGame.populateBoard(boardSize);
            if (currentPlayer == 1) { currentPlayer = 2; }
            else { currentPlayer = 1; }
            ChooseMove(p, thisGame, boardSize, currentPlayer);
        }
    }
}
