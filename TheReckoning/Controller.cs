using System;
using System.Collections.Generic;

namespace TheReckoning
{
    public class Controller
    {
        private List<Carta> list;
      
        private IView view;

        public Controller(List<Carta> list)
        {
            this.list = list;
        }
        public void Run(IView view)
        {
            List<Player> playerlist = new List<Player>()
            {
                //Inserir Jogadores
                new Player("Jogador1", 10, 0, Shuffle(list)),
                new Player("Jogador2", 10, 0, Shuffle(list)),
            };

            int input;
            this.view = view;
            do
            {
                // 1 -> Mostrar Cartas do jogo
                // 3 -> Iniciar Jogo
                // 9 -> Tutorial
                // 0 -> Exit
                input = view.MainMenu();

                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        view.ShowCards(list);
                        break;
                    case 3:
                        view.Start(playerlist, list);
                        break;
                    /*case 1:
                        InsertPlayer();
                        break;
                    case 2:
                        SortPlayers();
                        view.ShowPlayers(list);
                        break;
                    case 3:
                        SortPlayers();
                        ShowPlayersWithScore();
                        break;*/
                    case 4:
                        view.Tutorial();
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
            }
            while (input != 0);
        }

        public static List<Carta> Shuffle(List<Carta> deck)
        {
            List<Carta> shuffledDeck = new List<Carta>();

            Random random = new Random();
            int n = deck.Count;
            while(n>1)
            {
                n--;
                int k = random.Next(n+1);
                Carta value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
            shuffledDeck = deck;
            
            return shuffledDeck;
            
        }
    }
}