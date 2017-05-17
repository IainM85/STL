using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    public interface IGalaxy
    {

        int GalaxyId { get; }


        List<int> LinkedGalaxies { get; set; }
        List<IStar> Stars{ get; set; }

    }
}
