namespace First_Strike_V2.Models
{
    public class ReportFactory
    {
        public List<Report> reports;
        public TerrorOrganization TrrOrg;
        public ReportFactory(TerrorOrganization trrOrg)
        {
            this.reports = new List<Report>();
            this.TrrOrg = trrOrg;
        }


        private bool CheckIfThereIsSometrrAlive()
        {
            bool sign = false;
            foreach (Terrorist trr in this.TrrOrg.TerroristsMembers)
            {
                if (trr.Status)
                {
                    sign = true;
                    break;
                }
            }
            return sign;
        }

        public Report CreateRandoValuesReport()
        {
            Random Rand = new Random();

            bool SometrrAlive = CheckIfThereIsSometrrAlive();

            if (!SometrrAlive)
            {
                throw new Exception(" There Are Not Terrorist Alive");
            }

            Terrorist trr = this.TrrOrg.TerroristsMembers[Rand.Next(this.TrrOrg.TerroristsMembers.Count)];

            string place = Data.Places[Rand.Next(Data.Places.Count)];
            Report report = new Report(trr, place);
            reports.Add(report);
            return report;
        }
    }
}
