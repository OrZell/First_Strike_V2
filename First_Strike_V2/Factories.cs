namespace First_Strike_V2.Models
{
    public class TerroristsFactory
    {
        public List<Terrorist> ListOfTerroristFactory;

        public Terrorist CreateTerrorist(string name, int rank)
        {
            Terrorist trr = new Terrorist(name, rank);
            ListOfTerroristFactory.Add(trr);
            return trr;
        }
    }
}
