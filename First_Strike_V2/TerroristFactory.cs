namespace First_Strike_V2.Models
{
    public class TerroristFactory
    {
        public class TerroristsFactory
        {
            public List<Terrorist> ListOfTerroristByFactory;

            public Terrorist CreateTerrorist(string name, int rank)
            {
                Terrorist trr = new Terrorist(name, rank);
                ListOfTerroristByFactory.Add(trr);
                return trr;
            }
        }
    }
}
