namespace First_Strike_V2.Models
{
    public class Report
    {
        public Terrorist TerroristPerson;
        public string Place;
        public DateTime DateAndTime;

        public Report(Terrorist terrorist, string place)
        {
            this.TerroristPerson = terrorist;
            this.Place = place;
            this.DateAndTime = DateTime.Now;
        }

        public string Print()
        {
            string result = "" +
                $"Terrorist: {this.TerroristPerson.Print()}\n" +
                $"Place: {this.Place}\n" +
                $"Date: {this.DateAndTime.ToString()}";
            return result;
        }
    }
}
