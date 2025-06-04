using System;

namespace First_Strike_V2.Models
{
    public class FighterJet : StrikeOptions
    {
        public List<string> BombType;
        public string EffectiveAgainst;
        public string Pilot { get; set; }

        public FighterJet() : base()
        {
            Name = "F-16";
            AmmunitionCapacity = 8;
            Fuel = 100;
            EffectiveAgainst = "buildings";
            BombType = new List<string> { "0.5 Ton", "1 Ton" };
            Pilot = "Or Zelinger";
        }

        public string StrikeLog(Report report)
        {
            if (AmmunitionCapacity == 0)
            {
                throw new ArgumentException("Insufficient ammunition");
            }
            else if (Fuel == 0)
            {
                throw new ArgumentException("Insufficient fuel");
            }
            else
            {
                AmmunitionCapacity -= 1;
                Fuel -= 25;
                string strikeLog = $"{report.TerroristPerson} attacked target using {BombType}!";
                return strikeLog;
            }
        }

        public int Reload(Army army)
        {
            int maxCapacity = 8;
            int ammoNeeded = maxCapacity - AmmunitionCapacity;

            if (army.AmmunitionStock < ammoNeeded)
            {
                throw new InvalidOperationException("Insufficient ammunition");
            }

            AmmunitionCapacity += ammoNeeded;
            army.AmmunitionStock -= ammoNeeded;

            return AmmunitionCapacity;
        }

        public float Refuel(Army army)
        {
            float currentCapacity = Fuel;
            if (army.FuelDepot < 100)
            {
                throw new InvalidOperationException("Insufficient fuel");
            }
            else
            {
                Fuel += 100;
                army.FuelDepot -= 100;
            }

            return Fuel;
        }
    }
}

