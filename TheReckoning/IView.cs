using System.Collections.Generic;

namespace TheReckoning
{
    public interface IView
    {
        int MainMenu();

        void InvalidOption();

        void ShowCards(IEnumerable<Carta> cartas);
        void ShowRandomCards(List<Carta> list, List<Player> listplayers);
    }
}