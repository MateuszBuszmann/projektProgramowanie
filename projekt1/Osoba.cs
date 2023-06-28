using System;

public class Osoba
{
    private string imie;
    private string nazwisko;

    public Osoba(string imieNazwisko)
    {
        ImieNazwisko = imieNazwisko;
    }

    public string Imie
    {
        get { return imie; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Imię nie może być puste.");
            }
            imie = value;
        }
    }

    public string Nazwisko
    {
        get { return nazwisko; }
        set { nazwisko = value; }
    }

    public DateTime? DataUrodzenia { get; set; }
    public DateTime? DataSmierci { get; set; }

    public string ImieNazwisko
    {
        get { return $"{imie} {nazwisko}".Trim(); }
        set
        {
            var splitted = value.Split(' ');
            Imie = splitted[0];
            Nazwisko = splitted.Length > 1 ? splitted[splitted.Length - 1] : string.Empty;
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
            var endDate = DataSmierci ?? DateTime.Now;
            return endDate - DataUrodzenia.Value;
        }
    }
}
