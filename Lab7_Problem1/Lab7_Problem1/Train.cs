// File: Train.cs

using System;
using System.Collections.Generic;
using System.Text;

public abstract class Train
{
    protected List<Domino> dominos;
    protected int engineValue;

    protected Train()
    {
        dominos = new List<Domino>();
        engineValue = -1; // Default value when no engine is provided
    }

    protected Train(int engineValue)
    {
        dominos = new List<Domino>();
        this.engineValue = engineValue;
    }

    public int DominoCount => dominos.Count;

    public int EngineValue => engineValue;

    public bool IsEmpty => dominos.Count == 0;

    public Domino LastDomino => dominos.Count > 0 ? dominos[dominos.Count - 1] : null;

    public int PlayableValue => IsEmpty ? engineValue : LastDomino.Side2;

    public Domino GetDominoAt(int index)
    {
        if (index < 0 || index >= dominos.Count)
            throw new IndexOutOfRangeException("Index is out of range.");
        return dominos[index];
    }

    public bool IsDominoPlayable(Domino domino, out bool mustFlip)
    {
        if (domino.Side1 == PlayableValue)
        {
            mustFlip = false;
            return true;
        }
        else if (domino.Side2 == PlayableValue)
        {
            mustFlip = true;
            return true;
        }
        mustFlip = false;
        return false;
    }

    public void PlayDomino(Domino domino)
    {
        if (IsDominoPlayable(domino, out bool mustFlip))
        {
            if (mustFlip)
            {
                domino.Flip();
            }
            dominos.Add(domino);
        }
        else
        {
            throw new InvalidOperationException("Domino is not playable.");
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Engine: {engineValue}\n");
        sb.Append("Train: ");
        foreach (var domino in dominos)
        {
            sb.Append(domino.ToString());
            sb.Append(" ");
        }
        return sb.ToString();
    }

    public abstract bool IsPlayable(Domino domino);
}
