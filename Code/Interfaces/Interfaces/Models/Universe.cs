using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    public class Universe : IUniverse
    {
        private List<IGalaxy> _galaxies;

        public List<IGalaxy> Galaxies { get { return _galaxies; } set { _galaxies = value; } }
        public int UniverseId { get { return _universeId; } set { _universeId = value; } }
        private int _currentGalaxyId = 1;
        private Random _random = new Random();


        private int _universeId;

        public Universe()
        {
            // Generate a random universe ID, this will be used as a random seed for all subsequent generation so a universe is replicatable?
            UniverseId = _random.Next(int.MaxValue);

            Galaxies = new List<IGalaxy>();

            for (int i = 0; i < (_random.Next(5) + 1); i++)
            {
                // Add some random galaxies
                Galaxies.Add(new GalaxyNormal(_currentGalaxyId, _random));
                _currentGalaxyId++;
            }


        }
    }
}
