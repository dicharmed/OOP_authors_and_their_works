using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KP
{
    class Readership
    {
        string circulation;//номер тиража

        public Readership()
        {
            circulation = "";
        }
        public void Updt(string cn)
        {
            circulation = cn;
        }
        public string GetCirculation()
        {
            return circulation;
        }
    }
}
