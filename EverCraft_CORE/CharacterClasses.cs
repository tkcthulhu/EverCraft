using System;
namespace EverCraft_CORE
{
	public class Barbarian : BaseCharacter
	{
		public Barbarian(string Name) : base(Name: Name)
		{
			this.Strength = this.Strength + 2;
			this.Constitution = this.Constitution + 2;
            this.HitPoints = this.BaseHitPoints + this.Modifier(Constitution);
        }
	}
}

