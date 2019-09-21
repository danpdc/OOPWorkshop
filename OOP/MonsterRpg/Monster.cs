using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRpg
{
    public class Monster
    {
        public Monster(int hitPoints)
        {
            HitPoints = hitPoints;
        }
        public int HitPoints { get; set; }
    }
}
