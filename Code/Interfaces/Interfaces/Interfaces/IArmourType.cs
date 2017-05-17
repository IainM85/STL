using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    public interface IArmourType
    {
        DamageType DamageType { get;  }
        decimal ArmourAmount { get;  }
    }
}
