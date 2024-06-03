// File: Program.cs

using System;

public class Program
{
    public static void Main()
    {
        // Test Domino
        Domino d1 = new Domino(1, 2);
        Domino d2 = new Domino(2, 3);
        Domino d3 = new Domino(4, 5);

        // Test MexicanTrain
        MexicanTrain mexicanTrain = new MexicanTrain(1);
        Console.WriteLine("Is Mexican Train empty? " + mexicanTrain.IsEmpty); // True
        mexicanTrain.PlayDomino(d1);
        Console.WriteLine("Is Mexican Train empty? " + mexicanTrain.IsEmpty); // False
        Console.WriteLine("Mexican Train last domino: " + mexicanTrain.LastDomino); // [1|2]
        Console.WriteLine("Is d2 playable on Mexican Train? " + mexicanTrain.IsPlayable(d2)); // True
        Console.WriteLine("Is d3 playable on Mexican Train? " + mexicanTrain.IsPlayable(d3)); // False

        // Test PlayerTrain
        Hand playerHand = new Hand();
        playerHand.AddDomino(d2);
        playerHand.AddDomino(d3);

        PlayerTrain playerTrain = new PlayerTrain(playerHand, 1);
        Console.WriteLine("Is Player Train empty? " + playerTrain.IsEmpty); // True
        playerTrain.PlayDomino(d1);
        Console.WriteLine("Is Player Train empty? " + playerTrain.IsEmpty); // False
        Console.WriteLine("Player Train last domino: " + playerTrain.LastDomino); // [1|2]
        Console.WriteLine("Is d2 playable on Player Train? " + playerTrain.IsPlayable(d2)); // True
        Console.WriteLine("Is d3 playable on Player Train? " + playerTrain.IsPlayable(d3)); // False

        // Test PlayerTrain open/closed state
        Console.WriteLine("Is Player Train open? " + playerTrain.IsOpen); // False
        playerTrain.MarkAsOpen();
        Console.WriteLine("Is Player Train open? " + playerTrain.IsOpen); // True
        playerTrain.MarkAsClosed();
        Console.WriteLine("Is Player Train open? " + playerTrain.IsOpen); // False
    }
}
