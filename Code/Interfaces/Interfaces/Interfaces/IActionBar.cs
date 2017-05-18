using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface IActionBar
    {
        List<ActionType> ActionsAvailable { get; set; }

        float ActionReadyAmount { get; set; }

        float ActionAmount { get; set; }
        float ActionRatePerSecond { get; set; }

        float SecondsPerAction { get; set; }

        bool ActionReady { get; }

    }
}
