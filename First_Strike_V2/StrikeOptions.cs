using System;

namespace First_Strike_V2
{
    public class StrikeOptions
    {
        public string Name;
        public int AmmunitionCapacity;
        public float Fuel;
        public string EffectiveAgainst;

        public StrikeOptions(string name, int ammunitionCapacity, float fuel, string effectiveAgainst)
        {
            Name = name;
            AmmunitionCapacity = ammunitionCapacity;
            Fuel = fuel;
            EffectiveAgainst = effectiveAgainst;
        }
    }
}

