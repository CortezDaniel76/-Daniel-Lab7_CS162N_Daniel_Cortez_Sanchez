//Daniel Cortez-Sanchez 6/7/24

public class PlayerTrain : Train
{
    public Hand PlayerHand { get; private set; }
    private bool isOpen;

    public PlayerTrain(Hand hand) : base()
    {
        PlayerHand = hand;
        isOpen = false;
    }

    public PlayerTrain(Hand hand, int engineValue) : base(engineValue)
    {
        PlayerHand = hand;
        isOpen = false;
    }

    public bool IsOpen => isOpen;

    public void MarkAsOpen()
    {
        isOpen = true;
    }

    public void MarkAsClosed()
    {
        isOpen = false;
    }

    public override bool IsPlayable(Domino domino)
    {
        return IsDominoPlayable(domino, out _);
    }
}
