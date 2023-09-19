using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace állatok
{
    internal class Kutya : Emlosok
    {
        public Kutya(string nev, double suly, string nem) : base(nev, "kutya", "vaúú-vaúú", 4, suly, nem)
        {
        }


    }
}
