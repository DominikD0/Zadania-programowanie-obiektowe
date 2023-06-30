using System;
using System.Collections.Generic;
using Zad._4;

//Nie potrafiłem poprawnie rozwiązać zadania
public interface ICenowy
{
    decimal ObliczCeneBrutto();
}

public class Program
{
    public static void Main()
    {
 
        ProduktSpożywczy produktSpożywczy = new ProduktSpożywczy()
        {
            Nazwa = "Mleko",
            CenaNetto = 2.5m,
            KategoriaVAT = "A",
            Kalorie = 100,
            Alergeny = new HashSet<string>() { "Laktoza" }
        };

        Console.WriteLine("Produkt spożywczy:");
        Console.WriteLine("Nazwa: " + produktSpożywczy.Nazwa);
        Console.WriteLine("Cena netto: " + produktSpożywczy.CenaNetto);
        Console.WriteLine("Kategoria VAT: " + produktSpożywczy.KategoriaVAT);
        Console.WriteLine("Cena brutto: " + produktSpożywczy.ObliczCeneBrutto());
        Console.WriteLine("Kalorie: " + produktSpożywczy.Kalorie);
        Console.WriteLine("Alergeny: " + string.Join(", ", produktSpożywczy.Alergeny));
        Console.WriteLine();


        ProduktSpożywczyNaWagę produktSpożywczyNaWagę = new ProduktSpożywczyNaWagę()
        {
            Nazwa = "Jabłka",
            CenaNetto = 3.0m,
            KategoriaVAT = "A",
            Kalorie = 50,
            Alergeny = new HashSet<string>() { "Brak" },
            Waga = 0.5m
        };

        Console.WriteLine("Produkt spożywczy na wagę:");
        Console.WriteLine("Nazwa: " + produktSpożywczyNaWagę.Nazwa);
        Console.WriteLine("Cena netto: " + produktSpożywczyNaWagę.CenaNetto);
        Console.WriteLine("Kategoria VAT: " + produktSpożywczyNaWagę.KategoriaVAT);
        Console.WriteLine("Cena brutto: " + produktSpożywczyNaWagę.ObliczCeneBrutto());
        Console.WriteLine("Kalorie: " + produktSpożywczyNaWagę.Kalorie);
        Console.WriteLine("Alergeny: " + string.Join(", ", produktSpożywczyNaWagę.Alergeny));
        Console.WriteLine("Waga: " + produktSpożywczyNaWagę.Waga);
        Console.WriteLine();


        Wielopak wielopak = new Wielopak()
        {
            Produkt = produktSpożywczy,
            Ilość = 6,
            CenaNetto = 12.0m
        };

        Console.WriteLine("Wielopak:");
        Console.WriteLine("Nazwa: " + wielopak.Produkt.Nazwa);
        Console.WriteLine("Ilość: " + wielopak.Ilość);
        Console.WriteLine("Cena netto: " + wielopak.CenaNetto);
        Console.WriteLine("Cena brutto: " + wielopak.ObliczCeneBrutto());
        Console.WriteLine("Kategoria VAT: " + wielopak.KategoriaVAT);
        Console.WriteLine("Kraj pochodzenia: " + wielopak.KrajPochodzenia);
    }
}
