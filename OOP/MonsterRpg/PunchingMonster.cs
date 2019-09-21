using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRpg
{
    public class PunchingMonster : Monster
    {
        public PunchingMonster(int hitPoints, int punchDamage)
            : base(hitPoints)
        {
            PunchDamage = punchDamage;
        }
        public int PunchDamage { get; set; }

    }
}
