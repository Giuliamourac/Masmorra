using System;

namespace jogo
{
    class Characters
    {
        private string name { get; set; }

        private int health {get; set; }

        private int strength {get; set; }

        public string Name => name;
        public int Health => health;
        public int Strength => strength;


         public Characters(string name, int health, int strength)
        {
            this.name = name;
            this.health = health;
            this.strength = strength;
        }
        
    }

    class Player(string name, int health, int strength, int defense, int luck) : Characters( name, health , strength)
    {
        private int Defense { get; set; } = defense;
        private int Luck { get; set; } = luck;
    }
}