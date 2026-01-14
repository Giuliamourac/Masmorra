using System;
using System.Security.Cryptography.X509Certificates;

namespace jogo
{
    class Masmorra
    {
        static void Main(string[] args)
        {

            Characters maneba = new("Maneba", 250, 14);
            
            Characters jaggedjaw = new("Jaggedjaw", 350, 30);

            Characters guard = new("Guard", 325, 40);

            Characters eliteGuard = new("Elite guard", 575, 37);

            Characters cavegnome = new("Cavegnome", 100, 10);

            Characters priest = new("Priest", 175, 28);

            Characters lizardman = new("Lizardman", 425, 30);

            Characters nightLurch = new("Night lurch", 420, 20);

            Characters cavedweller = new("Cavedweller", 350, 25);

            Characters yellowMage = new("Yellow mage", 420, 45);

            Characters minerSpectre = new("Miner Spectre", 450, 15);

            int option = 0;
            bool validOption = false;

            do
            {
                Console.Write(@"Choose your character:
                1. Enki Ankarian. The priest of destruction.
                2. D'arce Cataliss. The trusted knight of the propheticed one.
                3. Ragnvaldr. The outlander.
                4. Cahara. The mercenary. 
                ");

                validOption = int.TryParse(Console.ReadLine(), out option);

                if(!validOption || option < 1 || option > 4)
                {
                    Console.WriteLine("Choose a valid option: \n");
                }
            }
            while (!validOption || option < 1 || option > 4);

            switch(option)
            {
                case 1:
                Player enki = new("Enki", 100, 30, 16, 32);
                StartGame();
                break;
                case 2:
                Player darce = new("D'arce", 100, 30, 16, 32);
                StartGame();
                break;
                case 3:
                Player ragnvaldr = new("Ragnvaldr", 100, 40, 16, 32);
                StartGame();
                break;
                case 4:
                Player cahara = new("Cahara", 100, 30, 16, 32);
                StartGame();
                break;
            } 
           
        }

        public static void StartGame()
        {
            Console.WriteLine("Welcome to Fear & Hunger. A place where hope rots faster than flesh. Every step is a gamble, every choice a wound. Survive, or be forgotten in the dark.");    
        }
    }
}