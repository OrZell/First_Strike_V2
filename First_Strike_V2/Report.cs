using First_Strike_V2.Models;
using Microsoft.VisualBasic;

namespace First_Strike_V2
{
    public class Report
    {
        public Terrorist TerroristPerson;
        public string Place;
        public string DateAndTime;

        public Report(Terrorist terrorist, string place, string dateandtime)
        {
            this.TerroristPerson = terrorist;
            this.Place = place;
            this.DateAndTime = dateandtime;
        }
    }
}
