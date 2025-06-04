namespace First_Strike_V2.Models
{
    public class Aman
    {
        public List<Report> Reports;
        public Dictionary<Terrorist, List<Report>> TerroristsAndReports;
        public Dictionary<Terrorist, int> TerroristsAndReportsNums;
        public TerrorOrganization TrrOrg;
        public ReportFactory RepFactor;

        public Aman(TerrorOrganization trrOrg)
        {
            this.Reports = new List<Report>();
            this.TerroristsAndReports = new Dictionary<Terrorist, List<Report>>();
            this.TerroristsAndReportsNums = new Dictionary<Terrorist, int>();
            this.TrrOrg = trrOrg;
            this.RepFactor = new ReportFactory(this.TrrOrg);
        }

        public void CreateReport(Terrorist terrorist, string place)
        {
            Report report = new Report(terrorist, place);
            this.Reports.Add(report);

            CheckAndApplyTerroristReports(report);
        }

        public void CreateRandomValuesReport()
        {
            Report report = this.RepFactor.CreateRandoValuesReport();
            this.Reports.Add(report);

            CheckAndApplyTerroristReports(report);
        }

        public List<Terrorist> MostReportedTerrorists()
        {
            List<Terrorist> trrs = new List<Terrorist>();
            int counter = 1;
            foreach (KeyValuePair<Terrorist, int> trr in this.TerroristsAndReportsNums)
            {
                if (trr.Value > counter && trr.Key.Status == true)
                {
                    counter = trr.Value;
                }
            }
            foreach (KeyValuePair<Terrorist, int> trr in this.TerroristsAndReportsNums)
            {
                if (trr.Value == counter && trr.Key.Status == true)
                {
                    trrs.Add(trr.Key);
                }
            }
            return trrs;
        }

        private void CheckAndApplyTerroristReports(Report report)
        {
            if (!this.TerroristsAndReports.ContainsKey(report.TerroristPerson))
            {
                this.TerroristsAndReports.Add(report.TerroristPerson, new List<Report>());
                this.TerroristsAndReportsNums.Add(report.TerroristPerson, 0);
            }
            this.TerroristsAndReports[report.TerroristPerson].Add(report);
            this.TerroristsAndReportsNums[report.TerroristPerson]++;
        }

        public string PrintReports()
        {
            string result = "";
            foreach (Report report in this.Reports)
            {
                result += report.Print() + "\n\n";
            }
            return result;
        }
    }
}
