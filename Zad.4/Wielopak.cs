using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._4
{

    public class Wielopak : Produkt, ICenowy
    {
        public Produkt Produkt { get; set; }
        public ushort Ilość { get; set; }
        public decimal CenaNetto { get; set; }

        public override decimal CenaBrutto
        {
            get
            {

                throw new NotImplementedException();
            }
        }

        public override string KategoriaVAT 
        {
            get { return Produkt.KategoriaVAT; }
        }

        public override string KrajPochodzenia => Produkt.KrajPochodzenia;

        decimal ICenowy.ObliczCeneBrutto()
        {
            return ObliczCeneBrutto();
        }
    }



}
