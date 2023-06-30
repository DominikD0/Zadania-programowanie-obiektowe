using Zad._3;

class Program
{
    static void Main()
    {
        Wektor v1 = new Wektor(1, 2, 3);
        Wektor v2 = new Wektor(4, 5, 6);

        Wektor suma = Wektor.Suma(v1, v2);
        Wektor różnica = v2 - v1;
        Wektor iloczyn1 = v1 * 2.5;
        Wektor iloczyn2 = 3 * v2;
        Wektor iloraz = v1 / 2;

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Różnica: {różnica}");
        Console.WriteLine($"Iloczyn 1: {iloczyn1}");
        Console.WriteLine($"Iloczyn 2: {iloczyn2}");
        Console.WriteLine($"Iloraz: {iloraz}");
        Console.WriteLine($"Długość v1: {v1.Długość}");

        Console.ReadKey();
    }
}