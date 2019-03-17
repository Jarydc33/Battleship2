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
        public string[] shipPlacement;
        public int[] intShipPlacement;
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
            myShips.Add(new Ships(2, "Destroyer", "D"));
            myShips.Add(new Ships(3, "Submarine", "S"));
            myShips.Add(new Ships(4, "Battleship", "B"));
            myShips.Add(new Ships(5, "Carrier","C"));

        }

        
        public void AskForPlacement()
        {
            UI.PlaceGameBoard(MyBoard);
            string[] userInput = new string[8];
            shipPlacement = new string[4];
            intShipPlacement = new int[8];
            for (int i = 0, j = 1; i < 4; i++)
            {                
                userInput = UI.PlacePiece(myShips[i], name);
                shipPlacement[i] = userInput[0];
                intShipPlacement[j] = int.Parse(userInput[1]);
                intShipPlacement[j] -= 1;
                j+=2;
            }
            
        }

        public void PlacePieces(Dictionary<string, int> dictionary)
        {
            for (int i = 0, j = 1, l = 0; i < 8; i+=2)
            {
                for (int k = 0; k < myShips[l].size; k++)
                {
                    MyBoard[intShipPlacement[i], intShipPlacement[j]+k] = "X";
                                     
                }
                l++;
                j += 2;
            }
        }
    }

}