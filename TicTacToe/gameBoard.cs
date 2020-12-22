using System;
namespace TicTacToe
{
    public class gameBoard
    {
        public string[] spaces;
        public gameBoard(int boardSize)
        {
            int size = boardSize;
            spaces = new string[size * size];
            for (int i = 0; i < spaces.Length; i++) {
                spaces[i] = " ";
            };
        }
        public void populateBoard(int boardSize)
        {
            Console.Clear();
            Console.WriteLine("_____________");

            for (int i = 0; i < spaces.Length; i++)
            {
                Console.Write($"| {this.spaces[i]} ");
                if ((i+1)%boardSize == 0) { Console.WriteLine("|"); }
            };
            Console.WriteLine("-------------");
        }
    }
}
