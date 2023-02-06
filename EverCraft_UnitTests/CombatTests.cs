using EverCraft_CORE;

namespace EverCraft_UnitTests
{
	[TestClass]
	public class CombatTests
	{
		[TestMethod]
		public void Attack_CharacterCanBeAttacked_ReturnsTrue()
		{
			BaseCharacter attacker = new BaseCharacter("Test1");

			BaseCharacter defender = new BaseCharacter("Test2");

			int roll = 12;

			Combat TestFight = new Combat(attacker, defender);

			bool result = TestFight.Attack(roll);

			Assert.IsTrue(result);
		}
	}
}

