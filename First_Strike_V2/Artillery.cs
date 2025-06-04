namespace First_Strike_V2.Models
{
    public class Artillery : StrikeOptions
    {
        public string BombType;
        public string EffectiveAgainst;

        public Artillery() : base()
        {
            Name = "M109";
            AmmunitionCapacity = 40;
            Fuel = 100;
            EffectiveAgainst = "open areas";
            BombType = "explosive shells";
        }

        public override string StrikeLog(Report report)
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
                string strikeLog = $"{TerroristPerson} attacked target using {BombType}!";
                return strikeLog;
            }
        }

        public override int Reload(Army army)
        {
            int maxCapacity = 40;
            int ammoNeeded = maxCapacity - AmmunitionCapacity;

            if (army.AmmunitionStock < ammoNeeded)
            {
                throw new InvalidOperationException("Insufficient ammunition");
            }

            AmmunitionCapacity += ammoNeeded;
            army.AmmunitionStock -= ammoNeeded;

            return AmmunitionCapacity;
        }


        public override float Refuel(Army army)
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
