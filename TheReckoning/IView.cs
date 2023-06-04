using System.Collections.Generic;

namespace TheReckoning
{
    public interface IView
    {
        int MainMenu();

        void InvalidOption();

        void Tutorial();
        void Start(List<Player> players);
    }
}