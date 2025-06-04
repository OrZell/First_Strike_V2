namespace First_Strike_V2.Models
{
    public class Initialization
    {

        public static TerrorOrganization Hamas = new TerrorOrganization("01/01/2000");
        public static Aman aman = new Aman(Hamas);
        public static TerroristFactory trrFactor = new TerroristFactory();
        public static IDF idf = IDF.CreateIDF(aman);


        public static void Init()
        {
            for (int i = 0; i < 10; i++)
            {
                Hamas.AddMember(trrFactor.CreateRandoValuesTerrorist());
            }

            for (int i = 0; i < 25; i++)
            {
                aman.CreateRandomValuesReport();
            }
        }

    }
}
