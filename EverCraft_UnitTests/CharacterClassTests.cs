using System;
using EverCraft_CORE;

namespace EverCraft_UnitTests
{
	[TestClass]
	public class CharacterClassTests
	{
		[TestMethod]
		public void Classes_BarabarianStatsAreACcurate_ReturnsEqualInt()
		{
			Barbarian Test = new Barbarian("Test");

			int result = Test.Strength;

			Console.WriteLine(result);

			int expected = 12;

			Assert.AreEqual(expected, result);
		}
	}
}

