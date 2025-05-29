using System;

namespace First_Strike_V2
{
    public class IDF
    {
        public string DateOfEstablishmen;
        public string CurrentCommander;
        public List<object> StrikeOptions;

        public IDF()
        {
            DateOfEstablishment = new DateTime(1948, 5, 26);
            CurrentCommander = "Lieutenant General Herzi Halevi";
            StrikeOptions = new List<object>();
        }
    }

}
