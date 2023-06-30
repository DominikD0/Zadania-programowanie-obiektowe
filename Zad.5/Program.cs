using Zad._5;

Macierz<int> macierz1 = new Macierz<int>(2, 2);
macierz1[0, 0] = 1;
macierz1[0, 1] = 2;
macierz1[1, 0] = 3;
macierz1[1, 1] = 4;

Macierz<int> macierz2 = new Macierz<int>(2, 2);
macierz2[0, 0] = 1;
macierz2[0, 1] = 2;
macierz2[1, 0] = 3;
macierz2[1, 1] = 4;

Macierz<int> macierz3 = new Macierz<int>(2, 2);
macierz3[0, 0] = 5;
macierz3[0, 1] = 6;
macierz3[1, 0] = 7;
macierz3[1, 1] = 8;

Console.WriteLine(macierz1 == macierz2); 
Console.WriteLine(macierz1 != macierz3); 

Console.WriteLine(macierz1.Equals(macierz2)); 
Console.WriteLine(macierz1.Equals(macierz3));
