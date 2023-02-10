using System;
namespace EverCraft_CORE
{
	public class Barbarian : BaseCharacter
	{
		public Barbarian() : base()
			{
				this.Strength = this.Strength + 2;
				this.Constitution = this.Constitution + 2;
			}
	}
}

