using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPlanet
    {

        int PlanetId { get; }
        
        PlanetType PlanetType { get; }
        PlanetSurfaceType SurfaceType { get; }
    }
}
