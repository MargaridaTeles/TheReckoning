using System;
using System.Collections.Generic;


namespace TheReckoning
{
    public class Player
    {
        public string Name { get; }
        public int HP { get; set;}
        public int MP { get; set; }
        public List<Carta> HandPlayer {get; set;}
        public Queue<Carta> ChoosenCards {get; set;}

        public List<Carta> Deck = new List<Carta>()
        {
            new Carta("Flying Wand", 1, 1, 1),
            new Carta("Flying Wand", 1, 1, 1),
            new Carta("Flying Wand", 1, 1, 1),
            new Carta("Flying Wand", 1, 1, 1),

            new Carta("Severed Monkey Head", 1, 2, 1), 
            new Carta("Severed Monkey Head", 1, 2, 1), 
            new Carta("Severed Monkey Head", 1, 2, 1), 
            new Carta("Severed Monkey Head", 1, 2, 1),

            new Carta("Mystical Rock Wall", 2, 0, 5),
            new Carta("Mystical Rock Wall", 2, 0, 5),

            new Carta("Lobster McCrabs", 2, 1, 3),
            new Carta("Lobster McCrabs", 2, 1, 3),

            new Carta("Goblin Troll", 3, 3, 2),
            new Carta("Goblin Troll", 3, 3, 2),

            new Carta("Scorching Heatwave", 4, 5, 3),
            new Carta("Blind Minotaur", 3, 1, 3),
            new Carta("Tim, The Wizard", 5, 6, 4),
            new Carta("Sharply Depressed", 4, 3, 3),

            new Carta("Blue Steel", 2, 2, 2),
            new Carta("Blue Steel", 2, 2, 2),
        };

        private static List<Carta> Shuffle(List<Carta> deck)
        {
            List<Carta> shuffledDeck = new List<Carta>();

            Random random = new Random();
            int n = deck.Count;
            while(n>1)
            {
                n--;
                int k = random.Next(n+1);
                Carta value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
            shuffledDeck = deck;

            return shuffledDeck;
        }

        public Player(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
            HandPlayer = new List<Carta>();
            ChoosenCards = new Queue<Carta>();
            Deck = Shuffle(Deck);

            for(int i=0; i < 6; i++)
            {
                Carta c = Deck[0];
                HandPlayer.Add(c);
                Deck.Remove(c);
            }
        }

        public override string ToString()
        {
            return $"{Name}/{HP}/{MP}";
        }
        
    }
}