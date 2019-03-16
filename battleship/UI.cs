using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleship
{
    public static class UI
    {
        static UI()
        {

        }

        public static string GetNames()
        {
            Console.WriteLine("Please enter your name:");
            return Console.ReadLine();
        }

        public static void PlaceGameBoard(string[,] gameBoard)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(gameBoard[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static string[] PlacePiece(Ships placeShip, string name)
        {
            string[] placement = new string[4];
            Console.WriteLine("{0}, please enter the X coordinate for your {1}" ,name, placeShip.shipName);
            placement[0] = Console.ReadLine();
            Console.WriteLine("{0}, please enter the Y coordinate for your {1}", name, placeShip.shipName);
            placement[1] = Console.ReadLine();

            //Console.WriteLine("Horizontal or vertical?");
            //placement[1] = Console.ReadLine();

            return placement;
        }
    }
}