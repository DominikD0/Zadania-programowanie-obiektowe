using System;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Wektor v1 = new Wektor(1, 2, 3);
            Wektor v2 = new Wektor(4, 5, 6);

            Wektor suma = Wektor.Suma(v1, v2);
            Wektor różnica = v2 - v1;
            Wektor iloczyn1 = v1 * 2.5;
            Wektor iloczyn2 = 3 * v2;
            Wektor iloraz = v1 / 2;

            Console.WriteLine($"Suma: {string.Join(", ", suma)}");
            Console.WriteLine($"Różnica: {string.Join(", ", różnica)}");
            Console.WriteLine($"Iloczyn 1: {string.Join(", ", iloczyn1)}");
            Console.WriteLine($"Iloczyn 2: {string.Join(", ", iloczyn2)}");
            Console.WriteLine($"Iloraz: {string.Join(", ", iloraz)}");
            Console.WriteLine($"Długość v1: {v1.Długość}");
            Console.WriteLine($"Wymiar v2: {v2.Wymiar}");

            Console.ReadLine();
        }
    }
}
