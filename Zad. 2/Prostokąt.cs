using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._2
{
    internal class Prostokąt
    {
        private double bokA;
        private double bokB;

        public double BokA
        {
            get { return bokA; }
            set
            {
                if (value <= 0 || double.IsNaN(value) || double.IsInfinity(value))
                    throw new ArgumentException("Wartość boku A musi być skończoną nieujemną liczbą.");
                bokA = value;
            }
        }

        public double BokB
        {
            get { return bokB; }
            set
            {
                if (value <= 0 || double.IsNaN(value) || double.IsInfinity(value))
                    throw new ArgumentException("Wartość boku B musi być skończoną nieujemną liczbą.");
                bokB = value;
            }
        }

        static Dictionary<char, decimal> wysokośćArkusza0 = new Dictionary<char, decimal>()
        {
            ['A'] = 1189,
            ['B'] = 1414,
            ['C'] = 1297
        };

        public static Prostokąt ArkuszPapieru(string format)
        {
            if (string.IsNullOrEmpty(format) || format.Length < 2)
                throw new ArgumentException("Nieprawidłowy format.");

            char litera = format[0];
            if (!wysokośćArkusza0.ContainsKey(litera))
                throw new ArgumentException("Nieznany format arkusza.");

            byte indeks;
            if (!byte.TryParse(format.Substring(1), out indeks))
                throw new ArgumentException("Nieprawidłowy indeks.");

            decimal wysokość = wysokośćArkusza0[litera];
            double pierwiastekZDwóch = Math.Sqrt(2);

            double bokA = (double)(wysokość / (decimal)Math.Pow(pierwiastekZDwóch, indeks));
            double bokB = bokA / pierwiastekZDwóch;

            return new Prostokąt(bokA, bokB);
        }

        public Prostokąt(double bokA, double bokB)
        {
            BokA = bokA;
            BokB = bokB;
        }



    }
}
