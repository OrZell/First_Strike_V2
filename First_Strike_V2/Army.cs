using System;

namespace First_Strike_V2.Models
{
    public class Army
    {
        public string DateOfEstablishment { get; set; }
        public string CurrentCommander { get; set; }
        public List<StrikeOptions> StrikeOptions { get; set; }
        public Aman IntelligenceAgency { get; set; }
        public int FuelDepot { get; set; }
        public int AmmunitionStock { get; set; }

        public Army(string dateOfEstablishment, string currentCommander, List<StrikeOptions> strikeOptions, Aman intelligenceAgency, int fuelDepot, int ammunitionStock)
        {
            DateOfEstablishment = dateOfEstablishment;
            CurrentCommander = currentCommander;
            StrikeOptions = strikeOptions;
            IntelligenceAgency = intelligenceAgency;
            FuelDepot = fuelDepot;
            AmmunitionStock = ammunitionStock;
        }
    }

}
