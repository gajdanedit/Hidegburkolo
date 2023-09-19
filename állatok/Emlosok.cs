using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace állatok
{
    internal class Emlosok {

        public string nev;
        public string faj;
        public string hang;
        public int labszam;
        public double suly;
        public string nem;

        public String getHangotAd()
        {
            return hang;
        }
        public void setHangotAd(string hang)
        {
            this.hang=hang;

        }
        public string halad()
        {
            return "előre";
        }
        public override string ToString() 
        {
            return this.faj;
        }





        public Emlosok(string nev, string faj, string hang, int labszam, double suly, string nem)
        {
            this.nev=nev;
            this.faj = faj;
            this.hang = hang;
            this.labszam = labszam;
            this.suly = suly;
            this.nem = nem;
          
        }
    }

}

