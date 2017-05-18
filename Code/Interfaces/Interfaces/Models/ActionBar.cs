using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public class ActionBar : IActionBar
    {
        public ActionBar ()
        {
            ActionReadyAmount = 100f;
            ActionAmount = 0f;
            ActionRatePerSecond = 5f; // One action every 20 seconds
        }


        public List<ActionType> ActionsAvailable { get; set; }

        public float ActionReadyAmount { get; set; }

        public float ActionAmount { get; set; }
        public float ActionRatePerSecond { get; set; }

        public float SecondsPerAction
        {
            get
            {
                return ActionReadyAmount / ActionRatePerSecond;
            }
            set
            {
                ActionRatePerSecond = ActionReadyAmount / value;
            }
        }

        public bool ActionReady { get { return ActionAmount >= ActionReadyAmount; } }
    }
}
