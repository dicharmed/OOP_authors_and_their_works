using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KP
{
    class Publishing_house
    {
        string name_publishing_house;

        public Publishing_house()
        {
            name_publishing_house = "";
        }
        public void Updt(string nph)
        {
            name_publishing_house = nph;
        }

        public string GetHouse()
        {
            return name_publishing_house;
        }
    }
}
