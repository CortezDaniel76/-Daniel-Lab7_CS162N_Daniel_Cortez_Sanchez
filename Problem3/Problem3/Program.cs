//Daniel Cortez-Sanchez 6/7/24
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //Test Domino sorting
        List<Domino> dominos = new List<Domino>
        {
            new Domino(1, 2),
            new Domino(3, 4),
            new Domino(2, 6),
            new Domino(5, 5)
        };

        Console.WriteLine("Dominos before sorting:");
        foreach (var domino in dominos)
        {
            Console.WriteLine(domino);
        }

        dominos.Sort();

        Console.WriteLine("\nDominos after sorting by score:");
        foreach (var domino in dominos)
        {
            Console.WriteLine(domino);
        }

        //Test MexicanTrain with iteration
        MexicanTrain mexicanTrain = new MexicanTrain(1);
        mexicanTrain.PlayDomino(new Domino(1, 2));
        mexicanTrain.PlayDomino(new Domino(2, 3));
        mexicanTrain.PlayDomino(new Domino(3, 4));

        Console.WriteLine("\nIterating over Mexican Train:");
        foreach (var domino in mexicanTrain)
        {
            Console.WriteLine(domino);
        }

        //Test PlayerTrain with iteration
        Hand playerHand = new Hand();
        PlayerTrain playerTrain = new PlayerTrain(playerHand, 1);
        playerTrain.PlayDomino(new Domino(1, 2));
        playerTrain.PlayDomino(new Domino(2, 5));
        playerTrain.PlayDomino(new Domino(5, 6));

        Console.WriteLine("\nIterating over Player Train:");
        foreach (var domino in playerTrain)
        {
            Console.WriteLine(domino);
        }
    }
}
