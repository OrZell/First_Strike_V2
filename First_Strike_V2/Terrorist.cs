namespace First_Strike_V2.Models
{
    public class Terrorist
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Rank;
        public int Rank
        {
            get { return _Rank; }
            set { _Rank = value; }
        }

        private bool _Status;
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private List<Weapon> _Weapons;
        public List<Weapon> Weapons
        {
            get { return _Weapons; }
            set { _Weapons = value; }
        }

        public Terrorist(string name, int rank)
        {
            this._Name = name;
            this._Rank = rank;
            this._Status = true;
            this._Weapons = new List<Weapon>();
        }
    }
}
