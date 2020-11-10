using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviParcijalniPR3
{
    public class Predmet
    {
        public int IndekserPredmeta=0;
        public string NazivPredmeta { get; set; }
        public int  Ocjena { get; set; }
        public DateTime datumPolaganja { get; set; }

        public Predmet()
        {
            IndekserPredmeta += 1;
            NazivPredmeta = "Predmet" + IndekserPredmeta.ToString();
            Ocjena = 5;
            datumPolaganja = DateTime.Now;
        }
    }
}
