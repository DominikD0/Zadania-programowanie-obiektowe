using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._5
{
    using System;

    public class Macierz<T> : IEquatable<Macierz<T>>
    {
        private T[,] dane;

        public Macierz(int wymiarWierszy, int wymiarKolumn)
        {
            dane = new T[wymiarWierszy, wymiarKolumn];
        }

        public T this[int wiersz, int kolumna]
        {
            get { return dane[wiersz, kolumna]; }
            set { dane[wiersz, kolumna] = value; }
        }

        public static bool operator ==(Macierz<T> m1, Macierz<T> m2)
        {
            if (m1 is null && m2 is null)
                return true;
            if (m1 is null || m2 is null)
                return false;

            if (m1.dane.GetLength(0) != m2.dane.GetLength(0) || m1.dane.GetLength(1) != m2.dane.GetLength(1))
                return false;

            for (int i = 0; i < m1.dane.GetLength(0); i++)
            {
                for (int j = 0; j < m1.dane.GetLength(1); j++)
                {
                    if (!Equals(m1[i, j], m2[i, j]))
                        return false;
                }
            }

            return true;
        }

        public static bool operator !=(Macierz<T> m1, Macierz<T> m2)
        {
            return !(m1 == m2);
        }

        public bool Equals(Macierz<T> other)
        {
            return this == other;
        }

        public override bool Equals(object obj)
        {
            if (obj is Macierz<T> other)
                return Equals(other);

            return false;
        }

        public override int GetHashCode()
        {
            return dane.GetHashCode();
        }
    }

}
