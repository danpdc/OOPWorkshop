using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRpg
{
    public class BitingMonster : Monster
    {
        public BitingMonster(int hitPoints, int biteDamage)
            : base(hitPoints)
        {
            BiteDamage = biteDamage;
        }
        public int BiteDamage { get; set; }

    }
}
