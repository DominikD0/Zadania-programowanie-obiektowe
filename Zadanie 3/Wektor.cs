using System;

namespace Zadanie
{
    public class Wektor
    {
        private double[] współrzędne;

        public double Długość { get { return IloczynSkalarny(this, this); } }
        public int Wymiar { get { return współrzędne.Length; } }

        public double this[int indeks]
        {
            get { return współrzędne[indeks]; }
            set { współrzędne[indeks] = value; }
        }

        public Wektor(int wymiar)
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
            {
                throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");
            }

            double iloczyn = 0;
            for (int i = 0; i < V.Wymiar; i++)
            {
                iloczyn += V[i] * W[i];
            }

            return iloczyn;
        }

        public static Wektor Suma(params Wektor[] Wektory)
        {
            if (Wektory.Length == 0)
            {
                throw new ArgumentException("Nie podano żadnego wektora do sumowania.");
            }

            int wymiar = Wektory[0].Wymiar;

            for (int i = 1; i < Wektory.Length; i++)
            {
                if (Wektory[i].Wymiar != wymiar)
                {
                    throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");
                }
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

        public static Wektor operator +(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
            {
                throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");
            }

            Wektor suma = new Wektor(V.Wymiar);

            for (int i = 0; i < V.Wymiar; i++)
            {
                suma[i] = V[i] + W[i];
            }

            return suma;
        }

        public static Wektor operator -(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
            {
                throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");
            }

            Wektor różnica = new Wektor(V.Wymiar);

            for (int i = 0; i < V.Wymiar; i++)
            {
                różnica[i] = V[i] - W[i];
            }

            return różnica;
        }

        public static Wektor operator *(Wektor V, double skalar)
        {
            Wektor iloczyn = new Wektor(V.Wymiar);

            for (int i = 0; i < V.Wymiar; i++)
            {
                iloczyn[i] = V[i] * skalar;
            }

            return iloczyn;
        }

        public static Wektor operator *(double skalar, Wektor V)
        {
            return V * skalar;
        }

        public static Wektor operator /(Wektor V, double skalar)
        {
            if (skalar == 0)
            {
                throw new DivideByZeroException("Nie można dzielić przez zero.");
            }

            Wektor iloraz = new Wektor(V.Wymiar);

            for (int i = 0; i < V.Wymiar; i++)
            {
                iloraz[i] = V[i] / skalar;
            }

            return iloraz;
        }
    }
}
