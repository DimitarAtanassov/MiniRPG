using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPG.Classes
{
    public abstract class Player : Character
    {
        public Player(string name, Weapon weapon, int defense)
        {
            this.Name = name;
            this.Health = 50;
            this.Defense = 5;
            this.Weapon = weapon;
            this.Inventory = new Inventory();
        }
    }
}
