// File: Program.cs

using System;

public class Program
{
    public static void Main()
    {
        Domino d1 = new Domino(1, 2);
        Domino d2 = new Domino(2, 3);
        Domino d3 = new Domino(4, 5);

        SimpleTrain train = new SimpleTrain(1);

        Console.WriteLine("Is train empty? " + train.IsEmpty); // True
        train.PlayDomino(d1);
        Console.WriteLine("Is train empty? " + train.IsEmpty); // False
        Console.WriteLine("Last domino: " + train.LastDomino); // [1|2]

        Console.WriteLine("Is d2 playable? " + train.IsPlayable(d2)); // True
        Console.WriteLine("Is d3 playable? " + train.IsPlayable(d3)); // False

        train.PlayDomino(d2);
        Console.WriteLine("Train: " + train.ToString());

        try
        {
            train.PlayDomino(d3);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message); // Domino is not playable
        }
    }
}
