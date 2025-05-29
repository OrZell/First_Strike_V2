using System;

namespace First_Strike_V2
{
    public class FighterJet : StrikeOptions
    {
        public List<string> BombType;
        public string Operator;

        public FighterJet() : base()
        {
            Name = "F-16";
            AmmunitionCapacity = 8;
            Fuel = 100;
            EffectiveAgainst = "buildings";
            BombType = { "0.5 Ton", "1 Ton"}
            
        }
    }
}

