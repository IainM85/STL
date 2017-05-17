using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    public class GameState
    {
        private IPlayer _activePlayer;
        public List<IPlayer> Players { get; set; }

        public IPlayer ActivePlayer { get { return _activePlayer; } set { _activePlayer = value; } }

        public IUniverse Universe { get { return _universe; } set { _universe = value; } }
        private IUniverse _universe;

        public GameState()
        {
            // By default create a standard player and add to the list of players
            ActivePlayer = new Player();
            Players.Add(ActivePlayer);
            Universe = new Universe();
        }

    }
}
