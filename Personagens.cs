using System;

namespace jogo
{
    class Personagens
    {
        public string Nome { get; private set; }

        public int Vida {get; private set; }

        public int Dano {get; private set; }

         public Personagens(string nome, int vida, int dano)
        {
            this.Nome = nome;
            this.Vida = vida;
            this.Dano = dano;
        }
        
        Atacar()
        {

        }

        ReceberDano(int dano)
        {
            Vida -= dano;
        }
    }

    class Jogador : Personagens
    {
        int sorte = 0; 

        public Jogador(string nome)
            : base(nome, 100, 15)
        {
        }
    }
}