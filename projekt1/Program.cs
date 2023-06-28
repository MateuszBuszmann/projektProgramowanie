
public class Program
{
    private static void Main(string[] args)
    {
        //Zadanie1();
        //Zadanie2();
        Zadanie3();

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
    private static void Zadanie3() {
        Wektor v1 = new Wektor(1, 2, 3);
        Wektor v2 = new Wektor(4, 5, 6);
        Wektor v3 = new Wektor(1, 1, 1);

        Console.WriteLine($"Wymiar v1: {v1.Wymiar}");
        Console.WriteLine($"Długość v1: {v1.Dlugosc}");
        Console.WriteLine($"Współrzędna v1[0]: {v1[0]}");

        double? iloczynSkalarny = Wektor.IloczynSkalarny(v1, v2);
        if (iloczynSkalarny.HasValue)
        {
            Console.WriteLine($"Iloczyn skalarny v1 i v2: {iloczynSkalarny.Value}");
        }
        else
        {
            Console.WriteLine("Wektory mają różne wymiary.");
        }

        Wektor suma = Wektor.Suma(v1, v2, v3);
        Console.WriteLine($"Suma v1, v2 i v3: {string.Join(", ", suma)}");

        Wektor v4 = v1 + v2;
        Console.WriteLine($"v4 = v1 + v2: {string.Join(", ", v4)}");

        Wektor v5 = v1 - v2;
        Console.WriteLine($"v5 = v1 - v2: {string.Join(", ", v5)}");

        Wektor v6 = v1 * 2.5;
        Console.WriteLine($"v6 = v1 * 2.5: {string.Join(", ", v6)}");

        Wektor v7 = 3.5 * v2;
        Console.WriteLine($"v7 = 3.5 * v2: {string.Join(", ", v7)}");

        Wektor v8 = v2 / 2;
        Console.WriteLine($"v8 = v2 / 2: {string.Join(", ", v8)}");
    }
}
