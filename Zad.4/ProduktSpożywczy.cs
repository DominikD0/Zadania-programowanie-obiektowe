using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._4
{
    public class ProduktSpożywczy : Produkt
    {
        public decimal Kalorie { get; set; }
        public HashSet<string> Alergeny { get; set; }

        public override decimal CenaBrutto
        {
            get
            {
               
                throw new NotImplementedException();
            }
        }

        public override string KrajPochodzenia => throw new NotImplementedException();
    }
