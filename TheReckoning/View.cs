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
            Console.WriteLine("9. How To Play ");
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

        public void ShowDeck(List<Carta> list, List<Player> players)
        {
            foreach(Player p in players)
            {
                Console.WriteLine($"\nDeck {p.Name}:");
                var deck = new List<Carta>();
                Deck.Shuffle(deck, list);
                foreach(Carta c in deck)
                {
                    Console.WriteLine($"{c.Name}");
                }
                
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

        }

        public void Tutorial()
        {

            Console.WriteLine("\n Welcome to The Reckoning! ");
            Console.WriteLine("\n In this game you will have a deck of cards containing powerfull creatures that will battle against eachother! ");
            Console.WriteLine("What would you like to learn first? \n: 1 - Battle \n: How to win ");
            Console.ReadLine();

        }

        public int MainMenu(Carta carta)
        {
            throw new NotImplementedException();
        }
    }
}
