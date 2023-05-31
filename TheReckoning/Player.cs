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

        public static void Shuffle(List<Carta> deck, List<Carta> list)
        {
            Random random = new Random();
            for(int i = 6; i > 0; i --)
            {
                Carta choosenCard = null;
                do
                {
                    int randomIndex = random.Next(i);
                    choosenCard = list[randomIndex];

                }while(choosenCard.QT <= 0);

                deck.Add(choosenCard);
                choosenCard.QT --;
            }
        }

        public override string ToString()
        {
            return $"{Name}/{HP}/{MP}";
        }
        
    }
}