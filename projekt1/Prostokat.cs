using System;
using System.Collections.Generic;

public class Prostokat
{
    private double bokA;
    private double bokB;

    public Prostokat(double bokA, double bokB)
    {
        BokA = bokA;
        BokB = bokB;
    }

    public double BokA
    {
        get { return bokA; }
        set
        {
            if (!double.IsFinite(value) || value < 0)
                throw new ArgumentException("Długość boku A musi być skończoną nieujemną liczbą.");
            bokA = value;
        }
    }

    public double BokB
    {
        get { return bokB; }
        set
        {
            if (!double.IsFinite(value) || value < 0)
                throw new ArgumentException("Długość boku B musi być skończoną nieujemną liczbą.");
            bokB = value;
        }
    }

    public static Dictionary<char, decimal> wysokoscArkusza0 = new Dictionary<char, decimal>
    {
        ['A'] = 1189,
        ['B'] = 1414,
        ['C'] = 1297
    };

    public static Prostokat ArkuszPapieru(string format)
    {
        if (format.Length < 2)
            throw new ArgumentException("Nieprawidłowy format arkusza papieru.");

        char key = format[0];
        string indexString = format.Substring(1);

        if (!wysokoscArkusza0.ContainsKey(key))
            throw new ArgumentException("Nieprawidłowy format arkusza papieru.");

        if (!byte.TryParse(indexString, out byte index))
            throw new ArgumentException("Nieprawidłowy format arkusza papieru.");

        decimal baseHeight = wysokoscArkusza0[key];
        double pierwiastekZDwoch = Math.Sqrt(2);
        double bokA = (double)(baseHeight / (decimal)Math.Pow(pierwiastekZDwoch, index));
        double bokB = bokA / pierwiastekZDwoch;

        return new Prostokat(bokA, bokB);
    }
}
