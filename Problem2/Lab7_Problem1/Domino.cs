
public class Domino
{
    public int Side1 { get; private set; }
    public int Side2 { get; private set; }

    public Domino(int side1, int side2)
    {
        Side1 = side1;
        Side2 = side2;
    }

    public void Flip()
    {
        int temp = Side1;
        Side1 = Side2;
        Side2 = temp;
    }

    public override string ToString()
    {
        return $"[{Side1}|{Side2}]";
    }
}
