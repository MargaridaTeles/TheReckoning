using System;
using System.Collections.Generic;

namespace TheReckoning
{
    public class Controller
    {
        private IView view;

        public Controller()
        {
        }
        /// <summary>
        /// Corre as views todas
        /// </summary>
        /// <param name="view"></param>
        public void Run(IView view)
        {
            List<Player> playerlist = new List<Player>()
            {
                //Inserir Jogadores
                new Player("Jogador1", 10, 0),
                new Player("Jogador2", 10, 0),
            };

            int input;
            this.view = view;
            do
            {
                // 1 -> Iniciar Jogo
                // 2 -> Tutorial
                // 0 -> Exit
                input = view.MainMenu();
                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        view.Start(playerlist);
                        break;
                    case 2:
                        view.Tutorial();
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
            }
            while (input != 0);
        }
        /// <summary>
        /// Corre todas as cartas existentes
        /// </summary>
        /// <param name="shuffledDeck">Lista de cartas existentes no Deck</param>
        /// <returns></returns>
        public List<Carta> Draw(List<Carta> shuffledDeck)
        {
            return shuffledDeck;
        }
        /// <summary>
        /// Verifica se os players tem HP e se ainda tem cartas no deck
        /// após isso finaliza o jogo
        /// </summary>
        /// <param name="players">Busca a lista de players</param>
        /// <param name="winner">Booleana usada para finalizar loop</param>
        public void FinishGame(List<Player> players, bool winner)
        {
            if(players[0].HP <= 0 || players[1].HP <= 0)
            {
                winner = true;
                Console.WriteLine("O jogo terminou");
                Environment.Exit(0);
            }
            if(players[0].Deck.Count <= 0)
            {
                if(players[0].HP > players[1].HP)
                {
                    Console.WriteLine($"Quem venceu foi o {players[0].Name}");
                }
                else if(players[0].HP < players[1].HP)
                {
                    Console.WriteLine($"Quem venceu foi o {players[1].Name}");
                }
                winner = true;
                Console.WriteLine($"Quem venceu foi o {players[1].Name}");
                Environment.Exit(0);
            }
            else if (players[1].Deck.Count <= 0)
            {   
                if(players[1].HP > players[0].HP)
                {
                    Console.WriteLine($"Quem venceu foi o {players[1].Name}");
                }
                else if(players[1].HP < players[0].HP)
                {
                    Console.WriteLine($"Quem venceu foi o {players[0].Name}");
                }
                winner = true;
                Console.WriteLine($"Quem venceu foi o {players[0].Name}");
                Environment.Exit(0);
            }
        }
    }
} 