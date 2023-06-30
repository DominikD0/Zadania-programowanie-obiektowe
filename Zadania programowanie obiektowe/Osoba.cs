using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_programowanie_obiektowe
{
    internal class Osoba
    {
        private string imię;
        private string nazwisko;
        public DateTime? DataUrodzenia { get; set; }
        public DateTime? DataŚmierci { get; set; }

        public string Imię
        {
            get => imię;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Imię nie może być puste.");
                }
                imię = value;
            }
        }

        public string Nazwisko
        {
            get => nazwisko;
            set => nazwisko = value;
        }

        public string ImięNazwisko
        {
            get => $"{imię} {nazwisko}".Trim();
            set
            {
                string[] parts = value.Split(' ');
                if (parts.Length == 1)
                {
                    imię = value;
                    nazwisko = string.Empty;
                }
                else if (parts.Length > 1)
                {
                    imię = parts[0];
                    nazwisko = parts[parts.Length - 1];
                }
            }
        }

        public TimeSpan? Wiek
        {
            get
            {
                if (DataUrodzenia == null)
                {
                    return null;
                }

                DateTime endDate = DataŚmierci ?? DateTime.Now;
                return endDate - DataUrodzenia.Value;
            }
        }

        public Osoba(string imięNazwisko)
        {
            ImięNazwisko = imięNazwisko;
        }
    }
}
