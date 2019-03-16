using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleship
{
    public class Ships
    {
        public int size;
        public string shipName;

        public Ships(int Size, string ShipName)
        {
            size = Size;
            shipName = ShipName;
        }
    }
}