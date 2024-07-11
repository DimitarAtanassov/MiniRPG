# MiniRPG

MiniRPG is a simple console-based role-playing game built in C#. In this game, players can choose a character class (Warrior, Archer, or Mage), equip their character with weapons, and battle against monsters. The game demonstrates fundamental concepts of Object-Oriented Programming (OOP) such as inheritance, polymorphism, encapsulation, and abstraction.

## Features

- Choose from three character classes: Warrior, Archer, and Mage.
- Equip your character with different weapons.
- Engage in turn-based combat with a monster.
- Manage an inventory that includes health potions.

## Classes

### Archer

The Archer class represents a character that uses bows or crossbows. Archers have unique regular and special attacks.

### Character

The Character class is an abstract base class that defines common attributes and methods for all characters in the game.

### Dice

The Dice class provides methods for simulating dice rolls, which are used to determine the outcome of attacks and other actions.

### Inventory

The Inventory class manages the items that a character holds, such as health potions.

### Mage

The Mage class represents a character that uses magical wands or staffs. Mages have unique regular and special attacks.

### Monster

The Monster class represents the enemies that players will face in the game. Monsters have their own attacks and health attributes.

### Player

The Player class is an abstract class derived from Character. It represents the player-controlled characters in the game.

### Warrior

The Warrior class represents a character that uses swords or axes. Warriors have unique regular and special attacks.

### Weapons

The Weapon class defines various weapons that characters can equip.

## How to Play

1. Clone the repository to your local machine.
2. Open the project in Visual Studio.
3. Build and run the project.
4. Follow the on-screen prompts to create a character, choose a weapon, and start the battle.

## Code Structure

```plaintext
MiniRPG/
├── Classes/
│   ├── Archer.cs
│   ├── Character.cs
│   ├── Dice.cs
│   ├── Inventory.cs
│   ├── Mage.cs
│   ├── Monster.cs
│   ├── Player.cs
│   ├── Warrior.cs
│   └── Weapon.cs
├── Program.cs
└── README.md
