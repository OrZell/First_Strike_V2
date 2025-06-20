﻿using System;
using System;
using System.Collections.Generic;

namespace First_Strike_V2
{
    public class IDF : Army
    {
        private static IDF _case;

        public static IDF Case
        {
            get
            {
                if (_case == null)
                {
                    _case = new IDF( "1948-05-26",  "Lt. Gen. Herzl Halevi", new List<StrikeOptions>(), new Aman(), 1000, 5000);
                }
                return _case;
            }
        }

        private IDF(string dateOfEstablishment, string currentCommander, List<StrikeOptions> strikeOptions,  Aman intelligenceAgency, int fuelDepot, int ammunitionStock) : base(dateOfEstablishment, currentCommander, strikeOptions, intelligenceAgency, fuelDepot, ammunitionStock)
        {
        }
    }
}

