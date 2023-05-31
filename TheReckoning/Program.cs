using System;
using System.Collections.Generic;


namespace TheReckoning
{
    class Program
    {
        private static void Main()
        {
            
            // List of cartas is our model
            List<Carta> list = new List<Carta>()
            {
                new Carta("Flying Wand", 1, 1, 1, 4),
                new Carta("Severed Monkey Head", 1, 2, 1, 4),
                new Carta("Mystical Rock Wall", 2, 0, 5, 2),
                new Carta("Lobster McCrabs", 2, 1, 3, 1),
                new Carta("Goblin Troll", 3, 3, 2, 2),
                new Carta("Scorching Heatwave", 4, 5, 3, 1),
                new Carta("Blind Minotaur", 3, 1, 3, 1),
                new Carta("Tim, The Wizard", 5, 6, 4, 1),
                new Carta("Sharply Depressed", 4, 3, 3, 1),
                new Carta("Blue Steel", 2, 2, 2, 2),
            };

            // Create controller
            Controller controller = new Controller(list);

            // Create view
            IView view = new View(controller);

            // Start program
            controller.Run(view);
        }
    }
}
