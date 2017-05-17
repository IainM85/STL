using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    class GalaxyNormal : IGalaxy
    {
        private Random _random;

        private int _galaxyId;
        public int GalaxyId
        {
            get
            {
                return _galaxyId;
            }
        }

        public List<int> LinkedGalaxies { get; set; }

        public List<IStar> Stars { get; set; }

        private int _currentStarId = 1;

        public GalaxyNormal(int galaxyId, Random random)
        {
            _random = random;
            Stars = new List<IStar>();

            for (int i = 0; i < (_random.Next(100) + 1); i++)
            {
                Stars.Add(new StarNormal(_currentStarId, GalaxyId, _random));
                _currentStarId++;
            }


            LinkedGalaxies = new List<int>();
            foreach (IStar star in Stars)
            {
                if (star.LinkedGalaxies.Count >0)
                {
                    foreach (int linkedGalaxy in star.LinkedGalaxies)
                    {
                        LinkedGalaxies.Add(linkedGalaxy);
                    }
                }
            }

            _galaxyId = galaxyId;
        }
    }
}
