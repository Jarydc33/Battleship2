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
        public string icon;

        public Ships(int Size, string ShipName, string Icon)
        {
            size = Size;
            shipName = ShipName;
            icon = Icon;
        }
    }
}