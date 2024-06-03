
using System.Collections.Generic;

public class Hand
{
    public List<Domino> Dominos { get; private set; }

    public Hand()
    {
        Dominos = new List<Domino>();
    }

    public void AddDomino(Domino domino)
    {
        Dominos.Add(domino);
    }

    public void RemoveDomino(Domino domino)
    {
        Dominos.Remove(domino);
    }

    public override string ToString()
    {
        return string.Join(" ", Dominos);
    }
}
