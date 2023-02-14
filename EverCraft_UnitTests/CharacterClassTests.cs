using System;
using EverCraft_CORE;

namespace EverCraft_UnitTests
{
	[TestClass]
	public class CharacterClassTests
	{
		[TestMethod]
		public void Classes_BarabarianStatsAreAccurate_ReturnsEqualInt()
		{
			Barbarian Test = new Barbarian("Test");

			int result = Test.Strength;

			int expected = 12;

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Classes_BarbarianStatsAreAccurate2_ReturnsEqualInt()
		{
            Barbarian Test = new Barbarian("Test");

            int result = Test.Constitution;

            int expected = 12;

            Assert.AreEqual(expected, result);
        }
	}
}

