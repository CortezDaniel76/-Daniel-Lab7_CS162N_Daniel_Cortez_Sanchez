
public class MexicanTrain : Train
{
    public MexicanTrain() : base() { }

    public MexicanTrain(int engineValue) : base(engineValue) { }

    public override bool IsPlayable(Domino domino)
    {
        return IsDominoPlayable(domino, out _);
    }
}
