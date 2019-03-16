using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleship
{
    public class Player
    {
        private string[,] myBoard;
        private int score;
        private string[,] opponentBoard;
        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public string[,] MyBoard
        {
            get => myBoard;
            set
            {
                myBoard = value;
            }
        }
        public string[,] OpponentBoard
        {
            get => opponentBoard;
            set
            {
                opponentBoard = value;
            }
        }
        public int Score
        {
            get => score;
            set
            {
                score = value;
            }
        }
        List<Ships> myShips;

        public Player()
        {
            score = 0;
            myBoard = new string[20, 20];
            opponentBoard = new string[20, 20];
            myShips = new List<Ships>();
            myShips.Add(new Ships(2, "Destroyer"));
            myShips.Add(new Ships(3, "Submarine"));
            myShips.Add(new Ships(4, "Battleship"));
            myShips.Add(new Ships(5, "Carrier"));

        }

        
        public void PlacePieces()
        {

            string[] userInput = new string[2];
            string[] placement = new string[8];
            for (int i = 0, j = 0; i < 4; i++)
            {
                UI.PlaceGameBoard(MyBoard);
                userInput = UI.PlacePiece(myShips[i], name);
                placement[j] = userInput[0];
                placement[j + 1] = userInput[1];
                j += 2;
            }


        }
    }

}