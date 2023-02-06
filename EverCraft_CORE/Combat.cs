﻿using System;
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
			int attackerMod = Attacker.Dexterity;

			int defenderMod = Defender.Dexterity;

			int damage = 1;

			if (roll == 20)
			{
				Defender.TakeDamage(damage * 2);
				return true;
			} else if ((attackerMod + roll) > (Defender.ArmorClass + defenderMod)) {
				Defender.TakeDamage(damage);
				return true;
			} else
			{
				return false;
			}
		}
		
	}
}

