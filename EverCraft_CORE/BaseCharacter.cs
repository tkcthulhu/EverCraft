namespace EverCraft_CORE;

public class BaseCharacter
{
    public string Name
    { get; private set; }

    public int Level
    { get; private set; }

    public int ArmorClass
    { get; private set; }

    public int Strength
    { get; private set; }

    public int Dexterity
    { get; private set; }

    public int Constitution
    { get; private set; }

    public int Intelligence
    { get; private set; }

    public int Wisdom
    { get; private set; }

    public int Charisma
    { get; private set; }

    public int HitPoints
    { get; private set; }

    public BaseCharacter
        (
        string Name,
        int Level = 1,
        int ArmorClass = 10,
        int Strength = 10,
        int Dexterity = 10,
        int Constitution = 10,
        int Intelligence = 10,
        int Wisdom = 10,
        int Charisma = 10,
        int HitPoints = 5
        )
    {
        this.Name = Name;
        this.Level = Level;
        this.ArmorClass = ArmorClass;
        this.Strength = Strength;
        this.Dexterity = Dexterity;
        this.Constitution = Constitution;
        this.Intelligence = Intelligence;
        this.Wisdom = Wisdom;
        this.Charisma = Charisma;
        this.HitPoints = HitPoints;
    }

    public int Modifier(int stat)
    {
        double StatMod = (stat - 10) / 2;

        StatMod = Math.Floor(StatMod);

        int ModFinal = (int) StatMod;

        return ModFinal;

    }

    public int TakeDamage(int hit)
    {
        this.HitPoints = this.HitPoints - hit;

        return this.HitPoints;
    }

}

