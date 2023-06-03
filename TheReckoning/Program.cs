using System;
using System.Collections.Generic;


namespace TheReckoning
{
    class Program
    {

        private static void Main()
        {

            // Create controller
            Controller controller = new Controller();

            // Create view
            IView view = new View(controller);

            // Start program
            controller.Run(view);
        }
        
    }
}
