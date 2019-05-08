using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player : LivingCreature
    {
        public Player(int currentHitpoints, int maximumHitpoints, int gold, int experiencePoints, int level) : base(currentHitpoints, maximumHitpoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
        }

        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
    }
}
