using System;
using System.Collections.Generic;


namespace TheReckoning
{
    public class Deck
    {
        public List<Carta> Cartas;

        public Deck(List<Carta> cartas)
        {
            Cartas = cartas;
        }

        /*public static void Shuffle(List<Carta> deck, List<Carta> list)
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
        }*/
        
    }
}