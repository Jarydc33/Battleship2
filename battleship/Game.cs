using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleship
{
    public class Game
    {

        public Player Player1;
        public Player Player2;
        public UI UI;

        public Game()
        {
            Player1 = new Player();
            Player2 = new Player();
            UI = new UI();
            Player1.MyBoard = GenerateInitialGameBoard();
            Player1.OpponentBoard = Player1.MyBoard;
            Player2.MyBoard = GenerateInitialGameBoard();
            Player2.MyBoard = Player2.OpponentBoard;
        }



        public string[,] GenerateInitialGameBoard()
        {
            string[,] myBoard = new string[20, 20];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    myBoard[i, j] = ".";
                    Console.Write(myBoard[i, j] + " ");
                }
            }
            return myBoard;
        }
    }
}