using System;

namespace jogo
{
    class Characters
    {
        private string Name { get; set; }

        private int Health {get; set; }

        private int Strength {get; set; }

         public Characters(string name, int health, int strength)
        {
            this.Name = name;
            this.Health = health;
            this.Strength = strength;
        }
        
    }

    class Player(string name, int health, int strength, int defense, int luck) : Characters( name, health , strength)
    {
        private int Defense { get; set; } = defense;
        private int Luck { get; set; } = luck;
    }
}