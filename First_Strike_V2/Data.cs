namespace First_Strike_V2.Models
{
    public class Data
    {
        public static List<string> Places = new List<string> { "in a car", "outside", "home" };

        public static List<string> Names = new List<string> { "Abed", "Ziad", "Halal", "Muafak",
            "Haled", "Abed", "Maruan", "Usamma", "Fatach", "Musa", "Samir", "Naser", "Yusuf", "Talal"};

        public static Dictionary<string, int> Weapons = new Dictionary<string, int>
        {
            { "m16", 3 },
            { "ak47", 3 },
            { "gun", 2 },
            { "knife", 1 },

        };
    }
}
