using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace állatok
{
    internal class Macska : Emlosok
    {
        public Macska(string nev,double suly,string nem) 
            : base(nev,"cica","Meow",4,suly,nem)
        {

        }
    }
}
