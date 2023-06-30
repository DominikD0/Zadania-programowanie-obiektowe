using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._4
{
    public class ProduktSpożywczyNapój<T> : ProduktSpożywczyPaczka
    {
        public T Objętość { get; set; }
    }
}
