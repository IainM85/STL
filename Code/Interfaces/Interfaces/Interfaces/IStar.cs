using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    public interface IStar
    {
        int StarId { get; }
        int GalaxyId { get; }



        StarType StarType { get; }

        List<IPlanet> Planets { get; set; }
        List<int> LinkedStars { get; set; }

        /// <summary>
        /// List of galaxy IDs that can be reached from this star system
        /// This will be empty for most stars
        /// </summary>
        List<int> LinkedGalaxies { get; set; }


    }
}
