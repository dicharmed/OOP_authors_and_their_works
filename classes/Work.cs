using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KP
{
    class Work
    {
        string name_of_work;   

        public Work()
        {
            name_of_work = "";
        }

        public void Updt(string nfw)
        {
            name_of_work = nfw;           
        }

        public string GetName()
        {
            return name_of_work;
        }
    
    }
}
