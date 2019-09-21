using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRpg
{
    public class KickingMonster : Monster
    {
        public KickingMonster(int hitPoints, int kickDamage)
            : base(hitPoints)
        {
            KickDamage = kickDamage;
        }
        public int KickDamage { get; set; }
    }
}
