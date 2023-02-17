using System;
using EverCraft_CORE;

namespace EverCraft_UnitTests
{
	[TestClass]
	public class BarbarianClassTests
	{
		[TestMethod]
		public void Barabaria_nStatsAreAccurate_ReturnsEqualInt()
		{
			Barbarian Test = new Barbarian("Test");

			int result = Test.Strength;

			int expected = 12;

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Barbarian_StatsAreAccurate2_ReturnsEqualInt()
		{
            Barbarian Test = new Barbarian("Test");

            int result = Test.Constitution;

            int expected = 12;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Barbarian_StatsAreAccurate3_ReturnsEqualInt()
        {
            Barbarian Test = new Barbarian("Test");

            int result = Test.HitPoints;

            int expected = 6;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Barbarian_CanRage_ReturnsTrue()
        {
            Barbarian Test = new Barbarian("Test");

            Test.IsRaging = true;

            Assert.IsTrue(Test.IsRaging);
        }

        [TestMethod]
        public void Barbarian_RageStats1_ReturnsEqualInt()
        {
            Barbarian Test = new Barbarian("Test");

            Test.IsRaging = true;

            Test.Raging();

            int result = Test.Strength;

            int expected = 16;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Barbarian_RageStats2_ReturnsEqualInt()
        {
            Barbarian Test = new Barbarian("Test");

            Test.IsRaging = true;

            Test.Raging();

            int result = Test.Constitution;

            int expected = 16;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Barbarian_RageStats3_ReturnsEqualInt()
        {
            Barbarian Test = new Barbarian("Test");

            Test.IsRaging = true;

            Test.Raging();

            int result = Test.ArmorClass;

            int expected = 8;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Barbarian_RageStatsReturnToBase1_ReturnsEqualInt()
        {
            Barbarian Test = new Barbarian("Test");

            Test.IsRaging = true;

            Test.Raging();

            Test.IsRaging = false;

            Test.Raging();

            int result = Test.Strength;

            int expected = 12;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Barbarian_RageStatsReturnToBase2_ReturnsEqualInt()
        {
            Barbarian Test = new Barbarian("Test");

            Test.IsRaging = true;

            Test.Raging();

            Test.IsRaging = false;

            Test.Raging();

            int result = Test.Constitution;

            int expected = 12;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Barbarian_RageStatsReturnToBase3_ReturnsEqualInt()
        {
            Barbarian Test = new Barbarian("Test");

            Test.IsRaging = true;

            Test.Raging();

            Test.IsRaging = false;

            Test.Raging();

            int result = Test.ArmorClass;

            int expected = 10;

            Assert.AreEqual(expected, result);
        }
    }
}

