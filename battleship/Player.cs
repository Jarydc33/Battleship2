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
        public Submarine Submarine;
        public Carrier Carrier;
        public Destroyer Destroyer;
        public Battleship Battleship;

        public Player()
        {
            Submarine = new Submarine();
            Carrier = new Carrier();
            Destroyer = new Destroyer();
            Battleship = new Battleship();
            score = 0;
            myBoard = new string[20, 20];
            opponentBoard = new string[20, 20];

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
    }
}