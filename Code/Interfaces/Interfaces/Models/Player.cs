using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
