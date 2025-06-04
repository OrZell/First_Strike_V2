using System.Threading.Channels;

namespace First_Strike_V2.Models
{
    public class Menu
    {
        public Aman? aman;
        public IDF? idf;

        public Menu(Aman aman, IDF idf)
        {
            this.aman = aman;
            this.idf = idf;
        }
    }
}
