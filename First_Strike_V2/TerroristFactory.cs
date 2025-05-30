namespace First_Strike_V2.Models
{
    public class TerroristFactory
    {
        public List<Terrorist> Terrorists;

        public TerroristFactory()
        {
            this.Terrorists = new List<Terrorist>();
        }

        public Terrorist CreateRandoValuesTerrorist()
        {
            Random Rand = new Random();
            List<string> weapons = new List<string>();


            int ManyWeapons = Rand.Next(Data.Weapons.Count);

            string name = Data.Names[Rand.Next(Data.Names.Count)];
            int rank = Rand.Next(6);
            while (ManyWeapons > 0)
            {
                string weapon = Data.Weapons.Keys.ElementAt(Rand.Next(Data.Weapons.Count));
                if (weapons.Contains(weapon))
                {
                    continue;
                }
                weapons.Add(weapon);
                ManyWeapons--;
            }

            Terrorist terrorist = new Terrorist(name, rank, weapons);
            this.Terrorists.Add(terrorist);
            return terrorist;
        }
    }
}
