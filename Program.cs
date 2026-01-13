using System;

namespace jogo
{
    class Masmorra
    {
        static void Main(string[] args)
        {
            Personagens loboCinzento = new Personagens("Lobo Cinzento", 3, 3);

            Personagens loboBranco = new Personagens("Lobo Branco", 3, 3);

            Personagens goblin = new Personagens("Goblin", 4, 5);

            Personagens orcVesgo = new Personagens("Orc Vesgo", 5, 5);

            Personagens orcBarbudo = new Personagens("Goblin", 5, 5);

            Personagens zumbiManco = new Personagens("Zumbi Manco", 7, 6);

            Personagens zumbiBalofo = new Personagens("Zumbi Balofo", 7, 6);

            Personagens troll = new Personagens("Troll", 7, 8);

            Personagens ogro = new Personagens("Ogro", 9, 8);

            Personagens ogroFurioso = new Personagens("Ogro Furioso", 9, 10);

            Personagens necromanteMaligno = new Personagens("Necromante Maligno", 12, 12);

            string nome;
            
            Console.Write(@"Bem-vindo(a) a Masmorra!
            Digite seu nome para proseguirmos:");

            nome = Console.ReadLine()!;
            Jogador jogador = new Jogador(nome);

            Console.WriteLine("Jogador criado com sucesso! Pressione uma tecla para prosseguir...");
            Console.ReadKey();
        }
    }
}