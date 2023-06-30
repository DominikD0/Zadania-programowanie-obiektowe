// See https://aka.ms/new-console-template for more information
using Zadania_programowanie_obiektowe;

Console.WriteLine("Hello, World!");
Osoba osoba = new Osoba("Dominik Jeden");
osoba.DataUrodzenia = new DateTime(1980, 1, 1);
osoba.DataŚmierci = new DateTime(2020, 2, 13);

Console.WriteLine($"Imię: {osoba.Imię}");
Console.WriteLine($"Nazwisko: {osoba.Nazwisko}");
Console.WriteLine($"Data urodzenia: {osoba.DataUrodzenia}");
Console.WriteLine($"Data śmierci: {osoba.DataŚmierci}");
Console.WriteLine($"Imię i nazwisko: {osoba.ImięNazwisko}");
Console.WriteLine($"Wiek: {osoba.Wiek}");