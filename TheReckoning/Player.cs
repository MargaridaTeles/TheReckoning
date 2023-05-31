using System;
using System.Collections.Generic;


namespace TheReckoning
{
    public class Player
    {
        public string Name { get; }
        public int HP { get; }
        public int MP { get; }
        public List<Carta> Deck;

        public Player(string name, int hp, int mp, List<Carta> deck)
        {
            Name = name;
            HP = hp;
            MP = mp;
            Deck = deck;
        }

        static void Shuffle(List<Carta> deck)
        {
            Random random = new Random();
            for(int i = deck.Count - 1; i > 0; i --)
            {
                int k = random.Next(i +1);
                Carta temp = deck[i];
                deck[i] = deck[k];
                deck[k] = temp;
            }
            List<Carta> list = deck.GetRange(0,6);
        }

        public override string ToString()
        {
            return $"{Name}/{HP}/{MP}";
        }
        
    }
}