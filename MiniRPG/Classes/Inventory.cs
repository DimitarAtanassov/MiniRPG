using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPG.Classes
{
    public class Inventory
    {
        private List<string> items;

        public Inventory()
        {
            items = new List<string>(); 
        }

        public void AddItem(string item)
        {
            this.items.Add(item);
            Console.WriteLine($"{item} has been added to inventory.");
        }

        public bool UseItem(string item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"{item} used.");
                return true;
            }
            else
            {
                Console.WriteLine($"{item} not found in inventory.");
                return false;
            }

        }

        public void ListItems()
        {
            Console.WriteLine("Inventory contains:");
            foreach (var item in items)
            {
                Console.WriteLine($"-{item}");
            }
        }
    }
}
