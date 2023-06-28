
public class Program
{
    private static void Main(string[] args)
    {
        //Zadanie1();
        Zadanie2();

    }
    private static void Zadanie1()
    {
        Osoba osoba = new Osoba("Jan Kowalski");
        osoba.DataUrodzenia = new DateTime(1999, 3, 6);
        osoba.DataSmierci = new DateTime(2090, 12, 31);

        Console.WriteLine($"Imię: {osoba.Imie}");
        Console.WriteLine($"Nazwisko: {osoba.Nazwisko}");
        Console.WriteLine($"Imię i nazwisko: {osoba.ImieNazwisko}");
        Console.WriteLine($"Wiek: {osoba.Wiek}");

        // Wyjątek przy próbie ustawienia pustego imienia
        osoba.Imie = "";
    }
    private static void Zadanie2() {
        Prostokat prostokat1 = new Prostokat(15, 30);
        Console.WriteLine($"Bok A: {prostokat1.BokA}");
        Console.WriteLine($"Bok B: {prostokat1.BokB}");

        Prostokat prostokat2 = Prostokat.ArkuszPapieru("A0");
        Console.WriteLine($"Bok A: {prostokat2.BokA}");
        Console.WriteLine($"Bok B: {prostokat2.BokB}");
    }
}
