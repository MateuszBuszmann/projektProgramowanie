using System;

public class Macierz<T> : IEquatable<Macierz<T>> where T : IEquatable<T>
{
    private T[,] tablica;

    public int WymiarWierszy { get; }
    public int WymiarKolumn { get; }

    public Macierz(int wymiarWierszy, int wymiarKolumn)
    {
        WymiarWierszy = wymiarWierszy;
        WymiarKolumn = wymiarKolumn;

        tablica = new T[wymiarWierszy, wymiarKolumn];
    }

    public T this[int wiersz, int kolumna]
    {
        get { return tablica[wiersz, kolumna]; }
        set { tablica[wiersz, kolumna] = value; }
    }

    public bool Equals(Macierz<T> other)
    {
        if (other == null)
            return false;

        if (WymiarWierszy != other.WymiarWierszy || WymiarKolumn != other.WymiarKolumn)
            return false;

        for (int i = 0; i < WymiarWierszy; i++)
        {
            for (int j = 0; j < WymiarKolumn; j++)
            {
                if (!tablica[i, j].Equals(other[i, j]))
                    return false;
            }
        }

        return true;
    }

    public override bool Equals(object obj)
    {
        if (obj is Macierz<T>)
            return Equals((Macierz<T>)obj);

        return false;
    }

    public override int GetHashCode()
    {
        return tablica.GetHashCode();
    }

    public static bool operator ==(Macierz<T> m1, Macierz<T> m2)
    {
        if (ReferenceEquals(m1, m2))
            return true;

        if (m1 is null || m2 is null)
            return false;

        return m1.Equals(m2);
    }

    public static bool operator !=(Macierz<T> m1, Macierz<T> m2)
    {
        return !(m1 == m2);
    }
}
