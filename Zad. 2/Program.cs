// See https://aka.ms/new-console-template for more information
using Zad._2;
using System;

class Program
{
    static void Main()
    {
        Prostokąt prostokąt = new Prostokąt(5, 10);
        Console.WriteLine($"Bok A: {prostokąt.BokA}, Bok B: {prostokąt.BokB}");

        Prostokąt arkusz = Prostokąt.ArkuszPapieru("A2");
        Console.WriteLine($"Bok A arkusza: {arkusz.BokA}, Bok B arkusza: {arkusz.BokB}");

        Console.ReadLine();
    }
}