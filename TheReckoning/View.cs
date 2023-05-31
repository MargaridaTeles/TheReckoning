using System;
using System.Collections.Generic;

namespace TheReckoning
{
    public class View : IView
    {
        // This view doesn't actually need a reference to the controller,
        // but generally views will need it
        private readonly Controller controller;

        public View(Controller controller)
        {
            this.controller = controller;
        }

        public int MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1. Show Cards");
            Console.WriteLine("2. Random Cards");
            Console.WriteLine("0. Exit");
            Console.WriteLine("");
            Console.Write("> ");

            return int.Parse(Console.ReadLine());
        }

        public void InvalidOption()
        {
            /*Console.WriteLine("\nInvalid option! Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();*/
        }

        public void ShowCards(IEnumerable<Carta> cartas)
        {
            Console.WriteLine();
            foreach (Carta c in cartas)
            {
                Console.WriteLine($"-> {c}");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }

        public void ShowRandomCards()
        {
            //TESTE
            for(int i = 0; i < 6; i++)
            {
                Random random = new Random();
                int cartas_random = random.Next(0, 19);
                Console.WriteLine($"{cartas_random}");
            }
        }

        public int MainMenu(Carta carta)
        {
            throw new NotImplementedException();
        }
    }
}