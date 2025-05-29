namespace First_Strike_V2.Models
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

    public class TerrorOrganizationFactory
    {
        public List<TerrorOrganization> ListOfTerrorOrganizationByFactory;

        public TerrorOrganization CreateTerrorOrganization(string date)
        {
            TerrorOrganization trro = new TerrorOrganization(date);
            ListOfTerrorOrganizationByFactory.Add(trro);
            return trro;
        }
    }
}
