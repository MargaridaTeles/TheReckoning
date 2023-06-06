using System.Collections.Generic;

namespace TheReckoning
{
    /// <summary>
    /// Interface da View
    /// </summary>
    public interface IView
    {
        int MainMenu();

        void InvalidOption();

        void Tutorial();
        void Start(List<Player> players);
    }
}