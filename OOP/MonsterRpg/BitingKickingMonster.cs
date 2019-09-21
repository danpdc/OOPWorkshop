using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRpg
{
    public class BitingKickingMonster : BitingMonster
    {
        public BitingKickingMonster(int hitPoints, int biteDamage, int kickDamage)
            : base(hitPoints, biteDamage)
        {
            KickDamage = kickDamage;
        }
        public int KickDamage { get; set; }

    }
}
