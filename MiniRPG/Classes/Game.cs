using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniRPG.Classes
{
    public class Game
    {
        private Player player;
        private Monster monster;
        public void Start()
        {

            CreateCharacter();
            CreateMonster();

            for (int i = 0; i < 4; i++) 
            {
                player.Inventory.AddItem("HP Potion");
            }
            player.Inventory.ListItems();
            Battle();
        }

        private void CreateCharacter()
        {
            Console.WriteLine("Welcome to MiniRPG :D");
            string userName = null;
            
            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("What is your name?: ");
                userName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userName))
                {
                    Console.WriteLine("Name cannot be empty. Please try again");
                }

            }

            Console.WriteLine("Please Select a class:");
            Console.WriteLine("1.) Warrior");
            Console.WriteLine("2.) Archer");
            Console.WriteLine("3.) Mage");
            
            
            bool validChoice = false;
            int choice = 0;
            
            while (!validChoice)
            {
                Console.Write("Enter number corresponding to class: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice) && (choice >= 1 && choice <= 3))
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid Choice. Please choose a number 1 - 3");
                }
            }

            Weapon weapon = SelectWeapon(choice);

            switch (choice)
            {
                case 1:
                    player = new Warrior(userName, weapon); 
                    break;
                
                case 2:
                    player = new Archer(userName, weapon);
                    break;

                case 3:
                    player = new Mage(userName, weapon);
                    break;

            }   
        }

        private Weapon SelectWeapon(int classChoice)
        {
            Console.WriteLine("Select a weapon: ");

            switch(classChoice)
            {
                case 1:
                    Console.WriteLine("1.) Sword");
                    Console.WriteLine("2.) Axe");
                    break;

                case 2:
                    Console.WriteLine("1.) Bow");
                    Console.WriteLine("2.) Crossbow");
                    break;

                case 3:
                    Console.WriteLine("1.) Wand");
                    Console.WriteLine("2.) Stff");
                    break;
            }
            
            bool validChoice = false;
            int choice = 0;

            while (!validChoice)
            {
                Console.WriteLine("Enter number corresponding to your weapon choice: ");
                string userIn = Console.ReadLine();

                if (int.TryParse(userIn, out choice) && (choice >= 1 && choice <= 2))
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid Choice: Please Select a number 1- 2");
                }
            }

            switch (classChoice) 
            {
                case 1:
                    if (choice == 1)
                        return new Weapon("Sword", 5, 10);
                    else
                        return new Weapon("Axe", 5, 10);
                case 2:
                    if (choice == 1)
                        return new Weapon("Bow", 2, 15);
                    else
                        return new Weapon("CrossBow", 2, 15);
                case 3:
                    if (choice == 1)
                        return new Weapon("Wand", 2, 15);
                    else
                        return new Weapon("Staff", 2,15);
                default:
                    return null;
            }
        }

        private void CreateMonster()
        {
            // For simplicity, we'll create a generic monster with a claw weapon.
            Weapon monsterWeapon = new Weapon("Claws", 3, 8);
            monster = new Monster("Goblin", monsterWeapon);
        }

        private void Battle()
        {
            Console.WriteLine("Battle Begin: ");

            while (player.Health > 0 && monster.Health > 0)
            {
                Console.WriteLine($"{player.Name} Health: {player.Health}");
                Console.WriteLine($"{monster.Name} Health: {monster.Health}");
                Thread.Sleep(1000); // Wait for 1 second before the player's turn
                player.TakeTurn(monster);

                if (monster.Health > 0)
                {
                    monster.TakeTurn(monster);
                }
            }

            if (player.Health > 0)
                Console.WriteLine($"{player.Name} wins");
            else Console.WriteLine($"{monster.Name} wins");


        }
    }
}
