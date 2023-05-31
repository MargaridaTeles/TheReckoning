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
                new Carta("Pedro", 50, 25, 26),
                new Carta("Verde", 42, 50, 20),
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
