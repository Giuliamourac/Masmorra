using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace jogo
{
    class Masmorra
    {
        static Characters[] enemies =
        {
            new("Maneba", 250, 14),
            new("Jaggedjaw", 350, 30),
            new("Guard", 325, 40),
            new("Elite guard", 575, 37),
            new("Cavegnome", 100, 10),
            new("Priest", 175, 28),
            new("Lizardman", 425, 30),
            new("Night lurch", 420, 20),
            new("Cavedweller", 350, 25),
            new("Yellow mage", 420, 45),
            new("Miner Spectre", 450, 15)
        };
        static void Main(string[] args)
        {
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
            Console.Clear();

            Console.WriteLine("Welcome to Fear & Hunger.\nA place where hope rots faster than flesh.\nEvery step is a gamble, every choice a wound.\nSurvive, or be forgotten in the dark...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Before you stands the Dungeon of Fear & Hunger.\n The air is stale. Something within watches you in silence.\nOnce you step inside, there will be no comfort. No mercy. No turning back."); 

            string enterDungeon;

            do
            {
                Console.WriteLine("Do you wish to enter? \n(Y/N)");
                enterDungeon = Console.ReadLine()!.ToLower();
            }
            while(enterDungeon != "y" && enterDungeon != "n");

            Console.Clear();
            
            if(enterDungeon == "n")
            {
                notEnterdungeon();
            }
            else
            {
                Console.WriteLine("You step into the Dungeon of Fear & Hunger.\nThe darkness swallows you almost immediately.\nThe air is damp. Breathing feels heavier here.\nYour instincts tell you to act quickly.\n");
        
                bool whatllYouDo = false;
                int optionWhatllYouDo = 0;

                do
                {
                    Console.WriteLine(@"What will you do?
                    1. Move forward
                    2. Move right
                    3. Move left
                    4. Do nothing");

                    whatllYouDo = int.TryParse(Console.ReadLine(), out optionWhatllYouDo);

                    if(!whatllYouDo || optionWhatllYouDo < 1 || optionWhatllYouDo > 4)
                    {
                        Console.WriteLine("Choose a valid option: \n");
                    }
                }
                while (!whatllYouDo || optionWhatllYouDo < 1 || optionWhatllYouDo > 4);

                switch(optionWhatllYouDo)
                {
                    case 1:
                    MoveForward();
                    break;
                    case 2:
                    MoveRight();
                    break;
                    case 3:
                    MoveLeft();
                    break;
                    case 4:
                    DoNothing();
                    break;
                } 
            }   
        }

        public static void notEnterdungeon()
        {
            Console.Clear();
            Console.WriteLine("You turn away from the dungeon.\nThe ground shifts behind you. Low growls break the silence.\nJaggedjaws emerge from the shadows — three of them.\nStarved. Watching.\nThere is no escape...\n");
            Console.ReadKey();
        }

        public static void MoveForward()
        {
            Console.Clear();
            Console.WriteLine("Heavy footsteps echo down the corridor.\nA Guard steps into the light, weapon already raised.\nThere will be no negotiation.");

            Characters enemy = enemies[2];
            ShowEnemy(enemy);
        }

        public static void MoveRight()
        {
            
        }

        public static void MoveLeft()
        {
            
        }

        public static void DoNothing()
        {
            
        }

        public static void ShowEnemy(Characters enemy)
        {
            Console.WriteLine($"\n--- {enemy.Name} ---");
            Console.WriteLine($"Health: {enemy.Health}");
            Console.WriteLine($"Strength: {enemy.Strength}");
        }

    }
}