using System;
using System.Collections.Generic;

namespace TheReckoning
{
    public class Controller
    {
        private List<Carta> list1;
        private List<Carta> list2;
        private IView view;

        public Controller(List<Carta> list1, List<Carta> list2)
        {
            this.list1 = list1;
            this.list2 = list2;
        }
        public void Run(IView view)
        {
            List<Player> playerlist = new List<Player>()
            {
                //Inserir Jogadores
                new Player("Jogador1", 10, 0, Shuffle(list1)),
                new Player("Jogador2", 10, 0, Shuffle(list2)),
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
                        view.ShowCards(playerlist[0].Deck_cartas);  
                        break;
                    case 3:
                        view.Start(playerlist);
                        break;
                    case 3:
                        SortPlayers();
                        ShowPlayersWithScore();
                        break;*/
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

        // Mostrar qual a carta que está em primeiro e guardar na "Mão" do player
        public List<Carta> Draw(List<Carta> shuffledDeck)
        {
            List<Carta> playerHand = new List<Carta>();
            while(playerHand.Count < 6)
            {
                playerHand.Add(shuffledDeck[0]);
                shuffledDeck.Remove(shuffledDeck[0]);
            }
            return playerHand;
        }
    }
}