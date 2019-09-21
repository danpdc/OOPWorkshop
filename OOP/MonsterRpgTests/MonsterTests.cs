using MonsterRpg;
using System;
using Xunit;

namespace MonsterRpgTests
{
    public class MonsterTests
    {
        [Fact]
        public void TestBitingMonster()
        {
            Monster crocodile = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Crocodile);

            Assert.True(crocodile is BitingMonster);
        }

        [Fact]
        public void TestBitingKickingMonster()
        {
            Monster horse = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Horse);

            Assert.True(horse is BitingMonster);

            // This test will fail, because we cannot inherit from multiple base classes.
            Assert.True(horse is KickingMonster);
        }
    }
}
