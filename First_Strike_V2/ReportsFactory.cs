namespace First_Strike_V2.Models.Models
{
    public class ReportFactory
    {
        public List<Report> reports;
        public ReportFactory()
        {
            this.reports = new List<Report>();
        }

        public Report CreateRandoValuesReport(TerrorOrganization trrOrg)
        {
            Random Rand = new Random();

            Terrorist trr = trrOrg.TerroristsMembers[Rand.Next(trrOrg.TerroristsMembers.Count)];
            string place = Data.Places[Rand.Next(Data.Places.Count)];
            Report report = new Report(trr, place);
            reports.Add(report);
            return report;
        }
    }
}
