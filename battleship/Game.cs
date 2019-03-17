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
        int whichTurn;
        List<Player> Players;
        Dictionary<string, int> gameDictionary; 

        public Game()
        {
            Player1 = new Player();
            Player2 = new Player();
            Players = new List<Player>();
            whichTurn = 2;
            Players.Add(Player1);
            Players.Add(Player2);
            gameDictionary = new Dictionary<string, int>();
            SetGameDictionary();
            Player1.MyBoard = GenerateInitialGameBoard();
            Player1.OpponentBoard = Player1.MyBoard;
            Player2.MyBoard = GenerateInitialGameBoard();
            Player2.OpponentBoard = Player2.MyBoard;
            Player1.Name = UI.GetNames();
            Player2.Name = UI.GetNames();
            BeginGame();
        }

        public void BeginGame()
        {
            Player1.AskForPlacement();
            Translator();
            Player1.PlacePieces(gameDictionary);
            UI.PlaceGameBoard(Player1.MyBoard);
            Console.ReadLine();
            Console.Clear();
            whichTurn++;
            Player2.AskForPlacement();
            Translator();
            Player2.PlacePieces(gameDictionary);
            UI.PlaceGameBoard(Player1.MyBoard);
            Console.ReadLine();
        }

        public void Translator()
        {
            int counter = 0;
            for(int i = 0; i < 4; i++)
            {
                foreach (KeyValuePair<string, int> values in gameDictionary)
                {
                    if (Players[whichTurn % 2].shipPlacement[i] == values.Key)
                    {
                        Players[whichTurn % 2].intShipPlacement[counter] = values.Value;
                    }
                }
                counter+=2;
            }
        }               

        public void SetGameDictionary()
        {
            gameDictionary["a"] = 0;
            gameDictionary["b"] = 1;
            gameDictionary["c"] = 2;
            gameDictionary["d"] = 3;
            gameDictionary["e"] = 4;
            gameDictionary["f"] = 5;
            gameDictionary["g"] = 6;
            gameDictionary["h"] = 7;
            gameDictionary["i"] = 8;
            gameDictionary["j"] = 9;
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