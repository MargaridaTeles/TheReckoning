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
    }
}