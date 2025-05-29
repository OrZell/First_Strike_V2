using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Strike_V2.Models
{
    public class Hamas
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

        public Hamas(string date)
        {
            this._Date = date;
        }
    }
}
