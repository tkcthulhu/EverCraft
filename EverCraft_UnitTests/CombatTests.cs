using EverCraft_CORE;

namespace EverCraft_UnitTests
{
    [TestClass]
    public class BasicCombatTests
    {
        [TestMethod]
        public void Attack_CharacterCanBeAttacked_ReturnsTrue()
        {
            //Testing that a character can land a successful hit

            BaseCharacter attacker = new BaseCharacter("Test1");

            BaseCharacter defender = new BaseCharacter("Test2");

            int roll = 12;

            Combat TestFight = new Combat(attacker, defender);

            bool result = TestFight.Attack(roll);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Attack_CharacterCanDefend_ReturnsFalse()
        {
            //Testing a character can defend (Defender is successful on a tie)

            BaseCharacter attacker = new BaseCharacter("Test1");

            BaseCharacter defender = new BaseCharacter("Test2");

            int roll = 1;

            Combat TestFight = new Combat(attacker, defender);

            bool result = TestFight.Attack(roll);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Attack_CharacterCanCrit_ReturnsEqualInt()
        {
            //Testing a character can have a critical hit (double damage)

            BaseCharacter attacker = new BaseCharacter("Test1");

            BaseCharacter defender = new BaseCharacter("Test2");

            int roll = 20;

            Combat TestFight = new Combat(attacker, defender);

            TestFight.Attack(roll);

            int result = defender.HitPoints;

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Attack_CharacterModAffectsAttack_ReturnsTrue()
        {
            //Testing a character modifer will affect an attack roll correctly, default AC is 10, with modifier roll should be 10+1

            BaseCharacter attacker = new BaseCharacter("Test1", Strength: 12);

            BaseCharacter defender = new BaseCharacter("Test2");

            int roll = 11;

            Combat TestFight = new Combat(attacker, defender);

            bool result = TestFight.Attack(roll);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Attack_CharacterModAffectsAttack_ReturnsFalse()
        {
            //Testing a character modifer will affect defense against an attack roll correctly, default AC is 10, with modifier AC should be 10+1

            BaseCharacter attacker = new BaseCharacter("Test1");

            BaseCharacter defender = new BaseCharacter("Test2", Dexterity: 12);

            int roll = 11;

            Combat TestFight = new Combat(attacker, defender);

            bool result = TestFight.Attack(roll);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CharacterStatus_CharacterCanDie_ReturnsEqualString()
        {
            //Testing a character can die, attacker has a +4 Strength modifier for a total of 5 damage, which should bring the defenders HP to 0

            BaseCharacter attacker = new BaseCharacter("Test1", Strength: 18);

            BaseCharacter defender = new BaseCharacter("Test2");

            int roll = 11;

            Combat TestFight = new Combat(attacker, defender);

            TestFight.Attack(roll);

            string result = TestFight.CharacterStatus();

            string expected = $"{defender.Name} has perished!";

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void CharacterStatus_CharacterCanDie_ReturnsFalse()
        {
            //Testing a character can die, attacker has a +4 Strength modifier for a total of 5 damage, which should bring the defenders HP to 0
            //Character property "Alive" should return false

            BaseCharacter attacker = new BaseCharacter("Test1", Strength: 18);

            BaseCharacter defender = new BaseCharacter("Test2");

            int roll = 11;

            Combat TestFight = new Combat(attacker, defender);

            TestFight.Attack(roll);

            bool result = defender.Alive;

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void GainXP_CharacterCanGainXP_ReturnsEqualInt()
        {
            //Testing XP increments properly

            BaseCharacter attacker = new BaseCharacter("Test1");

            BaseCharacter defender = new BaseCharacter("Test2");

            int roll = 11;

            Combat TestFight = new Combat(attacker, defender);

            TestFight.Attack(roll);

            Assert.AreEqual(10, attacker.XP);
        }

        [TestMethod]
        public void GainXP_CharacterCanLevelUp_ReturnsEqualInt()
        {
            BaseCharacter attacker = new BaseCharacter("Test1", XP : 990);

            BaseCharacter defender = new BaseCharacter("Test2");

            int roll = 11;

            Combat TestFight = new Combat(attacker, defender);

            TestFight.Attack(roll);

            Assert.AreEqual(2, attacker.Level);
        }
    }
}

