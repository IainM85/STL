using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    public class Player : IPlayer
    {
        public Player()
        {
            ActiveShip = new StartingShip();
        }

        public IShip ActiveShip { get; set; }



    }
}
