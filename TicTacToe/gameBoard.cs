using System;
namespace TicTacToe
{
    public class gameBoard
    {
        public string[] spaces;
        public gameBoard(int boardSize)
        {
            int size = boardSize;
            string[] spaces = new string[size * size];
            for (int i = 0; i < size * size; i++) {
                spaces[i] = " ";
            };
        }
        public void populateBoard(gameBoard board)
        {
            Console.Clear();
            Console.WriteLine("_____________");

            for (int i = 0; i < board.spaces.Length; i++)
            {
                Console.Write($"|{board.spaces[i]}");
                if ((i+1)%3 == 0) { Console.WriteLine("|"); }
            };
            Console.WriteLine("-------------");
        }
    }
}
