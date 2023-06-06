using System;

namespace TheReckoning
{
    public class Carta
    {
        public string Name { get; }
        public int MP { get; }
        public int AP { get; set;}
        public int DP { get; set;}

    /// <summary>
    /// Construtor da Carta
    /// </summary>
    /// <param name="name">Nome da carta</param>
    /// <param name="mp">Custo da carta</param>
    /// <param name="ap">Pontos de Ataque</param>
    /// <param name="dp">Pontos de Defesa</param>
        public Carta(string name, int mp, int ap, int dp)
        {
            Name = name;
            MP = mp;
            AP = ap;
            DP = dp;
        }
    /// <summary>
    /// Escreve para todas as cartas as caracteristicas das cartas,
    /// ou seja NAME, MP, AP e DP.
    /// </summary>
    /// <returns>As características das cartas</returns>
        public override string ToString()
        {
            return $"{Name}/Mana Points: {MP}/AP: Attack Points {AP}/Defense Points: {DP}";
        }
    }
}