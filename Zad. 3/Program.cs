// See https://aka.ms/new-console-template for more information
using Zad._3;

static void Main()
{
    Wektor v1 = new Wektor(1, 2, 3);
    Wektor v2 = new Wektor(4, 5, 6);

    Wektor suma = Wektor.Suma(v1, v2);
    Wektor różnica = v2 - v1;
    Wektor iloczyn1 = v1 * 2.5;
    Wektor iloczyn2 = 3 * v2;
    Wektor iloraz = v1 / 2;

    Console.WriteLine($"Suma: {string.Join(", ", suma.Współrzędne)}");
    Console.WriteLine($"Różnica: {string.Join(", ", różnica.Współrzędne)}");
    Console.WriteLine($"Iloczyn 1: {string.Join(", ", iloczyn1.Współrzędne)}");
    Console.WriteLine($"Iloczyn 2: {string.Join(", ", iloczyn2.Współrzędne)}");
    Console.WriteLine($"Iloraz: {string.Join(", ", iloraz.Współrzędne)}");
    Console.WriteLine($"Długość v1: {v1.Długość}");

    Console.ReadLine();
}