
public class Program
{
    private static void Main(string[] args)
    {
        Zadanie1();
        Zadanie2();
        Zadanie3();
        Zadanie4();


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

        
    }
    private static void Zadanie2()
    {
        Prostokat prostokat1 = new Prostokat(15, 30);
        Console.WriteLine($"Bok A: {prostokat1.BokA}");
        Console.WriteLine($"Bok B: {prostokat1.BokB}");

        Prostokat prostokat2 = Prostokat.ArkuszPapieru("A0");
        Console.WriteLine($"Bok A: {prostokat2.BokA}");
        Console.WriteLine($"Bok B: {prostokat2.BokB}");
    }
    private static void Zadanie3()
    {
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
        Console.WriteLine($"Suma v1, v2 i v3: {suma}");

        Wektor v4 = v1 + v2;
        Console.WriteLine($"v4 = v1 + v2: {v4}");

        Wektor v5 = v1 - v2;
        Console.WriteLine($"v5 = v1 - v2: {v5}");

        Wektor v6 = v1 * 2.5;
        Console.WriteLine($"v6 = v1 * 2.5: {v6}");

        Wektor v7 = 3.5 * v2;
        Console.WriteLine($"v7 = 3.5 * v2: {v7}");
            
        Wektor v8 = v2 / 2;
        Console.WriteLine($"v8 = v2 / 2: {v8}");
    }   
    private static void Zadanie4()
    {
        Macierz<int> m1 = new Macierz<int>(2, 2);
        m1[0, 0] = 1;
        m1[0, 1] = 2;
        m1[1, 0] = 3;
        m1[1, 1] = 4;

        Macierz<int> m2 = new Macierz<int>(2, 2);
        m2[0, 0] = 1;
        m2[0, 1] = 2;
        m2[1, 0] = 3;
        m2[1, 1] = 4;

        Macierz<int> m3 = new Macierz<int>(2, 2);
        m3[0, 0] = 5;
        m3[0, 1] = 6;
        m3[1, 0] = 7;
        m3[1, 1] = 8;

        Console.WriteLine($"m1 == m2: {m1 == m2}");
        Console.WriteLine($"m1 != m2: {m1 != m2}");
        Console.WriteLine($"m1 == m3: {m1 == m3}");
        Console.WriteLine($"m1 != m3: {m1 != m3}");

    }
}
