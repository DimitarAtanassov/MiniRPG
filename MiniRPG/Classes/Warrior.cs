using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MiniRPG.Classes
{
    public class Warrior : Player
    {
        public Warrior(string name, Weapon weapon) : base(name, weapon, 5) { }
        protected override void RegularAttack(Character target)
        {
            Console.WriteLine($"{Name} attacks with {Weapon.Name}!");
            int damage = Dice.Roll() + Weapon.weaponDMG();
            target.Health -= damage;
            Console.WriteLine($"{target.Name} takes {damage} damage.");

        }

        public override void SpecialAttack(Character target)
        {
            Console.WriteLine($"{Name} uses Power Strike!");
            int damage = Dice.Roll() * 2 + Weapon.weaponDMG();
            target.Health -= damage;
            Console.WriteLine($"{target.Name} takes {damage} damage.");
        }

        public override void Heal()
        {
            if (Inventory.UseItem("HP Potion"))
            {
                Health += 3;
                Console.WriteLine($"{Name} heals for 3 HP.");
            }
            else
            {
                Console.WriteLine($"{Name} has no HP Potions left!");
            }
        }

        public override void TakeTurn(Character target)
        {
            Console.WriteLine($"{Name}'s turn:");
            int roll = Dice.Roll();
            if (roll > 3)
            {
                RegularAttack(target);
            }
            else if (roll > 1)
            {
                SpecialAttack(target);
            }
            else
            {
                Heal();
            }
        }
    }
}
