using System;
using System.Collections.Generic;


namespace TheReckoning
{
    public class Player
    {
        public string Name { get; }
        public int HP { get; }
        public int MP { get; }

        public Player(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
        }

        public override string ToString()
        {
            return $"{Name}/{HP}/{MP}";
        }
    }
}