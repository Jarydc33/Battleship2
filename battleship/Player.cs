using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleship
{
    public class Player
    {
        private char[] gameBoard;
        private int score;
        private int opponentBoard;

        public Player()
        {
            throw new System.NotImplementedException();
        }

        public Submarine Submarine
        {
            get => default(Submarine);
            set
            {
            }
        }

        public Carrier Carrier
        {
            get => default(Carrier);
            set
            {
            }
        }

        public Destroyer Destroyer
        {
            get => default(Destroyer);
            set
            {
            }
        }

        public Battleship Battleship
        {
            get => default(Battleship);
            set
            {
            }
        }

        public int GameBoard
        {
            get => default(int);
            set
            {
            }
        }

        public int OpponentBoard
        {
            get => default(int);
            set
            {
            }
        }

        public int Score
        {
            get => default(int);
            set
            {
            }
        }
    }
}