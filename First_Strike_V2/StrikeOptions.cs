using System;

namespace First_Strike_V2
{
    public class StrikeOptions : IStrikeOperations
    {
        public string Name;
        public int AmmunitionCapacity;
        public float Fuel;

        public StrikeOptions()
        {
            Name = "N/A";
            AmmunitionCapacity = 0;
            Fuel = 0;
        }

        public virtual string StrikeLog(Terrorist terrorist)
        {
            if (AmmunitionCapacity == 0)
            {
                throw new ArgumentException("Inssuficient ammunition");
            }
            else if (Fuel == 0)
            {
                throw new ArgumentException("Inssuficient fuel");
            }
            else
            {
                AmmunitionCapacity -= 0;
                Fuel -= 0;
                string strikeLog = $"{Name} attacked target!";
                return strikeLog;
            }
        }

        public virtual int Reload(Army army)
        {
            int maxCapacity = 0;
            int ammoNeeded = maxCapacity - AmmunitionCapacity;

            if (army.AmmunitionStock < ammoNeeded)
            {
                throw new InvalidOperationException("Insufficient Ammunition");
            }

            AmmunitionCapacity += ammoNeeded;
            army.AmmunitionStock -= ammoNeeded;

            return AmmunitionCapacity;
        }

        public virtual float Refuel(Army army)
        {
            float currentCapacity = Fuel;
            if (army.FuelDepot < 100)
            {
                throw new InvalidOperationException("Insufficient Fuel");
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

