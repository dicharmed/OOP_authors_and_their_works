using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KP
{
    class Author
    {
        string fio;

        public Author()
        {
            fio = "";
        }
        public void Updt(string FIO)
        {
            fio = FIO;
        }
        public string GetAuthor()
        {
            return fio;
        }
    }
}
