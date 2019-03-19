using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KP
{
    class Genre
    {
        string genre;

        public Genre()
        {
            genre = "";
        }
        public void Updt(string GNR)
        {
            genre = GNR;
        }
        public string GetGenre()
        {
            return genre;
        }
    }
}
