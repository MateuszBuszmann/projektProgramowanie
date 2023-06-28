using System;
using System.Xml.Linq;

public class Wektor
{
    private double[] wspolrzedne;

    public Wektor(byte wymiar)
    {
        wspolrzedne = new double[wymiar];
    }

    public Wektor(params double[] wspolrzedne)
    {
        this.wspolrzedne = wspolrzedne;
    }

    public double Dlugosc
    {
        get { return (double)IloczynSkalarny(this, this); }
    }

    public byte Wymiar
    {
        get { return (byte)wspolrzedne.Length; }
    }

    public double this[byte index]
    {
        get { return wspolrzedne[index]; }
    }

    public static double? IloczynSkalarny(Wektor V, Wektor W)
    {
        if (V.Wymiar != W.Wymiar)
            return null;

        double iloczyn = 0;
        for (int i = 0; i < V.Wymiar; i++)
        {
            iloczyn += V.wspolrzedne[i] * W.wspolrzedne[i];
        }

        return iloczyn;
    }

    public static Wektor Suma(params Wektor[] wektory)
    {
        if (wektory.Length == 0)
        {
            throw new ArgumentException("Brak wektorów do zsumowania.");
        }

        byte wymiar = wektory[0].Wymiar;
        for (int i = 1; i < wektory.Length; i++)
        {
            if (wektory[i].Wymiar != wymiar)
            {
                throw new ArgumentException("Wektory mają różne wymiary.");
            }
        }

        Wektor suma = new Wektor(wymiar);
        for (int i = 0; i < wymiar; i++)
        {
            for (int j = 0; j < wektory.Length; j++)
            {
                suma.wspolrzedne[i] += wektory[j].wspolrzedne[i];
            }
        }

        return suma;
    }

    public static Wektor operator +(Wektor v1, Wektor v2)
    {
        return Suma(v1, v2);
    }

    public static Wektor operator -(Wektor v1, Wektor v2)
    {
        Wektor negatedV2 = new Wektor((byte)v2.wspolrzedne.Length);
        for (int i = 0; i < v2.wspolrzedne.Length; i++)
        {
            negatedV2.wspolrzedne[i] = -v2.wspolrzedne[i];

        }

        return Suma(v1, negatedV2);
    }

    public static Wektor operator *(Wektor v, double scalar)
    {
        double[] multiplied = new double[v.wspolrzedne.Length];
        for (int i = 0; i < v.wspolrzedne.Length; i++)
        {
            multiplied[i] = v.wspolrzedne[i] * scalar;
        }

        return new Wektor(multiplied);
    }

    public static Wektor operator *(double scalar, Wektor v)
    {
        return v * scalar;
    }

    public static Wektor operator /(Wektor v, double scalar)
    {
        if (v is null)
        {
            throw new ArgumentNullException(nameof(v));
        }

        if (scalar == 0)
        {
            throw new ArgumentException("Dzielenie przez zero.");
        }
        double[] divided = new double[v.wspolrzedne.Length];
        for (int i = 0; i < v.wspolrzedne.Length; i++)
        {
            divided[i] = v.wspolrzedne[i] / scalar;
        }

        return new Wektor(divided);
    }
    public override string ToString()
    {
        string result = "Wektor:";
        for (int i = 0; i < wspolrzedne.Length; i++)
        {
            result += $" {wspolrzedne[i]}";
        }
        return result;
    }
}


