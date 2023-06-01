using System;
using System.Collections.Generic;


namespace TheReckoning
{
    public class Player
    {
        public string Name { get; }
        public int HP { get; }
        public int MP { get; set; }
        public List<Deck> Deck_cartas;

        public Player(string name, int hp, int mp, List<Deck> deck_cartas)
        {
            Name = name;
            HP = hp;
            MP = mp;
            Deck_cartas = deck_cartas;
        }

        public override string ToString()
        {
            return $"{Name}/{HP}/{MP}";
        }
        
    }
}