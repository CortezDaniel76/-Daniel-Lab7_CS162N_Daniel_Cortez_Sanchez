//Daniel Cortez-Sanchez 6/7/2024

using System;

public class Domino : IComparable<Domino>
{
    public int Side1 { get; private set; }
    public int Side2 { get; private set; }

    public Domino(int side1, int side2)
    {
        Side1 = side1;
        Side2 = side2;
    }

    public int Score => Side1 + Side2;

    public void Flip()
    {
        int temp = Side1;
        Side1 = Side2;
        Side2 = temp;
    }

    public int CompareTo(Domino other)
    {
        if (other == null) return 1;
        return Score.CompareTo(other.Score);
    }

    public override string ToString()
    {
        return $"[{Side1}|{Side2}] (Score: {Score})";
    }
}
