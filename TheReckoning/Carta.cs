using System;

namespace TheReckoning
{
    public class Carta
    {
        public string Name { get; }
        public int MP { get; }
        public int AP { get; }
        public int DP { get; set;}

        public Carta(string name, int mp, int ap, int dp)
        {
            Name = name;
            MP = mp;
            AP = ap;
            DP = dp;
        }

        public override string ToString()
        {
            return $"{Name}/Mana Points: {MP}/AP: Attack Points {AP}/Defense Points: {DP}";
        }
    }
}