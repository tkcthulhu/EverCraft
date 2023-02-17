using System;
namespace EverCraft_CORE
{
	public class Barbarian : BaseCharacter
	{
		public bool IsRaging
		{ get; set; }

		public int RageDamageBonus
		{ get; protected set; }

		public int RageStatBonus
		{ get; protected set; }

		public int RageArmorClassDownGrade
		{ get; protected set; }

		public int BaseStrength
		{ get; protected set; }

		public int BaseConstitution
		{ get; protected set; }

		public int BaseArmorClass
		{ get; protected set; }

		public Barbarian(string Name) : base(Name: Name)
		{
			this.BaseStrength = this.Strength + 2;
			this.Strength = this.BaseStrength;
			this.BaseConstitution = this.Constitution + 2;
			this.Constitution = this.BaseConstitution;
			this.BaseArmorClass = this.ArmorClass;
            this.HitPoints = this.BaseHitPoints + this.Modifier(Constitution);
			this.RollModifier = this.Modifier(Strength);
			this.RageDamageBonus = 2;
			this.RageStatBonus = 4;
			this.RageArmorClassDownGrade = 2;
        }

		public void Raging(bool raging)
		{
			if(raging)
			{
				this.Strength = this.BaseStrength + this.RageStatBonus;
				this.Constitution = this.BaseConstitution + this.RageStatBonus;
				this.ArmorClass = this.BaseArmorClass - this.RageArmorClassDownGrade;
			}
		}
	}
}

