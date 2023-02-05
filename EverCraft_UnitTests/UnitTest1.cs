using EverCraft_CORE;

namespace EverCraft_UnitTests;

[TestClass]
public class BaseCharacterTests
{

    [TestMethod]
    public void SetName_CharacterCanBeNameed_ReturnsEqualString()
    {
        string name = "Testing";

        BaseCharacter Test = new BaseCharacter(name);

        string result = Test.Name;

        Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetLevel_CharacterCanSetLevel_ReturnsequalInt()
    {
        string name = "Testing";

        //Testing with optional argument
        BaseCharacter Test = new BaseCharacter(name);

        int result = Test.Level;

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void SetLevel_CharacterCanSetLevel2_ReturnsequalInt()
    {
        string name = "Testing";

        //Testing with named argument
        BaseCharacter Test = new BaseCharacter(name, Level: 2);

        int result = Test.Level;

        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void SetStats_CharacterCanSetStrength_ReturnsEqualInt()
    {
        int stat = 12;

        BaseCharacter Test = new BaseCharacter("Test", Strength: stat);

        int result = Test.Strength ;

        Assert.AreEqual(stat, result);
    }

    [TestMethod]
    public void SetStats_CharacterCanSetDexterity_ReturnsEqualInt()
    {
        int stat = 12;

        BaseCharacter Test = new BaseCharacter("Test", Dexterity: stat);

        int result = Test.Dexterity ;

        Assert.AreEqual(stat, result);
    }

    [TestMethod]
    public void SetStats_CharacterCanSetConstitution_ReturnsEqualInt()
    {
        int stat = 12;

        BaseCharacter Test = new BaseCharacter("Test", Constitution: stat);

        int result = Test.Constitution ;

        Assert.AreEqual(stat, result);
    }

    [TestMethod]
    public void SetStats_CharacterCanSetIntelligence_ReturnsEqualInt()
    {
        int stat = 12;

        BaseCharacter Test = new BaseCharacter("Test", Intelligence: stat);

        int result = Test.Intelligence ;

        Assert.AreEqual(stat, result);
    }

    [TestMethod]
    public void SetStats_CharacterCanSetWisdom_ReturnsEqualInt()
    {
        int stat = 12;

        BaseCharacter Test = new BaseCharacter("Test", Wisdom: stat);

        int result = Test.Wisdom ;

        Assert.AreEqual(stat, result);
    }

    [TestMethod]
    public void SetStats_CharacterCanSetCharisma_ReturnsEqualInt()
    {
        int stat = 12;

        BaseCharacter Test = new BaseCharacter("Test", Charisma: stat);

        int result = Test.Charisma ;

        Assert.AreEqual(stat, result);
    }

    [TestMethod]
    public void CheckModifier_LevelReturnsAppropriateModifier_ReturnsEqualInt()
    {
        int stat = 15;

        double expected = (stat - 10) / 2;

        expected = Math.Floor(expected);

        BaseCharacter Test = new BaseCharacter("Test", Dexterity: stat);

        int result = Test.Modifier(Test.Dexterity);

        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void SetStats_CharacterHasHP_ReturnsDefualt()
    {
        int Default = 5;

        BaseCharacter Test = new BaseCharacter("Test", HitPoints: Default);

        int result = Test.HitPoints;

        Assert.AreEqual(Default, result);
    }

    [TestMethod]
    public void StatCheck_CharacterHasArmorClass_Returns10()
    {
        BaseCharacter Test = new BaseCharacter("Test");

        int expected = 10;

        int result = Test.ArmorClass;

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TakeDamage_CharacterCanBeDamaged_ReturnsEqualInt()
    {
        BaseCharacter Test = new BaseCharacter("Test");

        int hit = 2;

        int expected = Test.HitPoints - hit;

        int result = Test.TakeDamage(hit);

        Assert.AreEqual(expected, result);
    }
}
