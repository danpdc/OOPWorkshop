using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRpg
{
    public class BitingKickingPunchingMonster : BitingMonster
    {
        public BitingKickingPunchingMonster(int hitPoints, int biteDamage, int kickDamage, int punchDamage)
            : base(hitPoints, biteDamage)
        {
            KickDamage = kickDamage;
            PunchDamage = punchDamage;
        }
        public int KickDamage { get; set; }
        public int PunchDamage { get; set; }

    }
}
