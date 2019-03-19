using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KP
{
    class Country
    {
        string country;

        public Country()
        {
            country = "";
        }

        public void Updt(string CNTR)
        {
            country = CNTR;
        }
        public string GetCountry()
        {
            return country;
        }
    }
}
