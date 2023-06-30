using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._3
{
    internal class Wektor
    {
        private double[] współrzędne;

        public double Długość { get { return Math.Sqrt(IloczynSkalarny(this, this)); } }
        public byte Wymiar { get { return (byte)współrzędne.Length; } }

        public double this[byte indeks]
        {
            get { return współrzędne[indeks]; }
            set { współrzędne[indeks] = value; }
        }

        public Wektor(byte wymiar)
        {
            współrzędne = new double[wymiar];
        }

        public Wektor(params double[] współrzędne)
        {
            this.współrzędne = współrzędne;
        }

        public static double IloczynSkalarny(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
                throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");

            double iloczyn = 0;
            for (int i = 0; i < V.Wymiar; i++)
            {
                iloczyn += V[i] * W[i];
            }
            return iloczyn;
        }

        public static Wektor Suma(params Wektor[] Wektory)
        {
            byte wymiar = Wektory[0].Wymiar;
            foreach (Wektor wektor in Wektory)
            {
                if (wektor.Wymiar != wymiar)
                    throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");
            }

            Wektor suma = new Wektor(wymiar);
            for (int i = 0; i < wymiar; i++)
            {
                for (int j = 0; j < Wektory.Length; j++)
                {
                    suma[i] += Wektory[j][i];
                }
            }
            return suma;
        }

        public static Wektor operator +(Wektor v1, Wektor v2)
        {
            if (v1.Wymiar != v2.Wymiar)
                throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");

            Wektor suma = new Wektor(v1.Wymiar);
            for (int i = 0; i < v1.Wymiar; i++)
            {
                suma[i] = v1[i] + v2[i];
            }
            return suma;
        }

        public static Wektor operator -(Wektor v1, Wektor v2)
        {
            if (v1.Wymiar != v2.Wymiar)
                throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");

            Wektor różnica = new Wektor(v1.Wymiar);
            for (int i = 0; i < v1.Wymiar; i++)
            {
                różnica[i] = v1[i] - v2[i];
            }
            return różnica;
        }

        public static Wektor operator *(Wektor v, double skalar)
        {
            Wektor iloczyn = new Wektor(v.Wymiar);
            for (int i = 0; i < v.Wymiar; i++)
            {
                iloczyn[i] = v[i] * skalar;
            }
            return iloczyn;
        }

        public static Wektor operator *(double skalar, Wektor v)
        {
            return v * skalar;
        }

        public static Wektor operator /(Wektor v, double skalar)
        {
            if (skalar == 0)
                throw new DivideByZeroException("Nie można dzielić przez zero.");

            Wektor iloraz = new Wektor(v.Wymiar);
            for (int i = 0; i < v.Wymiar; i++)
            {
                iloraz[i] = v[i] / skalar;
            }
            return iloraz;
        }
}
