﻿using EverCraft_CORE;

namespace EverCraft_UnitTests
{
    [TestClass]
    public class CombatTests
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

    }
}

