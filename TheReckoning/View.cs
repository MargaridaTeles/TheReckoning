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

        public void ShowRandomCards(List<Carta> list, List<Player> players)
        {
            /*Random random = new Random();
            for(int i = list.Count - 1; i > 0; i --)
            {
                int k = random.Next(i +1);
                Carta temp = list[i];
                list[i] = list[k];
                list[k] = temp;
            }*/
            foreach(Player p in players)
            {
                Console.WriteLine("");
                Console.WriteLine($"Player:{p.Name}");
                Console.WriteLine($"Deck:");
                foreach(Carta c in p.Deck)
                {
                    Console.WriteLine(c);
                }
            }
        }
        public int MainMenu(Carta carta)
        {
            throw new NotImplementedException();
        }
    }
}