using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KP
{
    class Language
    {
        string langName;

        public Language()
        {
            langName = "";
        }
        public void Updt(string LANG)
        {
            langName = LANG;
        }
        public string GetLanguage()
        {
            return langName;
        }
    }
}
