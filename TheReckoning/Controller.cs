using System.Collections.Generic;

namespace TheReckoning
{
    public class Controller
    {
        private List<Carta> list;
        private List<Player> playerlist;
        private IView view;

        public Controller(List<Carta> list, List<Player> playerlist)
        {
            this.list = list;
            this.playerlist = playerlist;
        }
        public void Run(IView view)
        {
            int input;
            this.view = view;
            do
            {
                // 1 -> Insert player
                // 2 -> List all players
                // 3 -> List players w/ score > x
                // 4 -> Change player sorting criteria
                // 0 -> Exit
                input = view.MainMenu();

                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        view.ShowCards(list);
                        break;
                    case 2:
                        view.ShowDeck(list, playerlist);
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
                        break;
                    case 4:
                        ChangePlayerOrder();
                        break;*/
                    default:
                        view.InvalidOption();
                        break;
                }
            }
            while (input != 0);
        }
    }
}