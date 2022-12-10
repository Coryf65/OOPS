using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    internal class AttackResult
    {       
        public Character Attacker { get; set; }
        public Character Opponent { get; set; }
        public int Damage { get; set; }

        public AttackResult(Character attacker, Character opponent, int damage)
        {
            Attacker = attacker;
            Opponent = opponent;
            Damage = damage;
        }

    }
}