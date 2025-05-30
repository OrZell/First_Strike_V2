namespace First_Strike_V2.Models
{
    public class Aman
    {
        public List<Report> Reports;
        public Dictionary<Terrorist, List<Report>> TerroristsAndReports;
        public Dictionary<Terrorist, int> TerroristsAndReportsNums;

        public Aman()
        {
            this.Reports = new List<Report>();
            this.TerroristsAndReports = new Dictionary<Terrorist, List<Report>>();
        }

        public void CreateReport(Terrorist terrorist, string place, string dateandtime)
        {
            Report report = new Report(terrorist, place);
            this.Reports.Add(report);

            if (!this.TerroristsAndReports.ContainsKey(terrorist))
            {
                this.TerroristsAndReports.Add(terrorist, new List<Report>());
                this.TerroristsAndReportsNums.Add(terrorist, 0);
            }
            this.TerroristsAndReports[terrorist].Add(report);
            this.TerroristsAndReportsNums[terrorist]++;
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
    }
}
