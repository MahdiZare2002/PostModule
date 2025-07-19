namespace PostModule.Domain.PostEntity.ValueObjects;

public class PriceDetails
{
    public int Tehran { get; private set; }
    public int StateCenter { get; private set; }
    public int City { get; private set; }
    public int InsideState { get; private set; }
    public int StateClose { get; private set; }
    public int StateNonClose { get; private set; }

    public PriceDetails(int tehran, int stateCenter, int city, int insideState, int stateClose, int stateNonClose)
    {
        Tehran = tehran;
        StateCenter = stateCenter;
        City = city;
        InsideState = insideState;
        StateClose = stateClose;
        StateNonClose = stateNonClose;
    }
}