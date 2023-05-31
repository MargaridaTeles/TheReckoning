using System;

namespace TheReckoning
{
    public class Carta
    {
        public string Name { get; }
        public int MP { get; }
        public int AP { get; }
        public int DP { get; }
        public int QT { get; }

        public Carta(string name, int mp, int ap, int dp, int qt)
        {
            Name = name;
            MP = mp;
            AP = ap;
            DP = dp;
            QT = qt; 
        }

        public override string ToString()
        {
            return $"{Name}/{MP}/{AP}/{DP}";
        }
    }
}