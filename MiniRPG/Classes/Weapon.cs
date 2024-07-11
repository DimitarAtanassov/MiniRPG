using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPG.Classes
{
    public class Weapon
    {
        public string Name { get; set; }
        public int minDmg { get; set; }
        public int maxDmg { get; set; }

        public Weapon(string name, int minDmg, int maxDmg) 
        { 
            this.Name = name;
            this.minDmg = minDmg;
            this.maxDmg = maxDmg;
        }

        public int weaponDMG()
        {
            Random rand = new Random();
            int total = rand.Next(this.minDmg,this.maxDmg);
            return total;

        }
    }
}
