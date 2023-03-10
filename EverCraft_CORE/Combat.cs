using System;
namespace EverCraft_CORE
{
	public class Combat
	{
		public BaseCharacter Attacker
		{ get; private set; }

		public BaseCharacter Defender
		{ get; private set; }

		public Combat(BaseCharacter Attacker, BaseCharacter Defender)
		{
			this.Attacker = Attacker;

			this.Defender = Defender;
		}

		public bool Attack(int roll)
		{
			int attackerMod = Attacker.DamageModifier;

			int defenderMod = Defender.DefenseModifier;

			int damage = 1 + attackerMod;

			if (roll == 20)
			{
				Defender.TakeDamage(damage * Attacker.CritMultiplier);
				Attacker.GainXP();
				return true;
			} else if ((attackerMod + roll) > (Defender.ArmorClass + defenderMod)) {
				Defender.TakeDamage(damage);
				Attacker.GainXP();
				return true;
			} else
			{
				return false;
			}
		}

		public string CharacterStatus()
		{
			if (Defender.HitPoints <= 0)
			{
				return $"{Defender.Name} has perished!";
			}

			return "Next players turn!";
		}
		
	}
}

