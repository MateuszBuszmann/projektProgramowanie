Osoba osoba = new Osoba("Jan Kowalski");
osoba.DataUrodzenia = new DateTime(1999, 3, 6);
osoba.DataSmierci = new DateTime(2090, 12, 31);

Console.WriteLine($"Imię: {osoba.Imie}");
Console.WriteLine($"Nazwisko: {osoba.Nazwisko}");
Console.WriteLine($"Imię i nazwisko: {osoba.ImieNazwisko}");
Console.WriteLine($"Wiek: {osoba.Wiek}");

// Wyjątek przy próbie ustawienia pustego imienia
osoba.Imie = "";

