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
        Dictionary<string, int> gameDictionary; 

        public Game()
        {
            Player1 = new Player();
            Player2 = new Player();
            gameDictionary = new Dictionary<string, int>();
            SetGameDictionary();
            Player1.MyBoard = GenerateInitialGameBoard();
            Player1.OpponentBoard = Player1.MyBoard;
            Player2.MyBoard = GenerateInitialGameBoard();
            Player2.MyBoard = Player2.OpponentBoard;
            Player1.Name = UI.GetNames();
            Player2.Name = UI.GetNames();
            BeginGame();
        }

        public void BeginGame()
        {
            Player1.PlacePieces();
            Player2.PlacePieces();
        }

        public void Translator()
        {

        }

        public void SetGameDictionary()
        {
            gameDictionary["A"] = 0;
            gameDictionary["B"] = 1;
            gameDictionary["C"] = 2;
            gameDictionary["D"] = 3;
            gameDictionary["E"] = 4;
            gameDictionary["F"] = 5;
            gameDictionary["G"] = 6;
            gameDictionary["H"] = 7;
            gameDictionary["I"] = 8;
            gameDictionary["J"] = 9;
        }

        public string[,] GenerateInitialGameBoard()
        {
            string[,] board = new string[20, 20];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    board[i, j] = ".";
                }
            }
            return board;
        }
    }
}