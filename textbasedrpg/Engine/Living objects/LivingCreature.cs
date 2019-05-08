using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class LivingCreature
    {
        public LivingCreature(int currentHitpoints, int maximumHitpoints)
        {
            CurrentHitpoints = currentHitpoints;
            MaximumHitpoints = maximumHitpoints;
        }

        public int CurrentHitpoints { get; set; }
        public int MaximumHitpoints { get; set; }
    }
}
