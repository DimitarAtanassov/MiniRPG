using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPG.Classes
{
    public abstract class Character
    {

        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        protected Weapon Weapon { get; set; }
        public Inventory Inventory { get; set; }

        protected abstract void RegularAttack(Character target);
        public abstract void SpecialAttack(Character target);
        public abstract void Heal();
        public abstract void TakeTurn(Character target);  

    }
}
