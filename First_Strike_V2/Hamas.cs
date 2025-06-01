namespace First_Strike_V2.Models
{
    public class TerrorOrganization
    {
        private string _Date;
        public string Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private Terrorist _CurrentCommander;
        public Terrorist CurrentCommander
        {
            get { return _CurrentCommander; }
            set { _CurrentCommander = value; }
        }

        private List<Terrorist> _TerroristsMembers;
        public List<Terrorist> TerroristsMembers
        {
            get { return _TerroristsMembers; }
            set { _TerroristsMembers = value; }
        }

        public TerrorOrganization(string date)
        {
            this._Date = date;
        }

        public void AddMember(Terrorist trr)
        {
            this._TerroristsMembers.Add(trr);
        }
    }
}
