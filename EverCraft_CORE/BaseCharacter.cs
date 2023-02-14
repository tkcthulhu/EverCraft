namespace EverCraft_CORE;

public class BaseCharacter
{
    public string Name
    { get; protected set; }

    public int Level
    { get; protected set; }

    public int ArmorClass
    { get; protected set; }

    public int Strength
    { get; protected set; }

    public int Dexterity
    { get; protected set; }

    public int Constitution
    { get; protected set; }

    public int Intelligence
    { get; protected set; }

    public int Wisdom
    { get; protected set; }

    public int Charisma
    { get; protected set; }

    public int MaxHitPoints
    { get; protected set; }

    public int BaseHitPoints
    { get; protected set; }

    public int HitPoints
    { get; protected set; }

    public bool Alive
    { get; protected set; }

    public int XP
    { get; protected set; }

    public int CritMultiplier
    { get; protected set; }

    public int RollModifier
    { get; protected set;  }

    public int DamageModifier
    { get; protected set; }

    public int DefenseModifier
    { get; protected set; }

    public int SpellcastingModifier
    { get; protected set; }

    public BaseCharacter
        (
        string Name = "Unknown Adventurer",
        int Level = 1,
        int ArmorClass = 10,
        int Strength = 10,
        int Dexterity = 10,
        int Constitution = 10,
        int Intelligence = 10,
        int Wisdom = 10,
        int Charisma = 10,
        int BaseHitPoints = 5,
        int XP = 0
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
        this.BaseHitPoints = BaseHitPoints;
        this.Alive = true;
        this.XP = XP;
        this.CritMultiplier = 2;
        this.RollModifier = 0;
        this.HitPoints = this.BaseHitPoints + this.Modifier(Constitution);
        this.DamageModifier = this.Modifier(Strength);
        this.DefenseModifier = this.Modifier(Dexterity);
        this.SpellcastingModifier = this.Modifier(Wisdom);
        
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

        if (this.HitPoints <= 0)
        {
            this.HitPoints = 0;
            this.Alive = false;
        }

        return this.HitPoints;
    }

    public int GainXP()
    {
        this.XP += 10;

        double newLevel = this.XP / 1000;

        this.Level = (int)Math.Floor(newLevel + 1);

        return this.Level;
    }

}

