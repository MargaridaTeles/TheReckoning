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
                // 3 -> Iniciar Jogo
                // 9 -> Tutorial
                // 0 -> Exit
                input = view.MainMenu();
                switch (input)
                {
                    case 0:
                        break;
                    case 3:
                        view.Start(playerlist);
                        break;
                    case 9:
                        view.Tutorial();
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
            }
            while (input != 0);
        }

        // Mostrar qual a carta que está em primeiro e guardar na "Mão" do player
        public List<Carta> Draw(List<Carta> shuffledDeck)
        {
            return shuffledDeck;
        }

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