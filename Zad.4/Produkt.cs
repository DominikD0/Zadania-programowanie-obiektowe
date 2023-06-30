using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._4
{

    public class Produkt
    {
        public string Nazwa { get; set; }
        public decimal CenaNetto { get; set; }
        public string KategoriaVAT { get; set; }
        public decimal CenaBrutto => ObliczCeneBrutto();
        public string KrajPochodzenia { get; set; }

        public virtual decimal ObliczCeneBrutto()
        {
            
            throw new NotImplementedException();
        }
    }
    }
