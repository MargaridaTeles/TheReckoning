using System.Collections.Generic;

namespace TheReckoning
{
    public interface IView
    {
        int MainMenu();

        void InvalidOption();

        void ShowCards(IEnumerable<Carta> cartas);

        void Tutorial();
        void Start(List<Player> players, List<Carta> list);
    }
}