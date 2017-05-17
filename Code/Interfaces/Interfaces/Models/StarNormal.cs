using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    public class StarNormal : IStar
    {
        public StarNormal(int starId, int galaxyId, Random random)
        {
            _random = random;
            _starId = starId;
            _galaxyId = galaxyId;
            _starType = Extensions.RandomEnumValue<StarType>(_random);

            //TODO - generate planets
        }

        private Random _random;

        private int _galaxyId;
        public int GalaxyId
        {
            get
            {
                return _galaxyId;
            }
        }

        public List<int> LinkedGalaxies
        {
            get; set;
        }

        public List<int> LinkedStars
        {
            get; set;
        }

        public List<IPlanet> Planets
        {
            get; set;
        }

        private int _starId;
        public int StarId
        {
            get { return _starId; }
        }


        private StarType _starType;
        public StarType StarType
        {
            get
            {
                return _starType;
            }
        }
    }
}
