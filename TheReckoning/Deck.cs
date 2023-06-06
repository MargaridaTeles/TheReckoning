using System;
using System.Collections.Generic;


namespace TheReckoning
{
    public class Deck
    {
        public List<Carta> Cartas;

        /// <summary>
        /// Construtor do Deck
        /// </summary>
        /// <param name="cartas">Lista de cartas</param>
        public Deck(List<Carta> cartas)
        {
            Cartas = cartas;
        }
        
    }
}